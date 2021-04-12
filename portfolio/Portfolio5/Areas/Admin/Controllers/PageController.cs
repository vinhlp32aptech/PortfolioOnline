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
        private SliderService accountService;
        private IWebHostEnvironment webHostEnvironment;
        public PageController(SliderService _sliderService, IWebHostEnvironment _webHostEnvironment)
        {
            accountService = _sliderService;
            webHostEnvironment = _webHostEnvironment;
        }
        [Route("slider")]
        public IActionResult Index()
        {
            ViewBag.slider = accountService.FindAllSlider();       
            return View("slider");
        }

        [Route("content_page")]
        public IActionResult content_page()
        {
            return View("ContentPage");
        }
        [Route("session_page")]
        public IActionResult session_page()
        {
            return View("SessionPage");
        }
   
      
        [Route("index")]
        

       
        
    }
}
