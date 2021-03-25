using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data.Entites
{
    public class User
    {
		public string id_user { get; set; }
		public string first_name { get; set; }
		public string last_name { get; set; }
		public string avatar { get; set; }
		public DateTime dob { get; set; }
		public string phone_number { get; set; }
		public string addr { get; set; }
		public string website { get; set; }
		public string job { get; set; }
		public int project { get; set; }
		public string id_acc { get; set; }


	}
}
