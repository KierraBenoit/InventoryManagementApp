namespace C968FormsAppv3
{
    partial class Inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.PartsDataGrid = new System.Windows.Forms.DataGridView();
            this.ProductsDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lookupPart = new System.Windows.Forms.Button();
            this.lookupProduct = new System.Windows.Forms.Button();
            this.searchPartstxt = new System.Windows.Forms.TextBox();
            this.searchProductstxt = new System.Windows.Forms.TextBox();
            this.addPart = new System.Windows.Forms.Button();
            this.updatePart = new System.Windows.Forms.Button();
            this.deletePart = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.removeProduct = new System.Windows.Forms.Button();
            this.updateProduct = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // PartsDataGrid
            // 
            this.PartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsDataGrid.Location = new System.Drawing.Point(29, 117);
            this.PartsDataGrid.Name = "PartsDataGrid";
            this.PartsDataGrid.RowHeadersWidth = 51;
            this.PartsDataGrid.RowTemplate.Height = 24;
            this.PartsDataGrid.Size = new System.Drawing.Size(493, 270);
            this.PartsDataGrid.TabIndex = 1;
            // 
            // ProductsDataGrid
            // 
            this.ProductsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGrid.Location = new System.Drawing.Point(624, 117);
            this.ProductsDataGrid.Name = "ProductsDataGrid";
            this.ProductsDataGrid.RowHeadersWidth = 51;
            this.ProductsDataGrid.RowTemplate.Height = 24;
            this.ProductsDataGrid.Size = new System.Drawing.Size(493, 270);
            this.ProductsDataGrid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Products";
            // 
            // lookupPart
            // 
            this.lookupPart.Location = new System.Drawing.Point(247, 65);
            this.lookupPart.Name = "lookupPart";
            this.lookupPart.Size = new System.Drawing.Size(75, 23);
            this.lookupPart.TabIndex = 5;
            this.lookupPart.Text = "Search";
            this.lookupPart.UseVisualStyleBackColor = true;
            this.lookupPart.Click += new System.EventHandler(this.lookupPart_Click_1);
            // 
            // lookupProduct
            // 
            this.lookupProduct.Location = new System.Drawing.Point(842, 66);
            this.lookupProduct.Name = "lookupProduct";
            this.lookupProduct.Size = new System.Drawing.Size(75, 23);
            this.lookupProduct.TabIndex = 6;
            this.lookupProduct.Text = "Search";
            this.lookupProduct.UseVisualStyleBackColor = true;
            this.lookupProduct.Click += new System.EventHandler(this.lookupProduct_Click_1);
            // 
            // searchPartstxt
            // 
            this.searchPartstxt.Location = new System.Drawing.Point(337, 65);
            this.searchPartstxt.Name = "searchPartstxt";
            this.searchPartstxt.Size = new System.Drawing.Size(185, 22);
            this.searchPartstxt.TabIndex = 7;
            // 
            // searchProductstxt
            // 
            this.searchProductstxt.Location = new System.Drawing.Point(932, 66);
            this.searchProductstxt.Name = "searchProductstxt";
            this.searchProductstxt.Size = new System.Drawing.Size(185, 22);
            this.searchProductstxt.TabIndex = 8;
            // 
            // addPart
            // 
            this.addPart.Location = new System.Drawing.Point(285, 416);
            this.addPart.Name = "addPart";
            this.addPart.Size = new System.Drawing.Size(75, 23);
            this.addPart.TabIndex = 9;
            this.addPart.Text = "Add";
            this.addPart.UseVisualStyleBackColor = true;
            this.addPart.Click += new System.EventHandler(this.addPart_Click);
            // 
            // updatePart
            // 
            this.updatePart.Location = new System.Drawing.Point(366, 416);
            this.updatePart.Name = "updatePart";
            this.updatePart.Size = new System.Drawing.Size(75, 23);
            this.updatePart.TabIndex = 10;
            this.updatePart.Text = "Modify";
            this.updatePart.UseVisualStyleBackColor = true;
            this.updatePart.Click += new System.EventHandler(this.updatePart_Click);
            // 
            // deletePart
            // 
            this.deletePart.Location = new System.Drawing.Point(447, 416);
            this.deletePart.Name = "deletePart";
            this.deletePart.Size = new System.Drawing.Size(75, 23);
            this.deletePart.TabIndex = 11;
            this.deletePart.Text = "Delete";
            this.deletePart.UseVisualStyleBackColor = true;
            this.deletePart.Click += new System.EventHandler(this.deletePart_Click_1);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(880, 416);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(75, 23);
            this.addProduct.TabIndex = 12;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // removeProduct
            // 
            this.removeProduct.Location = new System.Drawing.Point(1042, 416);
            this.removeProduct.Name = "removeProduct";
            this.removeProduct.Size = new System.Drawing.Size(75, 23);
            this.removeProduct.TabIndex = 13;
            this.removeProduct.Text = "Delete";
            this.removeProduct.UseVisualStyleBackColor = true;
            this.removeProduct.Click += new System.EventHandler(this.removeProduct_Click);
            // 
            // updateProduct
            // 
            this.updateProduct.Location = new System.Drawing.Point(961, 416);
            this.updateProduct.Name = "updateProduct";
            this.updateProduct.Size = new System.Drawing.Size(75, 23);
            this.updateProduct.TabIndex = 14;
            this.updateProduct.Text = "Modify";
            this.updateProduct.UseVisualStyleBackColor = true;
            this.updateProduct.Click += new System.EventHandler(this.updateProduct_Click_1);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(1042, 500);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 15;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 543);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.updateProduct);
            this.Controls.Add(this.removeProduct);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.deletePart);
            this.Controls.Add(this.updatePart);
            this.Controls.Add(this.addPart);
            this.Controls.Add(this.searchProductstxt);
            this.Controls.Add(this.searchPartstxt);
            this.Controls.Add(this.lookupProduct);
            this.Controls.Add(this.lookupPart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductsDataGrid);
            this.Controls.Add(this.PartsDataGrid);
            this.Controls.Add(this.label1);
            this.Name = "Inventory";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PartsDataGrid;
        private System.Windows.Forms.DataGridView ProductsDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button lookupPart;
        private System.Windows.Forms.Button lookupProduct;
        private System.Windows.Forms.TextBox searchPartstxt;
        private System.Windows.Forms.TextBox searchProductstxt;
        private System.Windows.Forms.Button addPart;
        private System.Windows.Forms.Button updatePart;
        private System.Windows.Forms.Button deletePart;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button removeProduct;
        private System.Windows.Forms.Button updateProduct;
        private System.Windows.Forms.Button ExitBtn;
    }
}

