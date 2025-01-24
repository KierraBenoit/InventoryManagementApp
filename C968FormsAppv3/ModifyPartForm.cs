using C968FormsAppv3.Models;
using System;
using System.Windows.Forms;




namespace C968FormsAppv3
{


    public partial class ModifyPartForm : Form
    {
        bool isInHouse;
        Inventory inventory = new Inventory();

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


        public ModifyPartForm(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
            IDtxt.Enabled = false;
            IDtxt.Text = Inventory.CurrentPart.PartID.ToString();
            Nametxt.Text = Inventory.CurrentPart.Name;
            Instocktxt.Text = Inventory.CurrentPart.InStock.ToString();
            Pricetxt.Text = Inventory.CurrentPart.Price.ToString();
            Mintxt.Text = Inventory.CurrentPart.Min.ToString();
            Maxtxt.Text = Inventory.CurrentPart.Max.ToString();
            


            if (Inventory.CurrentPart is InHousePart)
            {
                InHousePart part = (InHousePart)Inventory.CurrentPart;
                TxtSource.Text = part.MachineID.ToString();
                isInHouse = true;
                InhouseRadioBtn.Checked = true;
            }
            else
            {
                OutsourcedPart part = (OutsourcedPart)Inventory.CurrentPart;
                TxtSource.Text = part.CompanyName;
                isInHouse = false;
                OutsourcedRadioBtn.Checked = true;
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
            Part part;

            if (isInHouse)
            {
                part = new InHousePart(Convert.ToInt32(IDtxt.Text),
                                        Nametxt.Text,
                                        Convert.ToDecimal(Pricetxt.Text),
                                        Convert.ToInt32(Instocktxt.Text),
                                        Convert.ToInt32(Mintxt.Text),
                                        Convert.ToInt32(Maxtxt.Text),
                                        Convert.ToInt32(TxtSource.Text));
            }
            else
            {
                part = new OutsourcedPart(Convert.ToInt32(IDtxt.Text),
                                            Nametxt.Text,
                                            Convert.ToDecimal(Pricetxt.Text),
                                            Convert.ToInt32(Instocktxt.Text),
                                            Convert.ToInt32(Mintxt.Text),
                                            Convert.ToInt32(Maxtxt.Text),
                                            TxtSource.Text);
            }

           
            inventory.UpdatePart(part);
        

            this.Close();

         
            InventoryForm inventoryForm = new InventoryForm(inventory);
        }

        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
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
