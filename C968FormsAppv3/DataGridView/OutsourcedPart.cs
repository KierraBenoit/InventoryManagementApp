using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968FormsAppv3.DataGridView
{
    internal class OutsourcedPart : Part
    {
       
        public string CompanyName { get; set; }

    
        public OutsourcedPart(string name, decimal price, int inStock, int min, int max, string companyName)
            : base(name, price, inStock, min, max)
        {
            this.CompanyName = companyName;
        }

       
        public OutsourcedPart(int partID, string name, decimal price, int inStock, int min, int max, string companyName)
            : base(partID, name, price, inStock, min, max)
        {
            this.CompanyName = companyName;
        }


    }
    
    
}
