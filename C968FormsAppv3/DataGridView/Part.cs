using C968FormsAppv3.DataGridView;
using C968FormsAppv3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968FormsAppv3.DataGridView
{
    public abstract class Part
    {

        private static int partCount = 4;

        
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }  
        public int Min { get; set; }
        public int Max { get; set; }
    

      
        public Part(string name, decimal price, int inStock, int min, int max)
        {
            this.PartID = ++partCount;  
            this.Name = name;
            this.Price = price;
            this.InStock = inStock;
            this.Min = min;
            this.Max = max;
        }

        
        public Part(int partID, string name, decimal price, int inStock, int min, int max)
        {
            this.PartID = partID;
            this.Name = name;
            this.Price = price;
            this.InStock = inStock;
            this.Min = min;
            this.Max = max;
        }


    }
}



