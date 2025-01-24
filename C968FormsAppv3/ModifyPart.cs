using C968FormsAppv3.DataGridView;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace C968FormsAppv3
{


    public partial class ModifyPart : Form
    {
        bool isInHouse;
        private bool allowSave()
        {
            if (string.IsNullOrWhiteSpace(Nametxt.Text) || string.IsNullOrWhiteSpace(Instocktxt.Text) ||
                string.IsNullOrWhiteSpace(Pricetxt.Text) || string.IsNullOrWhiteSpace(Mintxt.Text) ||
                string.IsNullOrWhiteSpace(Maxtxt.Text) || string.IsNullOrWhiteSpace(TxtSource.Text))
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

            if (isInHouse && !int.TryParse(TxtSource.Text, out int number))
            {
                return false;
            }

            return true;
        }



   

        private void checkOnRBSwitch()
        {
            if (isInHouse)
            {
                if (!int.TryParse(TxtSource.Text, out int number))
                {
                    TxtSource.BackColor = System.Drawing.Color.LightSalmon;
                }
                else
                {
                    TxtSource.BackColor = System.Drawing.Color.White;
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(TxtSource.Text))
                {
        
                    TxtSource.BackColor = System.Drawing.Color.LightSalmon;
                }
                else
                {
         
                    TxtSource.BackColor = System.Drawing.Color.White;
                }
            }

            SaveBtn.Enabled = allowSave();
        }


        public ModifyPart()
        {
            InitializeComponent();
            IDtxt.Enabled = false;


            if (Inventory.CurrentPart != null)
            {
                Nametxt.Text = Inventory.CurrentPart.Name;
                Instocktxt.Text = Inventory.CurrentPart.InStock.ToString();
                Pricetxt.Text = Inventory.CurrentPart.Price.ToString();
                Mintxt.Text = Inventory.CurrentPart.Min.ToString();
                Maxtxt.Text = Inventory.CurrentPart.Max.ToString();

                if (Inventory.CurrentPart is InHousePart)
                {
                    InhouseRadioBtn.Checked = true;
                    isInHouse = true;
                    InHousePart part = (InHousePart)Inventory.CurrentPart;
                    TxtSource.Text = part.MachineID.ToString();
                }
                else
                {
                    OutsourcedRadioBtn.Checked = true;
                    isInHouse = false;
                    OutsourcedPart part = (OutsourcedPart)Inventory.CurrentPart;
                    TxtSource.Text = part.CompanyName;
                }
            }
            else
            {
                MessageBox.Show("Current part is not set.");
            }
        }

   
        private void InhouseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            LabelName.Text = "Machine ID";
            isInHouse = true;
            checkOnRBSwitch();
        }

        private void OutsourcedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            LabelName.Text = "Company Name";
            isInHouse = false;
            checkOnRBSwitch();
        }

        private void TxtSource_TextChanged(object sender, EventArgs e)
        {
            checkOnRBSwitch();
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (allowSave())
            {
                Part updatedPart;

                if (isInHouse)
                {
                    updatedPart = new InHousePart(Nametxt.Text, Convert.ToDecimal(Pricetxt.Text), Convert.ToInt32(Instocktxt.Text), Convert.ToInt32(Mintxt.Text), Convert.ToInt32(Maxtxt.Text), Convert.ToInt32(TxtSource.Text));
                }
                else
                {
                    updatedPart = new OutsourcedPart(Nametxt.Text, Convert.ToDecimal(Pricetxt.Text), Convert.ToInt32(Instocktxt.Text), Convert.ToInt32(Mintxt.Text), Convert.ToInt32(Maxtxt.Text), TxtSource.Text);
                }

                updatedPart.PartID = Inventory.CurrentPart.PartID;
                Inventory.CurrentPart = updatedPart;
                this.Hide();
                Inventory inv = new Inventory();
           
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }





        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            Close();
            Inventory mainForm = new Inventory();
        }

        private void ValidateTextBoxes()
        {
            Nametxt.BackColor = string.IsNullOrWhiteSpace(Nametxt.Text) ? System.Drawing.Color.Salmon : System.Drawing.Color.White;
            Instocktxt.BackColor = !int.TryParse(Instocktxt.Text, out int inventory) || inventory < 0 ? System.Drawing.Color.Salmon : System.Drawing.Color.White;
            Pricetxt.BackColor = !decimal.TryParse(Pricetxt.Text, out decimal price) || price < 0 ? System.Drawing.Color.Salmon : System.Drawing.Color.White;
            Mintxt.BackColor = !int.TryParse(Mintxt.Text, out int min) || min < 0 ? System.Drawing.Color.Salmon : System.Drawing.Color.White;
            Maxtxt.BackColor = !int.TryParse(Maxtxt.Text, out int max) || max < 0 ? System.Drawing.Color.Salmon : System.Drawing.Color.White;

            TxtSource.BackColor = isInHouse
                ? (!int.TryParse(TxtSource.Text, out _) ? System.Drawing.Color.Salmon : System.Drawing.Color.White)
                : (string.IsNullOrWhiteSpace(TxtSource.Text) ? System.Drawing.Color.Salmon : System.Drawing.Color.White);

            SaveBtn.Enabled = allowSave();
        }

        private void Nametxt_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void Instocktxt_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void Pricetxt_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void Mintxt_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void Maxtxt_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }


    }
}