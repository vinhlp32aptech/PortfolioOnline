using System;
using System.Collections.Generic;

#nullable disable

namespace Portfolio5.Models
{
    public partial class Slider
    {
        public Slider()
        {
            SliderParts = new HashSet<SliderPart>();
        }

        public string IdSlider { get; set; }
        public DateTime? Datecreated { get; set; }
        public DateTime? Dateupdated { get; set; }

        public virtual ICollection<SliderPart> SliderParts { get; set; }
    }
}
