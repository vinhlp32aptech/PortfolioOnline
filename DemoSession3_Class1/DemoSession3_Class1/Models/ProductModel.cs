using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession3_Class1.Models
{
    public class ProductModel
    {
        private List<Product> Products { get; set; }

        public ProductModel()
        {
            Products = new List<Product>
            {
                new Product
                {
                    Id = "p01",
                    Name = "bear",
                    Photo = "1.jpg",
                    Price = 4

                },
            new Product
            {
                Id = "p02",
                Name = "bee",
                Photo = "1.jpg",
                Price = 4

            },
                  new Product
                {
                    Id = "p03",
                    Name = "dog",
                    Photo = "1.jpg",
                    Price = 4

                }
            };
        }
        public List<Product> findAll()
        {
            return Products;
        }

        public Product find(string id)
        {
            return Products.SingleOrDefault(p => p.Id == id);
        }
    }

  
}
