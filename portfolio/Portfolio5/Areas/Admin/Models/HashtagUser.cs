using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class HashtagUser
    {
        public string IdHashtag { get; set; }
        public string IdAcc { get; set; }
        public string NameHashtag { get; set; }

        public virtual Account IdAccNavigation { get; set; }
        public virtual Hashtag IdHashtagNavigation { get; set; }
    }
}
