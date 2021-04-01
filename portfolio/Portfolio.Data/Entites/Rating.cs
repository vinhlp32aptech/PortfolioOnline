using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data.Entites
{
    public class Rating
    {
        public string id_rating { get; set; }
        public string id_acc { get; set; }
        public string id_reviewer { get; set; }
        public double star_of_rating { get; set; }
        public int num_of_rating { get; set; }
    }
}
