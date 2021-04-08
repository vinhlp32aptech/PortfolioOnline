using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class SliderPhoto
    {
        public string IdSliderPhoto { get; set; }
        public string Photo { get; set; }
        public string IdSlider { get; set; }

        public virtual Slider IdSliderNavigation { get; set; }
    }
}
