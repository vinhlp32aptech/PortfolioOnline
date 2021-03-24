using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioOnline.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("rating")]
    [Route("admin/rating")]
    public class RatingController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
