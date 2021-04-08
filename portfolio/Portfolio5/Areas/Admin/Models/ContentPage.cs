using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class ContentPage
    {
        public ContentPage()
        {
            SessionPages = new HashSet<SessionPage>();
        }

        public string IdContentPage { get; set; }
        public string NamePage { get; set; }

        public virtual ICollection<SessionPage> SessionPages { get; set; }
    }
}
