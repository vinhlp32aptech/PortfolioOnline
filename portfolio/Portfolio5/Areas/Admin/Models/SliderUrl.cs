using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class SliderUrl
    {
        public string IdUrlSlider { get; set; }
        public string NameUrl { get; set; }
        public string UrlSlider { get; set; }
        public string IdSlider { get; set; }

        public virtual Slider IdSliderNavigation { get; set; }
    }
}
