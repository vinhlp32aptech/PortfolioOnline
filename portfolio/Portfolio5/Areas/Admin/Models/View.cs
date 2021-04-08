using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class View
    {
        public string IdView { get; set; }
        public string IdAcc { get; set; }
        public string IdViewer { get; set; }
        public bool? NumOfView { get; set; }

        public virtual Account IdAccNavigation { get; set; }
    }
}
