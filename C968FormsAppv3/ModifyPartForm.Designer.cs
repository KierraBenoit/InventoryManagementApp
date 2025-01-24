namespace C968FormsAppv3
{
    partial class ModifyPartForm
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
            this.InhouseRadioBtn = new System.Windows.Forms.RadioButton();
            this.OutsourcedRadioBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Instocktxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Pricetxt = new System.Windows.Forms.TextBox();
            this.Maxtxt = new System.Windows.Forms.TextBox();
            this.Mintxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSource = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modify Part";
            // 
            // InhouseRadioBtn
            // 
            this.InhouseRadioBtn.AutoSize = true;
            this.InhouseRadioBtn.Location = new System.Drawing.Point(182, 23);
            this.InhouseRadioBtn.Name = "InhouseRadioBtn";
            this.InhouseRadioBtn.Size = new System.Drawing.Size(82, 20);
            this.InhouseRadioBtn.TabIndex = 1;
            this.InhouseRadioBtn.TabStop = true;
            this.InhouseRadioBtn.Text = "In-House";
            this.InhouseRadioBtn.UseVisualStyleBackColor = true;
            this.InhouseRadioBtn.CheckedChanged += new System.EventHandler(this.InhouseRadioBtn_CheckedChanged);
            // 
            // OutsourcedRadioBtn
            // 
            this.OutsourcedRadioBtn.AutoSize = true;
            this.OutsourcedRadioBtn.Location = new System.Drawing.Point(314, 23);
            this.OutsourcedRadioBtn.Name = "OutsourcedRadioBtn";
            this.OutsourcedRadioBtn.Size = new System.Drawing.Size(97, 20);
            this.OutsourcedRadioBtn.TabIndex = 2;
            this.OutsourcedRadioBtn.TabStop = true;
            this.OutsourcedRadioBtn.Text = "Outsourced";
            this.OutsourcedRadioBtn.UseVisualStyleBackColor = true;
            this.OutsourcedRadioBtn.CheckedChanged += new System.EventHandler(this.OutsourcedRadioBtn_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(228, 100);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(144, 22);
            this.IDtxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(228, 153);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(144, 22);
            this.Nametxt.TabIndex = 6;
            this.Nametxt.TextChanged += new System.EventHandler(this.Nametxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Instock";
            // 
            // Instocktxt
            // 
            this.Instocktxt.Location = new System.Drawing.Point(228, 199);
            this.Instocktxt.Name = "Instocktxt";
            this.Instocktxt.Size = new System.Drawing.Size(144, 22);
            this.Instocktxt.TabIndex = 8;
            this.Instocktxt.TextChanged += new System.EventHandler(this.Instocktxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price / Cost";
            // 
            // Pricetxt
            // 
            this.Pricetxt.Location = new System.Drawing.Point(228, 244);
            this.Pricetxt.Name = "Pricetxt";
            this.Pricetxt.Size = new System.Drawing.Size(144, 22);
            this.Pricetxt.TabIndex = 10;
            this.Pricetxt.TextChanged += new System.EventHandler(this.Pricetxt_TextChanged);
            // 
            // Maxtxt
            // 
            this.Maxtxt.Location = new System.Drawing.Point(228, 299);
            this.Maxtxt.Name = "Maxtxt";
            this.Maxtxt.Size = new System.Drawing.Size(89, 22);
            this.Maxtxt.TabIndex = 11;
            this.Maxtxt.TextChanged += new System.EventHandler(this.Maxtxt_TextChanged);
            // 
            // Mintxt
            // 
            this.Mintxt.Location = new System.Drawing.Point(394, 299);
            this.Mintxt.Name = "Mintxt";
            this.Mintxt.Size = new System.Drawing.Size(89, 22);
            this.Mintxt.TabIndex = 12;
            this.Mintxt.TextChanged += new System.EventHandler(this.Mintxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Min";
            // 
            // TxtSource
            // 
            this.TxtSource.Location = new System.Drawing.Point(228, 349);
            this.TxtSource.Name = "TxtSource";
            this.TxtSource.Size = new System.Drawing.Size(144, 22);
            this.TxtSource.TabIndex = 15;
            this.TxtSource.TextChanged += new System.EventHandler(this.TxtSource_TextChanged);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(101, 355);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(74, 16);
            this.LabelName.TabIndex = 17;
            this.LabelName.Text = "Machine ID";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(326, 460);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 19;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(424, 460);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 20;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click_1);
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 523);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TxtSource);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Mintxt);
            this.Controls.Add(this.Maxtxt);
            this.Controls.Add(this.Pricetxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Instocktxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutsourcedRadioBtn);
            this.Controls.Add(this.InhouseRadioBtn);
            this.Controls.Add(this.label1);
            this.Name = "ModifyPart";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton InhouseRadioBtn;
        private System.Windows.Forms.RadioButton OutsourcedRadioBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Instocktxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Pricetxt;
        private System.Windows.Forms.TextBox Maxtxt;
        private System.Windows.Forms.TextBox Mintxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSource;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}