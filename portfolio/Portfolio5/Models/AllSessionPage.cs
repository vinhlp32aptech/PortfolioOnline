using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Models
{
    public class AllSessionPage
    {
        public SessionPage SessionPage { get; set; }
        public IconSessionPage IconSessionPage { get; set; }
        public PhotoSessionPage PhotoSessionPage { get; set; }
        public SubtitleSessionPage SubtitleSessionPage { get; set; }
        public UrlSessionPage UrlSessionPage { get; set; }
    }
}
