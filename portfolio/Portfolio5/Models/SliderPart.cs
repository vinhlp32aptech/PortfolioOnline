using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class SliderPart
    {
        public string IdSliderPart { get; set; }
        public string TitlePart { get; set; }
        public string ContentPart { get; set; }
        public string NameUrl { get; set; }
        public string UrlSlider { get; set; }
        public string Photo { get; set; }
        public string IdSlider { get; set; }
        public DateTime? Datecreated { get; set; }
        public DateTime? Dateupdated { get; set; }
        public virtual Slider IdSliderNavigation { get; set; }
    }
}
