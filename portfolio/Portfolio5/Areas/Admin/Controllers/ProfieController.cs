using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("profie")]
    [Route("admin/profie")]
    public class ProfieController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View("~/Areas/Admin/Views/Profie/Index.cshtml");
        }
    }
}
