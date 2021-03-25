using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioOnline.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("mailinbox")]
    [Route("admin/mailinbox")]
    public class MailInboxController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View("~/Areas/Admin/Views/Mail/Inbox.cshtml");
        }
    }
}
