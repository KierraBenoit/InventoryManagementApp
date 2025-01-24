namespace C968FormsAppv3
{
    partial class AddPartForm
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
            this.InHouseRadioBtn = new System.Windows.Forms.RadioButton();
            this.OutsourcedRadioBtn = new System.Windows.Forms.RadioButton();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Instocktxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Pricetxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Maxtxt = new System.Windows.Forms.TextBox();
            this.Mintxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSource = new System.Windows.Forms.TextBox();
            this.LabelSource = new System.Windows.Forms.Label();
            this.SavePartBtn = new System.Windows.Forms.Button();
            this.CancelPartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // InHouseRadioBtn
            // 
            this.InHouseRadioBtn.AutoSize = true;
            this.InHouseRadioBtn.Location = new System.Drawing.Point(152, 16);
            this.InHouseRadioBtn.Name = "InHouseRadioBtn";
            this.InHouseRadioBtn.Size = new System.Drawing.Size(78, 20);
            this.InHouseRadioBtn.TabIndex = 1;
            this.InHouseRadioBtn.TabStop = true;
            this.InHouseRadioBtn.Text = "InHouse";
            this.InHouseRadioBtn.UseVisualStyleBackColor = true;
            this.InHouseRadioBtn.CheckedChanged += new System.EventHandler(this.InHouseRadioBtn_CheckedChanged);
            // 
            // OutsourcedRadioBtn
            // 
            this.OutsourcedRadioBtn.AutoSize = true;
            this.OutsourcedRadioBtn.Location = new System.Drawing.Point(279, 16);
            this.OutsourcedRadioBtn.Name = "OutsourcedRadioBtn";
            this.OutsourcedRadioBtn.Size = new System.Drawing.Size(97, 20);
            this.OutsourcedRadioBtn.TabIndex = 2;
            this.OutsourcedRadioBtn.TabStop = true;
            this.OutsourcedRadioBtn.Text = "Outsourced";
            this.OutsourcedRadioBtn.UseVisualStyleBackColor = true;
            this.OutsourcedRadioBtn.CheckedChanged += new System.EventHandler(this.OutsourcedRadioBtn_CheckedChanged);
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(210, 95);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(126, 22);
            this.IDtxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(210, 136);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(126, 22);
            this.Nametxt.TabIndex = 5;
            this.Nametxt.TextChanged += new System.EventHandler(this.TxtSource_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // Instocktxt
            // 
            this.Instocktxt.Location = new System.Drawing.Point(210, 181);
            this.Instocktxt.Name = "Instocktxt";
            this.Instocktxt.Size = new System.Drawing.Size(126, 22);
            this.Instocktxt.TabIndex = 7;
            this.Instocktxt.TextChanged += new System.EventHandler(this.TxtSource_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Instock";
            // 
            // Pricetxt
            // 
            this.Pricetxt.Location = new System.Drawing.Point(210, 220);
            this.Pricetxt.Name = "Pricetxt";
            this.Pricetxt.Size = new System.Drawing.Size(126, 22);
            this.Pricetxt.TabIndex = 9;
            this.Pricetxt.TextChanged += new System.EventHandler(this.TxtSource_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price / Cost";
            // 
            // Maxtxt
            // 
            this.Maxtxt.Location = new System.Drawing.Point(210, 263);
            this.Maxtxt.Name = "Maxtxt";
            this.Maxtxt.Size = new System.Drawing.Size(86, 22);
            this.Maxtxt.TabIndex = 11;
            this.Maxtxt.TextChanged += new System.EventHandler(this.TxtSource_TextChanged);
            // 
            // Mintxt
            // 
            this.Mintxt.Location = new System.Drawing.Point(380, 263);
            this.Mintxt.Name = "Mintxt";
            this.Mintxt.Size = new System.Drawing.Size(86, 22);
            this.Mintxt.TabIndex = 12;
            this.Mintxt.TextChanged += new System.EventHandler(this.TxtSource_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Min";
            // 
            // TxtSource
            // 
            this.TxtSource.Location = new System.Drawing.Point(210, 309);
            this.TxtSource.Name = "TxtSource";
            this.TxtSource.Size = new System.Drawing.Size(126, 22);
            this.TxtSource.TabIndex = 15;
            this.TxtSource.TextChanged += new System.EventHandler(this.TxtSource_TextChanged);
            // 
            // LabelSource
            // 
            this.LabelSource.AutoSize = true;
            this.LabelSource.Location = new System.Drawing.Point(83, 315);
            this.LabelSource.Name = "LabelSource";
            this.LabelSource.Size = new System.Drawing.Size(74, 16);
            this.LabelSource.TabIndex = 17;
            this.LabelSource.Text = "Machine ID";
            // 
            // SavePartBtn
            // 
            this.SavePartBtn.Location = new System.Drawing.Point(310, 404);
            this.SavePartBtn.Name = "SavePartBtn";
            this.SavePartBtn.Size = new System.Drawing.Size(75, 23);
            this.SavePartBtn.TabIndex = 19;
            this.SavePartBtn.Text = "Save";
            this.SavePartBtn.UseVisualStyleBackColor = true;
            this.SavePartBtn.Click += new System.EventHandler(this.SavePartBtn_Click);
            // 
            // CancelPartBtn
            // 
            this.CancelPartBtn.Location = new System.Drawing.Point(391, 404);
            this.CancelPartBtn.Name = "CancelPartBtn";
            this.CancelPartBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelPartBtn.TabIndex = 20;
            this.CancelPartBtn.Text = "Cancel";
            this.CancelPartBtn.UseVisualStyleBackColor = true;
            this.CancelPartBtn.Click += new System.EventHandler(this.CancelPartBtn_Click);
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 462);
            this.Controls.Add(this.CancelPartBtn);
            this.Controls.Add(this.SavePartBtn);
            this.Controls.Add(this.LabelSource);
            this.Controls.Add(this.TxtSource);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Mintxt);
            this.Controls.Add(this.Maxtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pricetxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Instocktxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.OutsourcedRadioBtn);
            this.Controls.Add(this.InHouseRadioBtn);
            this.Controls.Add(this.label1);
            this.Name = "AddPartForm";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton InHouseRadioBtn;
        private System.Windows.Forms.RadioButton OutsourcedRadioBtn;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Instocktxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Pricetxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Maxtxt;
        private System.Windows.Forms.TextBox Mintxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSource;
        private System.Windows.Forms.Label LabelSource;
        private System.Windows.Forms.Button SavePartBtn;
        private System.Windows.Forms.Button CancelPartBtn;
    }
}