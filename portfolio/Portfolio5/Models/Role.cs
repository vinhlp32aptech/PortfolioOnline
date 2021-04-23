using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class Role
    {
        public Role()
        {
            Accounts = new HashSet<Account>();
        }

        public string IdRole { get; set; }
        public string NameRole { get; set; }
        public string Desc { get; set; }
        public DateTime? Datecreated { get; set; }
        public DateTime? Dateupdated { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
