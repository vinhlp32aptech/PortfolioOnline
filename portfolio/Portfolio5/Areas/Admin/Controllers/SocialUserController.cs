using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Portfolio5.Areas.Admin.Services;
using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("socialuser")]
    public class SocialUserController : Controller
    {
        private SocialUserService socialUserService;
        private IWebHostEnvironment webHostEnvironment;

        public SocialUserController(SocialUserService _socialUserService, IWebHostEnvironment _webHostEnvironment)
        {
            socialUserService = _socialUserService;
            this.webHostEnvironment = _webHostEnvironment;
        }
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.socialUsers = socialUserService.FindAll();
            return View("index", new SocialUser());
        }
        [Route("add")]
        [HttpPost]
        public IActionResult Add(SocialUser socialUser)
        {

            socialUser.Datecreated = DateTime.Now;
            socialUser.Dateupdated = DateTime.Now;
            socialUserService.Create(socialUser);

            return RedirectToAction("index");
        }

        [Route("delete/{id}")]

        public IActionResult Delete(string id)
        {
            socialUserService.Delete(id);
            return RedirectToAction("index");
        }
    }
}
