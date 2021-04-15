using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Services
{
    public interface SliderService
    {
        List<Slider> FindAllSlider();
        Slider CreateSlider(Slider slider);
        void DeleteSlider(string idSlider);
        Slider FindByIdSlider(string idSlider);
        Slider UpdateSlider(Slider slider);
       
    }
}
