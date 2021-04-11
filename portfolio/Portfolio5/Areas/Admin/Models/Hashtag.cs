using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class Hashtag
    {
        public Hashtag()
        {
            HashtagUsers = new HashSet<HashtagUser>();
        }

        public string IdHashtag { get; set; }
        public string NameHashtag { get; set; }
        public bool? Stat { get; set; }
        public DateTime? Datecreated { get; set; }
        public DateTime? Dateupdated { get; set; }

        public virtual ICollection<HashtagUser> HashtagUsers { get; set; }
    }
}
