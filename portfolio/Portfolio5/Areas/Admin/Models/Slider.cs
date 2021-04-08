using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class Slider
    {
        public Slider()
        {
            SliderPhotos = new HashSet<SliderPhoto>();
            SliderUrls = new HashSet<SliderUrl>();
        }

        public string IdSlider { get; set; }
        public string TitleSlider { get; set; }
        public string ContentSlider { get; set; }

        public virtual ICollection<SliderPhoto> SliderPhotos { get; set; }
        public virtual ICollection<SliderUrl> SliderUrls { get; set; }
    }
}
