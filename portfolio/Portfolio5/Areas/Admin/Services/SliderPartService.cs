using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public interface SliderPartService
    {
        List<SliderPart> FindAllSliderPart();
        SliderPart CreateSliderPart(SliderPart sliderPart);
        void DeleteSliderPart(string idSliderPart);
        SliderPart FindByIdSliderPart(string idSliderPart);
        SliderPart UpdateSliderPart(SliderPart sliderPart);
    }
}
