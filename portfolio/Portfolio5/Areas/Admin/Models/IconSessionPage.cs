using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class IconSessionPage
    {
        public string IdIconSess { get; set; }
        public string IdSess { get; set; }
        public string IconSess { get; set; }

        public virtual SessionPage IdSessNavigation { get; set; }
    }
}
