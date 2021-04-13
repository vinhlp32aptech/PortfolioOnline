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
            return View("index", new Rating());
        }
        [Route("add")]
        [HttpPost]
        public IActionResult Add(Rating rating)
        {

            rating.Datecreated = DateTime.Now;
            rating.Dateupdated = DateTime.Now;
            ratingService.Create(rating);

            return RedirectToAction("index");
        }

        [Route("delete/{id}")]

        public IActionResult Delete(string id)
        {
            ratingService.Delete(id);
            return RedirectToAction("index");
        }

        [Route("edit/{id}")]
        public IActionResult Edit(string id)
        {

            return View("Edit", ratingService.Find(id));
        }
        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(Rating rating)
        {
            var currentRating = ratingService.Find(rating.IdRating);
            currentRating.Dateupdated = DateTime.Now;
            currentRating.IdAcc = rating.IdAcc;
            currentRating.IdReviewer = rating.IdReviewer;
            currentRating.StarOfRating = rating.StarOfRating;
            currentRating.NumOfRating = rating.NumOfRating;

            ratingService.Update(currentRating);


            return RedirectToAction("index");
        }
    }
}
