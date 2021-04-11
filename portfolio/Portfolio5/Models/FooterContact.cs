using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class FooterContact
    {
        public string IdWebContact { get; set; }
        public string NameContact { get; set; }
        public string IconContact { get; set; }
        public string ContentContact { get; set; }
        public DateTime? Datecreated { get; set; }
        public DateTime? Dateupdated { get; set; }
    }
}
