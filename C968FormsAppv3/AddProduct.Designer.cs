namespace C968FormsAppv3
{
    partial class AddProduct
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Instocktxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Pricetxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Maxtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Mintxt = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.PartsDataGrid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.AssociatedParts = new System.Windows.Forms.DataGridView();
            this.addPartBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveAddProduct = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(167, 135);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(126, 22);
            this.IDtxt.TabIndex = 3;
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(167, 188);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(126, 22);
            this.Nametxt.TabIndex = 4;
            this.Nametxt.TextChanged += new System.EventHandler(this.NameTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Instock";
            // 
            // Instocktxt
            // 
            this.Instocktxt.Location = new System.Drawing.Point(167, 234);
            this.Instocktxt.Name = "Instocktxt";
            this.Instocktxt.Size = new System.Drawing.Size(126, 22);
            this.Instocktxt.TabIndex = 6;
            this.Instocktxt.TextChanged += new System.EventHandler(this.InstockTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price";
            // 
            // Pricetxt
            // 
            this.Pricetxt.Location = new System.Drawing.Point(167, 277);
            this.Pricetxt.Name = "Pricetxt";
            this.Pricetxt.Size = new System.Drawing.Size(126, 22);
            this.Pricetxt.TabIndex = 8;
            this.Pricetxt.TextChanged += new System.EventHandler(this.PriceTxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Max";
            // 
            // Maxtxt
            // 
            this.Maxtxt.Location = new System.Drawing.Point(123, 320);
            this.Maxtxt.Name = "Maxtxt";
            this.Maxtxt.Size = new System.Drawing.Size(90, 22);
            this.Maxtxt.TabIndex = 10;
            this.Maxtxt.TextChanged += new System.EventHandler(this.MaxTxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Min";
            // 
            // Mintxt
            // 
            this.Mintxt.Location = new System.Drawing.Point(285, 320);
            this.Mintxt.Name = "Mintxt";
            this.Mintxt.Size = new System.Drawing.Size(90, 22);
            this.Mintxt.TabIndex = 12;
            this.Mintxt.TextChanged += new System.EventHandler(this.MinTxt_TextChanged);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(643, 47);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 13;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(736, 47);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 22);
            this.txtSearch.TabIndex = 14;
            // 
            // PartsDataGrid
            // 
            this.PartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsDataGrid.Location = new System.Drawing.Point(479, 94);
            this.PartsDataGrid.Name = "PartsDataGrid";
            this.PartsDataGrid.RowHeadersWidth = 51;
            this.PartsDataGrid.RowTemplate.Height = 24;
            this.PartsDataGrid.Size = new System.Drawing.Size(482, 171);
            this.PartsDataGrid.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "All candidate Parts";
            // 
            // AssociatedParts
            // 
            this.AssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssociatedParts.Location = new System.Drawing.Point(479, 326);
            this.AssociatedParts.Name = "AssociatedParts";
            this.AssociatedParts.RowHeadersWidth = 51;
            this.AssociatedParts.RowTemplate.Height = 24;
            this.AssociatedParts.Size = new System.Drawing.Size(482, 171);
            this.AssociatedParts.TabIndex = 17;
            // 
            // addPartBtn
            // 
            this.addPartBtn.Location = new System.Drawing.Point(886, 280);
            this.addPartBtn.Name = "addPartBtn";
            this.addPartBtn.Size = new System.Drawing.Size(75, 23);
            this.addPartBtn.TabIndex = 18;
            this.addPartBtn.Text = "Add";
            this.addPartBtn.UseVisualStyleBackColor = true;
            this.addPartBtn.Click += new System.EventHandler(this.addPartBtn_Click);

            this.SaveAddProduct.Click += new System.EventHandler(this.SaveAddProduct_Click);
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            this.addPartBtn.Click += new System.EventHandler(this.addPartBtn_Click);
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);

            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(886, 523);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 19;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(886, 562);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 20;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveAddProduct
            // 
            this.SaveAddProduct.Location = new System.Drawing.Point(805, 562);
            this.SaveAddProduct.Name = "SaveAddProduct";
            this.SaveAddProduct.Size = new System.Drawing.Size(75, 23);
            this.SaveAddProduct.TabIndex = 21;
            this.SaveAddProduct.Text = "Save";
            this.SaveAddProduct.UseVisualStyleBackColor = true;
            this.SaveAddProduct.Click += new System.EventHandler(this.SaveAddProduct_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(476, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Parts associated with this Product";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 608);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SaveAddProduct);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.addPartBtn);
            this.Controls.Add(this.AssociatedParts);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PartsDataGrid);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.Mintxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Maxtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Pricetxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Instocktxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Instocktxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Pricetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Maxtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Mintxt;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView PartsDataGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView AssociatedParts;
        private System.Windows.Forms.Button addPartBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveAddProduct;
        private System.Windows.Forms.Label label9;
    }
}