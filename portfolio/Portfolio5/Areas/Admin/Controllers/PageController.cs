using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Portfolio5.Areas.Admin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("page")]
    [Route("admin/page")]
    public class PageController : Controller
    {
        private SliderService sliderService;
        private IWebHostEnvironment webHostEnvironment;

        public PageController(SliderService sliderService, IWebHostEnvironment webHostEnvironment)
        {
            this.sliderService = sliderService;
            this.webHostEnvironment = webHostEnvironment;
        }

        [Route("slider")]
        public IActionResult Index()
        {
            ViewBag.slider = sliderService.FindAllSlider();       
            return View("slider");
        }

    
   
      
        
    }
}
