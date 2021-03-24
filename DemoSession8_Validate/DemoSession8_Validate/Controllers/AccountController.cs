using DemoSession8_Validate.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession8_Validate.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            var account = new Account();
            return View("index", account);
        }

        [HttpPost]
        [Route("save")]
        public IActionResult Save(Account account)
        {
            if(account.Username != null && account.Username.Equals("abc"))
            {
                ModelState.AddModelError("username", " Username da ton tai ");
            }

            if (ModelState.IsValid)
            {
                Debug.WriteLine("username: " + account.Username);
                return View("success");
            }
            return View("index");
            
        }
    }
}
