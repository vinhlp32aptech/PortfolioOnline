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
            //if (socialUser.NameSoc == "Admin")
            //{
            //    if (socialUserService.CountIdById("Admin") != 0)
            //    {
            //        socialUser.IdSocialUser = socialUser.NameSoc + (socialUserService.CountIdById("Admin") + 1);
            //        socialUserService.Create(socialUser);
            //    }
            //    else
            //    {
            //        socialUser.IdSocialUser = socialUser.NameSoc + 1;
            //        socialUserService.Create(socialUser);
            //    }
            //}
            //else if (socialUser.NameSoc == "Manager")
            //{
            //    if (socialUserService.CountIdById("Manager") != 0)
            //    {
            //        socialUser.IdSocialUser = socialUser.NameSoc + (socialUserService.CountIdById("Manager") + 1);
            //        socialUserService.Create(socialUser);
            //    }
            //    else
            //    {
            //        socialUser.IdSocialUser = socialUser.NameSoc + 1;
            //        socialUserService.Create(socialUser);
            //    }
            //}
            //else if (socialUser.NameSoc == "User")
            //{
            //    if (socialUserService.CountIdById("User") != 0)
            //    {
            //        socialUser.IdSocialUser = socialUser.NameSoc + (socialUserService.CountIdById("User") + 1);
            //        socialUserService.Create(socialUser);
            //    }
            //    else
            //    {
            //        socialUser.IdSocialUser = socialUser.NameSoc + 1;
            //        socialUserService.Create(socialUser);
            //    }
            //}
            //else if (socialUser.NameSoc == "Enterprise")
            //{
            //    if (socialUserService.CountIdById("Enterprise") != 0)
            //    {
            //        socialUser.IdSocialUser = socialUser.NameSoc + (socialUserService.CountIdById("Enterprise") + 1);
            //        socialUserService.Create(socialUser);
            //    }
            //    else
            //    {
            //        socialUser.IdSocialUser = socialUser.NameSoc + 1;
            //        socialUserService.Create(socialUser);
            //    }
            //}

            return RedirectToAction("index");
        }

        [Route("delete/{id}")]

        public IActionResult Delete(string id)
        {
            socialUserService.Delete(id);
            return RedirectToAction("index");
        }
        [Route("edit/{id}")]
        public IActionResult Edit(string id)
        {

            return View("Edit", socialUserService.Find(id));
        }
        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(SocialUser socialUser)
        {
            var currentSocialUser = socialUserService.Find(socialUser.IdSocialUser);
            currentSocialUser.Dateupdated = DateTime.Now;
            currentSocialUser.NameSoc = socialUser.NameSoc;
            currentSocialUser.IconSoc = socialUser.IconSoc;
            currentSocialUser.UrlSoc = socialUser.UrlSoc;
            currentSocialUser.IdAcc = socialUser.IdAcc;

            socialUserService.Update(currentSocialUser);


            return RedirectToAction("index");
        }
    }
}
