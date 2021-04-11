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
    [Route("view")]
    [Route("admin/view")]
    public class ViewController : Controller
    {
        private ViewService viewService;
        private IWebHostEnvironment webHostEnvironment;

        public ViewController(ViewService _viewService, IWebHostEnvironment _webHostEnvironment)
        {
            viewService = _viewService;
            this.webHostEnvironment = _webHostEnvironment;
        }
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.views = viewService.FindAll();
            return View("~/Areas/Admin/Views/View/Index.cshtml");


        }
    }
}
