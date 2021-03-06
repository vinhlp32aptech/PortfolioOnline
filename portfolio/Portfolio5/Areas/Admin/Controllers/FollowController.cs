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
    [Route("follow")]
    [Route("admin/follow")]
    public class FollowController : Controller
    {
        private FollowService followService;
        private IWebHostEnvironment webHostEnvironment;

        public FollowController(FollowService _followService, IWebHostEnvironment _webHostEnvironment)
        {
            followService = _followService;
            this.webHostEnvironment = _webHostEnvironment;
        }
        [Route("index")]
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.follows = followService.FindAll();
            return View("index", new Follow());
           
        }
        [Route("add")]
        [HttpPost]
        public IActionResult Add(Follow follow)
        {

            follow.Datecreated = DateTime.Now;
            follow.Dateupdated = DateTime.Now;
            followService.Create(follow);
            
            return RedirectToAction("index");
        }

        [Route("delete/{id}")]

        public IActionResult Delete(string id)
        {
            followService.Delete(id);
            return RedirectToAction("index");
        }
        [Route("edit/{id}")]
        public IActionResult Edit(string id)
        {

            return View("Edit", followService.Find(id));
        }
        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(Follow follow)
        {
            var currentFollow = followService.Find(follow.IdFollow);
            currentFollow.Dateupdated = DateTime.Now;
            currentFollow.IdAcc = follow.IdAcc;
            currentFollow.IdFollower = follow.IdFollower;
            currentFollow.NumOfFollow = follow.NumOfFollow;

            followService.Update(currentFollow);


            return RedirectToAction("index");
        }

    }
}
