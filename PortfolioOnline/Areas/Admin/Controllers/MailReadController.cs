using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioOnline.Areas.Admin.Controllers
{
    public class MailReadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
