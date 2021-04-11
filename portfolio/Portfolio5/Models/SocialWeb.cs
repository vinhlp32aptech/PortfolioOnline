using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class SocialWeb
    {
        public string IdSoccialWeb { get; set; }
        public string NameSoc { get; set; }
        public string IconSoc { get; set; }
        public string UrlSoc { get; set; }
        public DateTime? Datecreated { get; set; }
        public DateTime? Dateupdated { get; set; }
    }
}
