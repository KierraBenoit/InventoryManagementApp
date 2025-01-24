using System.ComponentModel;

namespace C968FormsAppv3.Models
{
    public class Product
    {
        private static int productIDCounter = 4;
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();


        public Product(string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productIDCounter++;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }


        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

 
        public bool RemoveAssociatedPart(int partID)
        {
            var part = LookupAssociatedPart(partID);
            if (part != null)
            {
                AssociatedParts.Remove(part);
                return true;
            }
            return false;
        }


        public Part LookupAssociatedPart(int partID)
        {
            foreach (var part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }
    }

}
