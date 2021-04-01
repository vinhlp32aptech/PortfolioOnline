using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data.Entites
{
    public class Follow
    {
        public string id_follow { get; set; }
        public string id_acc { get; set; }
        public string id_follower { get; set; }
        public int num_of_follow { get; set; }
    }

}
