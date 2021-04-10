using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class PhotoSessionPage
    {
        public string IdPhotoSess { get; set; }
        public string IdSess { get; set; }
        public string PhotoSess { get; set; }
        public DateTime? Datecreated { get; set; }
        public DateTime? Dateupdated { get; set; }

        public virtual SessionPage IdSessNavigation { get; set; }
    }
}
