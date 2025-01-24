using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using C968FormsAppv3.Models;

namespace C968FormsAppv3
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Inventory inventory = new Inventory();
            // Populate the Parts DataGrid with sample data
            inventory.AllParts.Add(new InHousePart(partID: 1, name: "Pedal", price: 10.00m, inStock: 5, min: 1, max: 10, machineID: 1));
            inventory.AllParts.Add(new InHousePart(partID: 2, name: "Handlebar", price: 20.00m, inStock: 10, min: 1, max: 20, machineID: 2));
            inventory.AllParts.Add(new OutsourcedPart(partID: 3, name: "Seat", price: 30.00m, inStock: 15, min: 1, max: 30, companyName: "Company A"));
            inventory.AllParts.Add(new OutsourcedPart(partID: 4, name: "Tire", price: 40.00m, inStock: 20, min: 1, max: 40, companyName: "Company B"));

            
            // Populate the Products list with sample data
            inventory.Products.Add(new Product(productID: 1, name: "Red Bike", price: 100.00m, inStock: 5, min: 1, max: 10));
            inventory.Products.Add(new Product(productID: 2, name: "Yellow Bike", price: 200.00m, inStock: 10, min: 1, max: 20));
            inventory.Products.Add(new Product(productID: 3, name: "Blue Bike", price: 300.00m, inStock: 15, min: 1, max: 30));

        
 
          

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InventoryForm(inventory));
        }
    }
}
