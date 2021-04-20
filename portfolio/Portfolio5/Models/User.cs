using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class User
    {
     

        public string IdUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Avatar { get; set; }
        public DateTime? Dob { get; set; }
        public string PhoneNumber { get; set; }
        public string Addr { get; set; }
        public string Website { get; set; }
        public string Job { get; set; }
        public short? Project { get; set; }
        public DateTime? Datecreated { get; set; }
        public DateTime? Dateupdated { get; set; }
        public string IdAcc { get; set; }

        public virtual Account IdAccNavigation { get; set; }

        

    }
}
