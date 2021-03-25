using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("mailcompose")]
    [Route("admin/mailcompose")]
    public class MailComposeController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View("~/Areas/Admin/Views/Mail/Compose.cshtml");
        }
    }
}
