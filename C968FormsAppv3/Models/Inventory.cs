using System.ComponentModel;

namespace C968FormsAppv3.Models
{
    public class Inventory
    {
        public BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

        public static int CurrentPartID { get; set; } = 5;
        public static Part CurrentPart { get; set; }

        public static int CurrentProductID { get; set; } = 4;
        public static Product CurrentProduct { get; set; }

        public void AddPart(Part newPart)
        {
            AllParts.Add(newPart);
        }

  
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }


        public bool RemoveProduct(int productID)
        {
            var product = LookupProduct(productID);
            if (product != null)
            {
                Products.Remove(product);
                return true;
            }
            return false;
        }


        public Product LookupProduct(int productID)
        {
            foreach (var product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            return null;
        }


        public bool DeletePart(int partID)
        {
            var part = LookupPart(partID);
            if (part != null)
            {
                AllParts.Remove(part);
                return true;
            }
            return false;
        }

        public Part LookupPart(int partID)
        {
            foreach (var part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }


        public static int GenerateNewPartID()
        {
            return CurrentPartID++;
        }

        public static int GenerateNewProductID()
        {
            return CurrentProductID++;
        }


        public void UpdatePart(Part part)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == part.PartID)
                {
                    AllParts[i] = part; 
                    return;
                }
            }
        }

          public void UpdateProduct(Product product)
          {
                for (int i = 0; i < Products.Count; i++)
                {
                    if (Products[i].ProductID == product.ProductID)
                    {
                      Products[i] = product;
                      return;
                    }
                }
          }
    }
}
