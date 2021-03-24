using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession1_ASPNETCoreMVC1.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public DateTime Created { get; set; }
        public bool Status { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }


    }
}
