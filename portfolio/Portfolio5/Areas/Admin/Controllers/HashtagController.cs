using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("hashtag")]
    [Route("admin/hashtag")]
    public class HashtagController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View("~/Areas/Admin/Views/Hashtag/Index.cshtml");
        }
    }
}
