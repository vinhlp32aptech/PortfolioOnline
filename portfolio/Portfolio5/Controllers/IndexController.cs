using DocumentFormat.OpenXml.InkML;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Portfolio5.Controllers
{
    [Route("index")]   
    public class IndexController : Controller
    {
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            string email = HttpContext.User.Identity.Name;
            string cookieIdacc = Request.Cookies["Idacc"];
            if (cookieIdacc == null)
            {
                ViewBag.loggedin = false;

            }
            if (HttpContext.User.IsInRole("Personal"))
            {
                ViewBag.role = "Personal";
            }
            if (HttpContext.User.IsInRole("Enterprise"))
            {
                ViewBag.role = "Enterprise";
            }
            return View();
        }


        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(
            CookieAuthenticationDefaults.AuthenticationScheme);
            string key = "Idacc";
            string value = "";
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Append(key, value, cookieOptions);

            return RedirectToAction("index");

        }
    }
}
