namespace C968FormsAppv3
{
    partial class ModifyProduct
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.Instocktxt = new System.Windows.Forms.TextBox();
            this.Pricetxt = new System.Windows.Forms.TextBox();
            this.Maxtxt = new System.Windows.Forms.TextBox();
            this.Mintxt = new System.Windows.Forms.TextBox();
            this.PartsDataGrid = new System.Windows.Forms.DataGridView();
            this.AssociatedParts = new System.Windows.Forms.DataGridView();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Instock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Min";
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(144, 233);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(144, 22);
            this.Nametxt.TabIndex = 7;
            this.Nametxt.TextChanged += new System.EventHandler(this.NameTxt_TextChanged);
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(144, 189);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(144, 22);
            this.IDtxt.TabIndex = 8;
            // 
            // Instocktxt
            // 
            this.Instocktxt.Location = new System.Drawing.Point(144, 284);
            this.Instocktxt.Name = "Instocktxt";
            this.Instocktxt.Size = new System.Drawing.Size(144, 22);
            this.Instocktxt.TabIndex = 9;
            this.Instocktxt.TextChanged += new System.EventHandler(this.InstockTxt_TextChanged);
            // 
            // Pricetxt
            // 
            this.Pricetxt.Location = new System.Drawing.Point(144, 326);
            this.Pricetxt.Name = "Pricetxt";
            this.Pricetxt.Size = new System.Drawing.Size(144, 22);
            this.Pricetxt.TabIndex = 10;
            this.Pricetxt.TextChanged += new System.EventHandler(this.PriceTxt_TextChanged);
            // 
            // Maxtxt
            // 
            this.Maxtxt.Location = new System.Drawing.Point(80, 370);
            this.Maxtxt.Name = "Maxtxt";
            this.Maxtxt.Size = new System.Drawing.Size(73, 22);
            this.Maxtxt.TabIndex = 11;
            this.Maxtxt.TextChanged += new System.EventHandler(this.MaxTxt_TextChanged);
            // 
            // Mintxt
            // 
            this.Mintxt.Location = new System.Drawing.Point(236, 370);
            this.Mintxt.Name = "Mintxt";
            this.Mintxt.Size = new System.Drawing.Size(73, 22);
            this.Mintxt.TabIndex = 12;
            this.Mintxt.TextChanged += new System.EventHandler(this.MinTxt_TextChanged);
            // 
            // PartsDataGrid
            // 
            this.PartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsDataGrid.Location = new System.Drawing.Point(382, 94);
            this.PartsDataGrid.Name = "PartsDataGrid";
            this.PartsDataGrid.RowHeadersWidth = 51;
            this.PartsDataGrid.RowTemplate.Height = 24;
            this.PartsDataGrid.Size = new System.Drawing.Size(472, 174);
            this.PartsDataGrid.TabIndex = 13;
            // 
            // AssociatedParts
            // 
            this.AssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssociatedParts.Location = new System.Drawing.Point(382, 326);
            this.AssociatedParts.Name = "AssociatedParts";
            this.AssociatedParts.RowHeadersWidth = 51;
            this.AssociatedParts.RowTemplate.Height = 24;
            this.AssociatedParts.Size = new System.Drawing.Size(472, 174);
            this.AssociatedParts.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(652, 47);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(202, 22);
            this.textBox7.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "All candidate Parts";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(779, 280);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 18;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Parts Associated with this Product";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(779, 517);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 20;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(698, 546);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 21;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(779, 546);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 22;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 592);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.AssociatedParts);
            this.Controls.Add(this.PartsDataGrid);
            this.Controls.Add(this.Mintxt);
            this.Controls.Add(this.Maxtxt);
            this.Controls.Add(this.Pricetxt);
            this.Controls.Add(this.Instocktxt);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifyProduct";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.TextBox Instocktxt;
        private System.Windows.Forms.TextBox Pricetxt;
        private System.Windows.Forms.TextBox Maxtxt;
        private System.Windows.Forms.TextBox Mintxt;
        private System.Windows.Forms.DataGridView PartsDataGrid;
        private System.Windows.Forms.DataGridView AssociatedParts;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}