using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioOnline.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("page")]
    [Route("admin/page")]
    public class PageController : Controller
    {

        [Route("slider")]
        public IActionResult Index()
        {
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

    }
}
