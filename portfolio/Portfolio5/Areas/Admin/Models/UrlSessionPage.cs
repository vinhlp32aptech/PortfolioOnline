using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class UrlSessionPage
    {
        public string IdUrlSess { get; set; }
        public string IdSess { get; set; }
        public string UrlSess { get; set; }
        public DateTime? Datecreated { get; set; }
        public DateTime? Dateupdated { get; set; }

        public virtual SessionPage IdSessNavigation { get; set; }
    }
}
