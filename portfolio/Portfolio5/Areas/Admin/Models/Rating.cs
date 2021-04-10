using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class Rating
    {
        public string IdRating { get; set; }
        public string IdAcc { get; set; }
        public string IdReviewer { get; set; }
        public bool? StarOfRating { get; set; }
        public string NumOfRating { get; set; }
        public DateTime? Datecreated { get; set; }
        public DateTime? Dateupdated { get; set; }

        public virtual Account IdAccNavigation { get; set; }
    }
}
