using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Portfolio5.Models;
using Portfolio5.Services;
using Portfolio5.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
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
        public IActionResult Login(SigninViewModels signin)
        {
            bool isUserValid = false;
            bool isUserRoleValid = false;

            var account = signinService.GetAccount(signin.Username);
            var userrole = signinService.GetRole(account.IdRole);
            if (account != null && BCrypt.Net.BCrypt.Verify(signin.Password, account.Pass))
            {

                isUserValid = true;
                isUserRoleValid = true;
            }


            if (ModelState.IsValid && isUserValid && isUserRoleValid)
            {
                //if (HttpContext.Session.GetString("idacc") == null)
                //{
                //    HttpContext.Session.SetString("idacc", JsonConvert.SerializeObject(account.IdAcc));
                //}
                //return View("~/Views/Index/Index.cshtml");

                string key = "Idacc";
                string value = account.IdAcc;
                CookieOptions cookieOptions = new CookieOptions();
                cookieOptions.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Append(key, value, cookieOptions);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, account.Email),
                    new Claim(ClaimTypes.Role, userrole),


                };


                var identity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.
        AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);

                var props = new AuthenticationProperties();
                props.IsPersistent = signin.Rememberme;

                HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.
        AuthenticationScheme,
                    principal, props).Wait();

                return RedirectToAction("index", "Index", new { area = "" });
            }
            else
            {
                ViewData["message"] = "Your email or password is wrong!";
                return View("index");
            }
            return View("index");

        }


    }
}
