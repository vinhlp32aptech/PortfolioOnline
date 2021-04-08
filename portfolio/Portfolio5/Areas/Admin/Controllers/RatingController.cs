using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Portfolio5.Areas.Admin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("rating")]
    [Route("admin/rating")]
    public class RatingController : Controller
    {
        private RatingService ratingService;
        private IWebHostEnvironment webHostEnvironment;

        public RatingController(RatingService _ratingService, IWebHostEnvironment _webHostEnvironment)
        {
            ratingService = _ratingService;
            this.webHostEnvironment = _webHostEnvironment;
        }
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.ratings = ratingService.FindAll();
            return View("~/Areas/Admin/Views/Rating/Index.cshtml");
        }
    }
}
