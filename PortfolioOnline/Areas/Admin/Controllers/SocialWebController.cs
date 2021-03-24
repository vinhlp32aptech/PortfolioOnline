using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioOnline.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("socialweb")]
    [Route("admin/socialweb")]

    public class SocialWebController : Controller
    {
        [Route("index")]
        [Route("")]
       public IActionResult Index()
        {
            return View("");
        }
        [HttpGet]
        [Route("socialadd")]
        public IActionResult Add()
        {
            return View("SocialAdd");
        }
    }
}
