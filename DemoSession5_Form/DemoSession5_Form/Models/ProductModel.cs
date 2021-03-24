using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession5_Form.Models
{
    public class ProductModel
    {
        private List<Product> products;

        public ProductModel()
        {
            products = new List<Product>
            {
                new Product {Id = "p01", Name = "tivi", Photo = "1.jpg", Price = 4, Created = DateTime.Parse("10/20/2021")},
                new Product {Id = "p02", Name = "radio", Photo = "1.jpg", Price = 2, Created = DateTime.Parse("08/20/2021")},
                new Product {Id = "p03", Name = "fan", Photo = "1.jpg", Price = 3, Created = DateTime.Parse("01/20/2021")},
                new Product {Id = "p04", Name = "bike", Photo = "1.jpg", Price = 8, Created = DateTime.Parse("12/20/2021")},

            };
        }

        public List<Product> findAll()
        {
            return products;
        }

        public List<Product> Search(string keyword)
        {
            return products.Where(p => p.Name.ToLower().Contains(keyword.ToLower())).ToList();
        }


        public List<Product> Search(double min, double max)
        {
            return products.Where(p => p.Price >= min && p.Price <= max).ToList();
        }

        public List<Product> Search(DateTime start, DateTime end)
        {
            return products.Where(p => p.Created >= start && p.Created <= end).ToList();
        }
    }
}
