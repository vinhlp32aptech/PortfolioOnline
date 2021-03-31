using Portfolio.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data.Entites
{
    public class Hashtag
    {
        public string id_hashtag { get; set; }
        public string name_hashtag { get; set; }
        public Status stat { get; set; }
    }
}
