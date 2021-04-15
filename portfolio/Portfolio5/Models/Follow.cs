using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class Follow
    {
        public string IdFollow { get; set; }
        public string IdAcc { get; set; }
        public string IdFollower { get; set; }
        public bool? NumOfFollow { get; set; }
        public DateTime? Datecreated { get; set; }
        public DateTime? Dateupdated { get; set; }

        public virtual Account IdAccNavigation { get; set; }
    }
}
