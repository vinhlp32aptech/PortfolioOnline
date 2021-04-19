using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Portfolio5.Models;
using Portfolio5.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Controllers
{
    [Route("signin")]
    public class SigninController : Controller
    {

        private SigninService signinService;
        private IWebHostEnvironment webHostEnvironment;

        public SigninController(SigninService _signinService, IWebHostEnvironment webHostEnvironment)
        {
            this.signinService = _signinService;
            this.webHostEnvironment = webHostEnvironment;
        }

        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(string email, string pass)
        {
            var account = signinService.GetAccount(email);

            if (account != null)
            {
                if (account.Email == email && BCrypt.Net.BCrypt.Verify(pass, account.Pass))
                {
 
                    if (HttpContext.Session.GetString("idacc") == null)
                    {
                        HttpContext.Session.SetString("idacc", JsonConvert.SerializeObject(account.IdAcc));
                    }
                    return View("~/Views/Index/Index.cshtml");
                }
                else
                {
                    ViewBag.error = "Your email or password is wrong!";
                    return View("index");
                }
                return View("index");
            }
            else
            {
                ViewBag.error = "User not found!";
                return View("index");
            }

        }

    }
}
