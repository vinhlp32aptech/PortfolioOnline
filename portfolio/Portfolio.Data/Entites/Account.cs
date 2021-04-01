using Portfolio.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data.Entites
{
    public class Account
    {
       public string Id_acc { get; set; } 
       public string Username { get; set; }
        public string pass { get; set; }
        public string email { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public Status stat { get; set; }
    }
}
