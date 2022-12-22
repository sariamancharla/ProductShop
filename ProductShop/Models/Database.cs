using System.Collections.Generic;

namespace ProductShop.Models
{
    public class Database
    {
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, Name="Product 1", Price=(decimal)499.00 },
                new Product{ProductId=2, Name="Product Of The Month", Price=(decimal)599.00 },
                new Product{ProductId=3, Name="Product 3", Price=(decimal)599.00 },
                new Product{ProductId=4, Name="Product 4", Price=(decimal)599.00 },
                new Product{ProductId=5, Name="Product 5", Price=(decimal)599.00 },
                new Product{ProductId=6, Name="Product 6", Price=(decimal)599.00 },
                new Product{ProductId=7, Name="Product 7", Price=(decimal)599.00 },
                new Product{ProductId=8, Name="Product 8", Price=(decimal)599.00 },
                new Product{ProductId=9, Name="Product 9", Price=(decimal)599.00 }
             };
            return products;
        }

        public static Product GetProduct(string slug)
        {
            List<Product> product=Database.GetProducts();
            foreach (Product p in product)
            {
                if (p.Slug==slug)
                {
                    return p;
                }
            }
            return null;
        }
        
    }
}
