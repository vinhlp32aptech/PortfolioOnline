using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class SubtitleSessionPage
    {
        public string IdSubtitleSess { get; set; }
        public string IdSess { get; set; }
        public string SubtitleSess { get; set; }
        public string ContentSubtitle { get; set; }
        public DateTime? Datecreated { get; set; }
        public DateTime? Dateupdated { get; set; }

        public virtual SessionPage IdSessNavigation { get; set; }
    }
}
