using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio5.Models;
using Portfolio5.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Controllers
{
   
    [Route("profie")]
    public class ProfieController : Controller
    {
        private ProfieService profieService;
        private IWebHostEnvironment webHostEnvironment;

        public ProfieController(ProfieService _profieService, IWebHostEnvironment _webHostEnvironment)
        {
            profieService = _profieService;
            webHostEnvironment = _webHostEnvironment;
        }
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            //if (HttpContext.Session.GetString("idacc") != null)
            //{

            //    var userinfo = profieService.GetAllUserInfo("idacc");

            //    Debug.WriteLine("idacc : " + HttpContext.Session.GetString("idacc"));
            //    ViewBag.acc = userinfo.Account;
            //    ViewBag.user = userinfo.User;
            //    ViewBag.rating = userinfo.Rating;
            //    ViewBag.social = userinfo.SocialUser;

            //}

            //return View();
            string cookieIdacc = Request.Cookies["Idacc"];

            ViewBag.alluseracc = profieService.GetAllUserInfo(cookieIdacc);

            AllUserAcc aaa = profieService.GetAllUserInfo(cookieIdacc);

                Debug.WriteLine("Email" + aaa.Account.Email);
            
            return View();
        }
        [Route("edit")]

        [HttpPost]
        public IActionResult Edit(Account account, IFormFile file , User user)
        {
            string cookieIdacc = Request.Cookies["Idacc"];
            var currentAccount = profieService.FindAcc(cookieIdacc);
            var currentUser = profieService.FindUser(cookieIdacc);
            //if (!string.IsNullOrEmpty(account.Pass))
            //{
            //    currentAccount.Pass = BCrypt.Net.BCrypt.HashString(account.Pass);
            //}
            //if (file != null)
            //{
            //    string fileName = Guid.NewGuid().ToString();
            //    var ext = file.ContentType.Split(new char[] { '/' })[1];
            //    var path = Path.Combine(webHostEnvironment.WebRootPath, "images", fileName + "." + ext);
            //    using (var fileStream = new FileStream(path, FileMode.Create))
            //    {
            //        file.CopyTo(fileStream);
            //    }
            //    currentUser.Avatar = fileName + "." + ext;

            //}
            if (file != null)
            {
                string fileName = Guid.NewGuid().ToString();
                var ext = file.ContentType.Split(new char[] { '/' })[1];
                var path = Path.Combine(webHostEnvironment.WebRootPath, "images", fileName + "." + ext);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                currentUser.Avatar = fileName + "." + ext;

            }
            else
            {
                currentUser.Avatar = "";
            }
            currentUser.FirstName = user.FirstName;
            currentUser.LastName = user.LastName;
            currentUser.Website = user.Website;
            currentUser.Addr = user.Addr;
            currentUser.PhoneNumber = user.PhoneNumber;
            profieService.Update(currentUser);

            currentAccount.Email = account.Email;
            currentAccount.Username = account.Username;
            currentAccount.Pass = account.Pass;

            profieService.Update(currentUser);
            profieService.Update(currentAccount);


            return RedirectToAction("index");
        }
    }
}
