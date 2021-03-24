using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloweShop.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        [Route("login")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("register")]
        public IActionResult Register()
        {
            return View("");
        }

    }
}
