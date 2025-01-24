using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using C968FormsAppv3.Models;

namespace C968FormsAppv3
{
    public partial class ModifyProductForm : Form
    {
        private Product newProduct;
        private BindingList<Part> associatedParts; 
        private Inventory inventory;

        public ModifyProductForm(Product product, Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
            newProduct = product;
            associatedParts = new BindingList<Part>(product.AssociatedParts);
            IDtxt.Enabled = false;

            // Set the PartsDataGrid
            PartsDataGrid.DataSource =  inventory.AllParts;
            PartsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PartsDataGrid.ReadOnly = true;
            PartsDataGrid.MultiSelect = false;
            PartsDataGrid.RowHeadersVisible = false;
            PartsDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            PartsDataGrid.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

            // Set the AssociatedPartsDataGrid
            AssociatedParts.DataSource = associatedParts;
            AssociatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AssociatedParts.ReadOnly = true;
            AssociatedParts.MultiSelect = false;
            AssociatedParts.RowHeadersVisible = false;
            AssociatedParts.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            AssociatedParts.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            
            // Populate fields
            IDtxt.Text = product.ProductID.ToString();
            Nametxt.Text = product.Name;
            Pricetxt.Text = product.Price.ToString();
            Instocktxt.Text = product.InStock.ToString();
            Mintxt.Text = product.Min.ToString();
            Maxtxt.Text = product.Max.ToString();
        }

        private bool allowSave()
        {
            if (string.IsNullOrWhiteSpace(Nametxt.Text) || string.IsNullOrWhiteSpace(Instocktxt.Text) ||
                string.IsNullOrWhiteSpace(Pricetxt.Text) || string.IsNullOrWhiteSpace(Mintxt.Text) ||
                string.IsNullOrWhiteSpace(Maxtxt.Text))
            {
                return false;
            }

            if (!int.TryParse(Instocktxt.Text, out int inStock) || inStock < 0 || inStock > 100)
            {
                return false;
            }

            if (!int.TryParse(Mintxt.Text, out int min) || min < 0 || min > 100 ||
                !int.TryParse(Maxtxt.Text, out int max) || max < 0 || max > 100 ||
                min > max || inStock < min || inStock > max)
            {
                return false;
            }

            return true;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (allowSave())
            {
                newProduct.Name = Nametxt.Text;
                newProduct.Price = decimal.Parse(Pricetxt.Text);
                newProduct.InStock = int.Parse(Instocktxt.Text);
                newProduct.Min = int.Parse(Mintxt.Text);
                newProduct.Max = int.Parse(Maxtxt.Text);


                newProduct.AssociatedParts = new BindingList<Part>(associatedParts);
                inventory.UpdateProduct(newProduct);


                inventory.UpdateProduct(newProduct);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter valid values for all fields.");
            }
        
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Part selectedPart = GetSelectedPart();
            if (selectedPart != null)
            {

                if (!newProduct.AssociatedParts.Contains(selectedPart))
                {
                    newProduct.AddAssociatedPart(selectedPart);
                    RefreshAssociatedPartsGrid();
                }

            }
            else
            {
                MessageBox.Show("Please select a part to add.");
            }
        }

        private void RefreshAssociatedPartsGrid()
        {
            AssociatedParts.DataSource = null;
            AssociatedParts.DataSource = associatedParts;
        }

        private Part GetSelectedPart()
        {
            if (PartsDataGrid.SelectedRows.Count > 0)
            {
                return (Part)PartsDataGrid.SelectedRows[0].DataBoundItem;
            }
            return null;
        }


        private Part GetSelectedAssociatedPart()
        {
            if (AssociatedParts.SelectedRows.Count > 0)
            {
                return (Part)AssociatedParts.SelectedRows[0].DataBoundItem;
            }
            return null;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Part selectedPart = GetSelectedAssociatedPart();
            if (selectedPart != null)
            {
                associatedParts.Remove(selectedPart);
                RefreshAssociatedPartsGrid();
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }
        }

        private void ValidateInput()
        {
            SaveBtn.Enabled = allowSave();

            if (string.IsNullOrWhiteSpace(Nametxt.Text) || !int.TryParse(Instocktxt.Text, out int _) || !decimal.TryParse(Pricetxt.Text, out decimal _) ||
            !int.TryParse(Mintxt.Text, out int _) || !int.TryParse(Maxtxt.Text, out int _))
            {
                SetBackgroundColor(Color.LightSalmon);
            }
            else
            {
                SetBackgroundColor(Color.White);
            }
        }

        private void SetBackgroundColor(Color color)
        {
            Nametxt.BackColor = string.IsNullOrWhiteSpace(Nametxt.Text) ? Color.LightSalmon : Color.White;
            Instocktxt.BackColor = !int.TryParse(Instocktxt.Text, out _) ? Color.LightSalmon : Color.White;
            Pricetxt.BackColor = !decimal.TryParse(Pricetxt.Text, out _) ? Color.LightSalmon : Color.White;
            Mintxt.BackColor = !int.TryParse(Mintxt.Text, out _) ? Color.LightSalmon : Color.White;
            Maxtxt.BackColor = !int.TryParse(Maxtxt.Text, out _) ? Color.LightSalmon : Color.White;
        }

        private void NameTxt_TextChanged(object sender, EventArgs e) => ValidateInput();
        private void InstockTxt_TextChanged(object sender, EventArgs e) => ValidateInput();
        private void PriceTxt_TextChanged(object sender, EventArgs e) => ValidateInput();
        private void MinTxt_TextChanged(object sender, EventArgs e) => ValidateInput();
        private void MaxTxt_TextChanged(object sender, EventArgs e) => ValidateInput();

        private void searchBtn_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;

            if (!string.IsNullOrEmpty(txtSource.Text))
            {
                string searchTerm = txtSource.Text.ToUpper();

                for (int i = 0; i < inventory.AllParts.Count; i++)
                {
                    if (inventory.AllParts[i].Name.ToUpper().Contains(searchTerm) ||
                        inventory.AllParts[i].PartID.ToString().Contains(searchTerm))
                    {
                        TempList.Add(inventory.AllParts[i]);
                        found = true;
                    }
                }

                if (found)
                    PartsDataGrid.DataSource = TempList;
            }

            if (!found)
            {
                MessageBox.Show("No matching parts found.");
                PartsDataGrid.DataSource = inventory.AllParts;
            }
        }
    }
}
