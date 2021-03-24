using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioOnline.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("aboutpage")]
    [Route("admin/aboutpage")]

    public class AboutPageController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
