using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class SessionPage
    {
        public SessionPage()
        {
            IconSessionPages = new HashSet<IconSessionPage>();
            PhotoSessionPages = new HashSet<PhotoSessionPage>();
            SubtitleSessionPages = new HashSet<SubtitleSessionPage>();
            UrlSessionPages = new HashSet<UrlSessionPage>();
        }

        public string IdSess { get; set; }
        public string IdContentPage { get; set; }
        public string NameSess { get; set; }
        public string TitleSess { get; set; }
        public string ContentSess { get; set; }
        public DateTime? Datecreated { get; set; }
        public DateTime? Dateupdated { get; set; }

        public virtual ContentPage IdContentPageNavigation { get; set; }
        public virtual ICollection<IconSessionPage> IconSessionPages { get; set; }
        public virtual ICollection<PhotoSessionPage> PhotoSessionPages { get; set; }
        public virtual ICollection<SubtitleSessionPage> SubtitleSessionPages { get; set; }
        public virtual ICollection<UrlSessionPage> UrlSessionPages { get; set; }
    }
}
