using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class SendMail
    {
        public string IdSendmail { get; set; }
        public string Fullname { get; set; }
        public string Mail { get; set; }
        public string Mess { get; set; }
        public DateTime? Datesend { get; set; }
        public bool? Stat { get; set; }
    }
}
