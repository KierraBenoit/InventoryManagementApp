using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.ComponentModel;
using C968FormsAppv3.Models;



namespace C968FormsAppv3
{
    public partial class AddProductForm : Form


    {
        private Product newProduct;
        private bool isProductSaved = false;
        private Inventory inventory;


        public AddProductForm(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
            newProduct = new Product("", 0, 0, 0, 0);
            IDtxt.Enabled = false;
            ValidateInput();
            // Set the PartsDataGrid
            PartsDataGrid.DataSource = inventory.AllParts;
            PartsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PartsDataGrid.ReadOnly = true;
            PartsDataGrid.MultiSelect = false;
            PartsDataGrid.RowHeadersVisible = false;
            PartsDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            PartsDataGrid.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

            // Set the AssociatedPartsDataGrid
            AssociatedParts.DataSource = newProduct.AssociatedParts;
            AssociatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AssociatedParts.ReadOnly = true;
            AssociatedParts.MultiSelect = false;
            AssociatedParts.RowHeadersVisible = false;
            AssociatedParts.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            AssociatedParts.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

        }


        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Inventory mainForm = new Inventory();
        }


        private void addPartBtn_Click(object sender, EventArgs e)
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
            AssociatedParts.DataSource = new BindingList<Part>(newProduct.AssociatedParts); 
        }


        private Part GetSelectedPart()
        {
            if (PartsDataGrid.SelectedRows.Count > 0)
            {
                return (Part)PartsDataGrid.SelectedRows[0].DataBoundItem;
            }
            return null;
        }

        private bool allowSave()
        {
            if (string.IsNullOrWhiteSpace(Nametxt.Text) || string.IsNullOrWhiteSpace(Instocktxt.Text) ||
                string.IsNullOrWhiteSpace(Pricetxt.Text) || string.IsNullOrWhiteSpace(Mintxt.Text) ||
                string.IsNullOrWhiteSpace(Maxtxt.Text))
            {
                return false;
            }

            if (!int.TryParse(Instocktxt.Text, out int inStock) || inStock < 0 ||
                !decimal.TryParse(Pricetxt.Text, out decimal price) || price < 0 ||
                !int.TryParse(Mintxt.Text, out int min) || min < 0 ||
                !int.TryParse(Maxtxt.Text, out int max) || max < 0)
            {
                return false;
            }

            if (min > max || inStock < min || inStock > max)
            {
                return false;
            }

            return true;

        }

        private Part GetSelectedAssociatedPart()
        {
            if (AssociatedParts.SelectedRows.Count > 0)
            {
                return (Part)AssociatedParts.SelectedRows[0].DataBoundItem;
            }
            return null;
        }

        private void NameTxt_TextChanged(object sender, EventArgs e) => ValidateInput();
        private void InstockTxt_TextChanged(object sender, EventArgs e) => ValidateInput();
        private void PriceTxt_TextChanged(object sender, EventArgs e) => ValidateInput();
        private void MinTxt_TextChanged(object sender, EventArgs e) => ValidateInput();
        private void MaxTxt_TextChanged(object sender, EventArgs e) => ValidateInput();

        private void ValidateInput()
        {
            SaveAddProduct.Enabled = allowSave();

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

        private void SaveAddProduct_Click(object sender, EventArgs e)
        {

            if (allowSave() && !isProductSaved) 
            {
                newProduct.Name = Nametxt.Text;
                newProduct.InStock = Convert.ToInt32(Instocktxt.Text);
                newProduct.Price = Convert.ToDecimal(Pricetxt.Text);
                newProduct.Min = Convert.ToInt32(Mintxt.Text);
                newProduct.Max = Convert.ToInt32(Maxtxt.Text);

                inventory.Products.Add(newProduct);
                isProductSaved = true; 
                this.Close();
            }
      
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Part selectedPart = GetSelectedAssociatedPart();
            if (selectedPart != null)
            {
                newProduct.RemoveAssociatedPart(selectedPart.PartID);
                RefreshAssociatedPartsGrid();
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            {
                PartsDataGrid.ClearSelection();

                List<Part> TempList = new List<Part>();
                bool found = false;
                if (txtSearch.Text != "")
                {
                    for (int i = 0; i < PartsDataGrid.Rows.Count; i++)
                    {
                        if (PartsDataGrid.Rows[i].Cells[1].Value.ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                        {
                            TempList.Add((Part)PartsDataGrid.Rows[i].DataBoundItem);
                            found = true;
                        }
                    }
                    if (found)
                        PartsDataGrid.DataSource = TempList;
                }
                if (!found)
                {
                    MessageBox.Show("Nothing found.");
                    PartsDataGrid.DataSource = inventory.AllParts;
                }
            }
        }

    }
}

