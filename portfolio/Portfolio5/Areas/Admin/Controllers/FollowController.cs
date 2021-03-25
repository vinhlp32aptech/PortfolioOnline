using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("follow")]
    [Route("admin/follow")]
    public class FollowController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View("~/Areas/Admin/Views/Follow/Index.cshtml");
        }
    }
}
