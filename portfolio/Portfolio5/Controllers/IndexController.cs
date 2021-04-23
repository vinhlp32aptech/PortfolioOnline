using DocumentFormat.OpenXml.InkML;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio5.Services;
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
        private IndexService indexService;
        private IWebHostEnvironment webHostEnvironment;

        public IndexController(IndexService indexService, IWebHostEnvironment webHostEnvironment)
        {
            this.indexService = indexService;
            this.webHostEnvironment = webHostEnvironment;
        }

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

            ViewBag.sliderBanners = indexService.GetSliderHome();

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
