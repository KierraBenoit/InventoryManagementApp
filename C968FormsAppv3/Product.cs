using C968FormsAppv3.DataGridView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace C968FormsAppv3
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();


        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }





        // Add the methods inside the class
        public void AddAssociatedPart(Part part)
        {
          AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partID)
        {
          Part partToRemove = LookupAssociatedPart(partID);
           if (partToRemove != null)
           {
           return AssociatedParts.Remove(partToRemove);
           }
           return false;
        }

        public Part LookupAssociatedPart(int partID)
        {
           foreach (Part part in AssociatedParts)
           {
             if (part.PartID == partID)
             {
              return part;
             }
           }
           return null;
        }

       public List<Part> GetAssociatedParts()
       {
       return new List<Part>(AssociatedParts);
       }
        
    }
}
