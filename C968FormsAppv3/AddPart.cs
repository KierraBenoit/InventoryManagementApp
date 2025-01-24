using C968FormsAppv3.DataGridView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace C968FormsAppv3
{
    public partial class AddPart : Form
    {
        private bool isInHouse;

        public AddPart()
        {
            InitializeComponent();
            InitializeForm();
            IDtxt.Enabled = false;
        }

        private void InitializeForm()
        {
            InHouseRadioBtn.Checked = true;
            isInHouse = true;
            LabelSource.Text = "Machine ID";
            TxtSource.Text = "";
            ValidateInput();
        }

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

        private void ValidateInput()
        {
            SavePartBtn.Enabled = allowSave();

            if (string.IsNullOrWhiteSpace(Nametxt.Text) || !int.TryParse(Instocktxt.Text, out int _) || !decimal.TryParse(Pricetxt.Text, out decimal _) ||
                !int.TryParse(Mintxt.Text, out int _) || !int.TryParse(Maxtxt.Text, out int _) || (isInHouse && !int.TryParse(TxtSource.Text, out int _)))
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
            TxtSource.BackColor = isInHouse && !int.TryParse(TxtSource.Text, out _) ? Color.LightSalmon : Color.White;
        }

        private void InHouseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (InHouseRadioBtn.Checked)
            {
                isInHouse = true;
                LabelSource.Text = "Machine ID";
                TxtSource.Text = "";
                ValidateInput();
            }
        }

        private void OutsourcedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (OutsourcedRadioBtn.Checked)
            {
                isInHouse = false;
                LabelSource.Text = "Company Name";
                TxtSource.Text = "";
                ValidateInput();
            }
        }

        
        private void CancelPartBtn_Click(object sender, EventArgs e)
        {
            Close();
            Inventory mainForm = new Inventory();
        }

        private void Nametxt_TextChanged(object sender, EventArgs e) => ValidateInput();
        private void Instock_TextChanged(object sender, EventArgs e) => ValidateInput();
        private void Pricetxt_TextChanged(object sender, EventArgs e) => ValidateInput();
        private void Mintxt_TextChanged(object sender, EventArgs e) => ValidateInput();
        private void Maxtxt_TextChanged(object sender, EventArgs e) => ValidateInput();
        private void TxtSource_TextChanged(object sender, EventArgs e) => ValidateInput();

        private void SavePartBtn_Click_1(object sender, EventArgs e)
        {

            if (allowSave())
            {
                if (isInHouse)
                {
                    InHousePart part = new InHousePart(
                        Nametxt.Text,
                        Convert.ToDecimal(Pricetxt.Text),
                        Convert.ToInt32(Instocktxt.Text),
                        Convert.ToInt32(Mintxt.Text),
                        Convert.ToInt32(Maxtxt.Text),
                        Convert.ToInt32(TxtSource.Text)
                    );
                    
                    Inventory.AllParts.Add(part);
                    
                }
                else
                {
                    OutsourcedPart part = new OutsourcedPart(
                        Nametxt.Text,
                        Convert.ToDecimal(Pricetxt.Text),
                        Convert.ToInt32(Instocktxt.Text),
                        Convert.ToInt32(Mintxt.Text),
                        Convert.ToInt32(Maxtxt.Text),
                        TxtSource.Text
                    );
                    
                    Inventory.AllParts.Add(part);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }
    }
}
