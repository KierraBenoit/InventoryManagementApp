using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968FormsAppv3.DataGridView
{
    internal class InHousePart : Part
    {
        
        public int MachineID { get; set; }

        
        public InHousePart(string name, decimal price, int inStock, int min, int max, int machineID)
            : base(name, price, inStock, min, max)
        {
            this.MachineID = machineID;
        }

       
        public InHousePart(int partID, string name, decimal price, int inStock, int min, int max, int machineID)
            : base(partID, name, price, inStock, min, max)
        {
            this.MachineID = machineID;
        }

      


    }
}
