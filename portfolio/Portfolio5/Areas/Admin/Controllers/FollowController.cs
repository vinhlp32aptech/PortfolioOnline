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
            return View("~/Areas/Admin/Views/Follow/Index.cshtml", new Follow());
        }
        [Route("index")]
        [HttpPost]
        public IActionResult Index(Follow follow)
        {
            followService.Create(follow);
            return View("~/Areas/Admin/Views/Follow/Index.cshtml");
        }

       
    }
}
