using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using C968FormsAppv3.Models;






namespace C968FormsAppv3
{
    public partial class InventoryForm : Form
    {
        private static int idxSelectedPart;
        private Inventory inventory;



        public InventoryForm(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
            idxSelectedPart = -1;
            // Set the Parts DataGridView properties
            PartsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PartsDataGrid.ReadOnly = true;
            PartsDataGrid.RowHeadersVisible = false;
            PartsDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            PartsDataGrid.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            PartsDataGrid.DataSource = inventory.AllParts;
            // Set the Products DataGridView properties
            ProductsDataGrid.DataSource = inventory.Products;
            ProductsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsDataGrid.RowHeadersVisible = false;
            ProductsDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            ProductsDataGrid.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            ProductsDataGrid.ReadOnly = true;


        }




        // Add Part button click event
        private void btnAddPart_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm();

          
            if (addPartForm.ShowDialog() == DialogResult.OK)
            {
               
                Part newPart = addPartForm.CreatedPart;

               
                inventory.AddPart(newPart);

               
                PartsDataGrid.DataSource = null;
                PartsDataGrid.DataSource = inventory.AllParts;
            }
        }


        // Modify Part button click event
        private void btnModifyPart_Click(object sender, EventArgs e)
        {
            if (idxSelectedPart >= 0)
            {

                ModifyPartForm modifyPartForm = new ModifyPartForm(inventory);
                modifyPartForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Please select a part to modify.");
            }
        }


        // Search Part button click event
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;

            if (!string.IsNullOrEmpty(searchPartstxt.Text))
            {
                string searchTerm = searchPartstxt.Text.ToUpper();

        
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




        // Search Product button click event
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            BindingList<Product> TempList = new BindingList<Product>();
            bool found = false;

            if (!string.IsNullOrEmpty(searchProductstxt.Text))
            {
                string searchTerm = searchProductstxt.Text.ToUpper();

                for (int i = 0; i < inventory.Products.Count; i++)
                {
                    if (inventory.Products[i].Name.ToUpper().Contains(searchTerm) ||
                        inventory.Products[i].ProductID.ToString().Contains(searchTerm))
                    {
                        TempList.Add(inventory.Products[i]);
                        found = true;
                    }
                }

                if (found)
                    ProductsDataGrid.DataSource = TempList;
            }

            if (!found)
            {
                MessageBox.Show("No matching products found.");
                ProductsDataGrid.DataSource = inventory.Products;
            }
      
        }


        // Delete Part button click event.
        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (PartsDataGrid.SelectedRows.Count > 0)
            {
                Part selectedPart = (Part)PartsDataGrid.SelectedRows[0].DataBoundItem;

                if (inventory.Products.Any(product => product.AssociatedParts.Contains(selectedPart)))
                {
                    MessageBox.Show("This part cannot be deleted because it is associated with a product.");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        inventory.DeletePart(selectedPart.PartID);
                        PartsDataGrid.DataSource = inventory.AllParts;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }
        }


        // Delete Product button click event
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (ProductsDataGrid.SelectedRows.Count > 0)
            {
                Product selectedProduct = (Product)ProductsDataGrid.SelectedRows[0].DataBoundItem;

          
                if (selectedProduct.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("This product cannot be deleted because it is associated with a part.");
                }
                else
                {
  
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        inventory.RemoveProduct(selectedProduct.ProductID);
                        ProductsDataGrid.DataSource = inventory.Products;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        // Exit button click event
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Add Product button click event
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(inventory);
            addProductForm.ShowDialog();
          
        }

        // Modify Product button click event
        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            if (ProductsDataGrid.SelectedRows.Count > 0)
            {
                Product selectedProduct = (Product)ProductsDataGrid.SelectedRows[0].DataBoundItem;
                ModifyProductForm modifyProductForm = new ModifyProductForm(selectedProduct, inventory);
                modifyProductForm.ShowDialog();
            
            }
            else
            {
                MessageBox.Show("Please select a product to modify.");
            }
        }


        private void PartsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            idxSelectedPart = e.RowIndex;


            if (idxSelectedPart >= 0)
            {

                Part selectedPart = (Part)PartsDataGrid.Rows[idxSelectedPart].DataBoundItem;
                Inventory.CurrentPart = selectedPart;
            }

            
        }

        private void ProductsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Product selectedProduct = (Product)ProductsDataGrid.Rows[e.RowIndex].DataBoundItem;
                Inventory.CurrentProduct = selectedProduct;
            }
        }
    }
}