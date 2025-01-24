using C968FormsAppv3.DataGridView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace C968FormsAppv3
{
    public partial class Inventory : Form


    {
        private static object updatedProduct;

        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();

        public static Part CurrentPart { get; set; }


        public static int CurrentPartIndex { get; set; }

        public static Part selectedPart { get; set; }

        public static int selectedPartIndex { get; set; }

        public static Part findPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }


        public static void swap(Part part)
        {

            AllParts[CurrentPartIndex] = part;
        }

        public static void swap(Product product)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == product.ProductID)
                {
                    Products[i] = product;
                    break;
                }
            }

        }





        public Inventory()
        {
            InitializeComponent();
            selectedPartIndex = -1;
            // Set the PartsDataGrid
            PartsDataGrid.DataSource = AllParts;
            // Set the ProductsDataGrid
            ProductsDataGrid.DataSource = Products;
            // DGV formatting Parts
            PartsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PartsDataGrid.ReadOnly = true;
            PartsDataGrid.MultiSelect = false;
            PartsDataGrid.RowHeadersVisible = false;
            PartsDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            PartsDataGrid.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            PartsDataGrid.AllowUserToAddRows = false;

            // DGV formatting Products
            ProductsDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsDataGrid.ReadOnly = true;
            ProductsDataGrid.MultiSelect = false;
            ProductsDataGrid.RowHeadersVisible = false;
            ProductsDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            ProductsDataGrid.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            ProductsDataGrid.AllowUserToAddRows = false;
        }



        private void updatePart_Click(object sender, EventArgs e)
        {
            if (PartsDataGrid.SelectedRows.Count > 0)
            {
                int selectedRowIndex = PartsDataGrid.SelectedRows[0].Index;
                CurrentPart = AllParts[selectedRowIndex];
                CurrentPartIndex = selectedRowIndex;

                ModifyPart modifyPartForm = new ModifyPart();
                modifyPartForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a part to modify.");
            }
        }





        private void addPart_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.ShowDialog();

        }

        private void deletePart_Click_1(object sender, EventArgs e)
        {

            if (PartsDataGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = PartsDataGrid.SelectedRows[0].Index;
                Part partToRemove = (Part)PartsDataGrid.Rows[selectedIndex].DataBoundItem;

                DialogResult confirm = MessageBox.Show($"Are you sure you want to delete {partToRemove.Name}?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    AllParts.RemoveAt(selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }
        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void PartsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            selectedPartIndex = e.RowIndex;
            selectedPart = (Part)PartsDataGrid.Rows[selectedPartIndex].DataBoundItem;
            CurrentPart = findPart(selectedPart.PartID);

        }

        private void addProduct_Click(object sender, EventArgs e)
        {

            AddProduct addProductForm = new AddProduct();
            addProductForm.ShowDialog();

        }

        private void removeProduct_Click(object sender, EventArgs e)
        {

            if (ProductsDataGrid.SelectedRows.Count > 0)
            {
                int selectedIndex = ProductsDataGrid.SelectedRows[0].Index;
                Product productToRemove = (Product)ProductsDataGrid.Rows[selectedIndex].DataBoundItem;

                DialogResult confirm = MessageBox.Show($"Are you sure you want to delete {productToRemove.Name}?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    Products.RemoveAt(selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void lookupProduct_Click_1(object sender, EventArgs e)
        {
            ProductsDataGrid.ClearSelection();

            List<Product> TempList = new List<Product>();
            bool found = false;
            if (searchProductstxt.Text != "")
            {
                for (int i = 0; i < ProductsDataGrid.Rows.Count; i++)
                {
                    if (ProductsDataGrid.Rows[i].Cells[1].Value.ToString().ToLower().Contains(searchProductstxt.Text.ToLower()))
                    {
                        TempList.Add((Product)ProductsDataGrid.Rows[i].DataBoundItem);
                        found = true;
                    }
                }
                if (found)
                    ProductsDataGrid.DataSource = TempList;
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
                ProductsDataGrid.DataSource = Inventory.Products;
            }
        }

        private void lookupPart_Click_1(object sender, EventArgs e)
        {
            PartsDataGrid.ClearSelection();

            List<Part> TempList = new List<Part>();
            bool found = false;
            if (searchPartstxt.Text != "")
            {
                for (int i = 0; i < PartsDataGrid.Rows.Count; i++)
                {
                    if (PartsDataGrid.Rows[i].Cells[1].Value.ToString().ToLower().Contains(searchPartstxt.Text.ToLower()))
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
                PartsDataGrid.DataSource = Inventory.AllParts;
            }
        }

        private void updateProduct_Click_1(object sender, EventArgs e)
        {

            if (ProductsDataGrid.SelectedRows.Count > 0)
            {
                int selectedRowIndex = ProductsDataGrid.SelectedRows[0].Index;
                Product product = Products[selectedRowIndex];
                ModifyProduct modifyProductForm = new ModifyProduct(product);
                modifyProductForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a product to modify.");
            }
        }
    }
}

