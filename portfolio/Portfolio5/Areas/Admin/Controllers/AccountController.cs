using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("account")]
    [Route("admin/account")]
    public class AccountController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View("~/Areas/Admin/Views/Account/Index.cshtml");
        }
    }
}
