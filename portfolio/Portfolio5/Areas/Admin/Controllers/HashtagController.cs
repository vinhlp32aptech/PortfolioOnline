using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Portfolio5.Areas.Admin.Services;
using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("hashtag")]
    [Route("admin/hashtag")]
    public class HashtagController : Controller
    {
   

        private HashtagService hashtagService;
        private IWebHostEnvironment webHostEnvironment;

        public HashtagController(HashtagService _hashtagService, IWebHostEnvironment _webHostEnvironment)
        {
            hashtagService = _hashtagService;
            this.webHostEnvironment = _webHostEnvironment;
        }

        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
           
            ViewBag.hashtags = hashtagService.FindAll();
            return View();
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(Hashtag hashtag)
        {
            var numAlpha = new Regex("(?<Alpha>[a-zA-Z]*)(?<Numeric>[0-9]*)");
            int num = 0;
            if (hashtagService.GetNewestId(hashtag.NameHashtag) != null)
            {
                var match = numAlpha.Match(hashtagService.GetNewestId(hashtag.NameHashtag));
                //var alpha = match.Groups["Alpha"].Value;
                num = Int32.Parse(match.Groups["Numeric"].Value);

            }


            hashtag.Datecreated = DateTime.Now;
            hashtag.Dateupdated = DateTime.Now;

            if (hashtagService.CountIdById(hashtag.NameHashtag) != 0)
            {
                hashtag.IdHashtag = hashtag.NameHashtag + (num + 1);
                hashtagService.Create(hashtag);
            }
            else
            {
                hashtag.IdHashtag = hashtag.NameHashtag + 1;
                hashtagService.Create(hashtag);
            }


            return RedirectToAction("index");

        }


        [Route("delete/{IdHashtag}")]
        public IActionResult Delete(string idHashtag)
        {
            hashtagService.Delete(idHashtag);
            return RedirectToAction("index");
        }

        [HttpGet]
        [Route("update/{id}")]
        public IActionResult Update(string id)
        {

            return View("update", hashtagService.FindById(id));
        }

        [HttpPost]
        [Route("update/{id}")]
        public IActionResult Update(Hashtag hashtag)
        {
            var currentHashtag = hashtagService.FindById(hashtag.IdHashtag);
            currentHashtag.Dateupdated = DateTime.Now;
            currentHashtag.NameHashtag = hashtag.NameHashtag;
            hashtagService.Update(currentHashtag);
            return RedirectToAction("index");
        }
    }
}
