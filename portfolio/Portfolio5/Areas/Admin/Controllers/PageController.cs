using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio5.Areas.Admin.Services;
using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("page")]
    [Route("admin/page")]
    public class PageController : Controller
    {
        private SliderService sliderService;
        private SliderPartService sliderPartService;
        private IWebHostEnvironment webHostEnvironment;
        private ContentPageService contentPageService;
        private SessionPageService sessionPageService;
        private IconSessionPageService iconSessionPageService;
        private PhotoSessionPageService photoSessionPageService;
        private SubtitleSessionPageService subtitleSessionPageService;
        private UrlSessionPageService urlSessionPageService;

        public PageController(SliderService _sliderService,SliderPartService _sliderPartService ,IWebHostEnvironment _webHostEnvironment, ContentPageService _contentPageService, SessionPageService _sessionPageService, IconSessionPageService _iconSessionPageService,PhotoSessionPageService _photoSessionPageService,SubtitleSessionPageService _subtitleSessionPageService,UrlSessionPageService _urlSessionPageService)
        {
            sliderService = _sliderService;
            sliderPartService = _sliderPartService;
            webHostEnvironment = _webHostEnvironment;
            contentPageService = _contentPageService;
            sessionPageService = _sessionPageService;
            iconSessionPageService = _iconSessionPageService;
            photoSessionPageService = _photoSessionPageService;
            subtitleSessionPageService = _subtitleSessionPageService;
            urlSessionPageService = _urlSessionPageService;
        }

        [Route("slider")]
        public IActionResult Index()
        {
            ViewBag.sliders = sliderService.FindAllSlider();
            ViewBag.sliderParts = sliderPartService.FindAllSliderPart();
            return View("slider");
        }
        [Route("contentpage")]
        public IActionResult ContentPage()
        {
            ViewBag.contentPages = contentPageService.FindAllContentPage();
            return View("ContentPage");
        }
        [Route("sessionpage")]
        public IActionResult SessionPage()
        {
            ViewBag.sessionPages = sessionPageService.FindAllSessionPage();
            ViewBag.iconSessionPages = iconSessionPageService.FindAllIconSessionPage();
            ViewBag.photoSessionPages = photoSessionPageService.FindAllPhotoSessionPage();
            ViewBag.subtitleSessionPages = subtitleSessionPageService.FindAllSubtitleSessionPage();
            ViewBag.urlSessionPages = urlSessionPageService.FindAllUrlSessionPage();

            return View("SessionPage");
        }
      
        [HttpPost]
        [Route("addslider")]
        public IActionResult AddSlider(Slider slider)
        {

            slider.Datecreated = DateTime.Now;
            slider.Dateupdated = DateTime.Now;
            sliderService.CreateSlider(slider);
            return RedirectToAction("slider");
        }
        [HttpGet]
        [Route("update/{id}")]
        public IActionResult UpdateSlider(string id)
        {

            return View("slider", sliderService.FindByIdSlider(id));
        }
        
        [HttpPost]
        [Route("update/{id}")]
        public IActionResult UpdateSlider(Slider slider)
        {
            var currentSlider = sliderService.FindByIdSlider(slider.IdSlider);
            currentSlider.IdSlider = slider.IdSlider;
            currentSlider.Dateupdated = DateTime.Now;
            sliderService.UpdateSlider(currentSlider);
            return RedirectToAction("slider");
        }
        [Route("delete/{id}")]
        public IActionResult DeleteSlider(string id)
        {
            sliderService.DeleteSlider(id);
            return RedirectToAction("slider");
        }
        //<------------------------slider Part --------->
   
        [HttpPost]
        [Route("addsliderPart")]
        public IActionResult AddSliderPart(SliderPart sliderPart,IFormFile file) 
        {
            if (file != null)
            {
                string fileName = Guid.NewGuid().ToString();
                var ext = file.ContentType.Split(new char[] { '/' })[1];
                var path = Path.Combine(webHostEnvironment.WebRootPath, "images", fileName + "." + ext);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                sliderPart.Photo = fileName + "." + ext;

            }
            else
            {
                sliderPart.Photo = "avatar.png";
            }
            sliderPart.Datecreated = DateTime.Now;
            sliderPart.Dateupdated = DateTime.Now;
            sliderPartService.CreateSliderPart(sliderPart);
            return RedirectToAction("slider");
        }
        [HttpGet]
        [Route("UpdateSliderPart/{id}")]
        public IActionResult UpdateSliderPart(string id)
        {

            return View("UpdateSliderPart", sliderPartService.FindByIdSliderPart(id));
        }
        [Route("UpdateSliderPart/{id}")]
        [HttpPost]
        public IActionResult UpdateSliderPart(SliderPart sliderPart, IFormFile file)
        {
            var currentSliderPart = sliderPartService.FindByIdSliderPart(sliderPart.IdSliderPart);
            currentSliderPart.IdSliderPart = currentSliderPart.IdSliderPart;
            if (file != null)
            {
                string fileName = Guid.NewGuid().ToString();
                var ext = file.ContentType.Split(new char[] { '/' })[1];
                var path = Path.Combine(webHostEnvironment.WebRootPath, "images", fileName + "." + ext);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                currentSliderPart.Photo = fileName + "." + ext;

            }
            else
            {
                currentSliderPart.Photo = "";
            }
            currentSliderPart.IdSlider = currentSliderPart.IdSlider;
            currentSliderPart.ContentPart = sliderPart.ContentPart;
            currentSliderPart.NameUrl = sliderPart.NameUrl;
            currentSliderPart.TitlePart = sliderPart.TitlePart;
            currentSliderPart.UrlSlider = sliderPart.UrlSlider;
            
            currentSliderPart.Dateupdated = DateTime.Now;
            sliderPartService.UpdateSliderPart(currentSliderPart);
            return RedirectToAction("slider");
        }
        [Route("deletePart/{id}")]
        public IActionResult DeleteSliderPart(string id)
        {
            sliderPartService.DeleteSliderPart(id);
            return RedirectToAction("slider");
        }

        //------------------content page -----------------
        [HttpPost]
        [Route("addcontentpage")]
        public IActionResult AddContentPage(ContentPage contentPage)
        {
            contentPage.Datecreated = DateTime.Now;
            contentPage.Dateupdated = DateTime.Now;
            contentPageService.CreateContentPage(contentPage);
            return RedirectToAction("ContentPage");
        }
        [HttpGet]
        [Route("UpdateContentPage/{id}")]
        public IActionResult UpdateContentPage(string id)
        {

            return View("UpdateContentPage", contentPageService.FindByIdContentPage(id));
        }

        [HttpPost]
        [Route("UpdateContentPage/{id}")]
        public IActionResult UpdateContentPage(ContentPage contentPage)
        {
            var currentContentPage = contentPageService.FindByIdContentPage(contentPage.IdContentPage);

            currentContentPage.IdContentPage = contentPage.IdContentPage;
            currentContentPage.NamePage = contentPage.NamePage;
            currentContentPage.Dateupdated = DateTime.Now;
            contentPageService.UpdateContentPage(currentContentPage);
            return RedirectToAction("ContentPage");
        }
        [Route("DeleteContentPage/{id}")]
        public IActionResult DeleteContentPage(string id)
        {
            contentPageService.DeleteContentPage(id);
            return RedirectToAction("ContentPage");
        }
        //<----------------------session page---------->
        [HttpPost]
        [Route("addsessionpage")]
        public IActionResult AddSessionPage(SessionPage sessionPage)
        {

            sessionPage.Datecreated = DateTime.Now;
            sessionPage.Dateupdated = DateTime.Now;
            sessionPageService.CreateSessionPage(sessionPage);
            return RedirectToAction("SessionPage");
        }
        [HttpGet]
        [Route("updatesessionpage/{id}")]
        public IActionResult UpdateSessionPage(string id)
        {

            return View("UpdateSessionPage", sessionPageService.FindByIdSessionPage(id));
        }

        [HttpPost]
        [Route("updatesessionpage/{id}")]
        public IActionResult UpdateSessionPage(SessionPage sessionPage)
        {
            var currentSessionPage = sessionPageService.FindByIdSessionPage(sessionPage.IdSess);
        
            currentSessionPage.IdContentPage = sessionPage.IdContentPage;
            currentSessionPage.NameSess = sessionPage.NameSess;
            currentSessionPage.TitleSess = sessionPage.TitleSess;
            currentSessionPage.ContentSess = sessionPage.ContentSess;
            currentSessionPage.Dateupdated = DateTime.Now;
            sessionPageService.UpdateSessionPage(currentSessionPage);
            return RedirectToAction("SessionPage");
        }
        [Route("deletesessionpage/{id}")]
        public IActionResult DeleteSessionPage(string id)
        {
            sessionPageService.DeleteSessionPage(id);
            return RedirectToAction("SessionPage");
        }
        //<----------------------Icon session page---------->
        [HttpPost]
        [Route("addiconsessionpage")]
        public IActionResult AddIconSessionPage(IconSessionPage iconSessionPage, IFormFile file)
        {
            if (file != null)
            {
                string fileName = Guid.NewGuid().ToString();
                var ext = file.ContentType.Split(new char[] { '/' })[1];
                var path = Path.Combine(webHostEnvironment.WebRootPath, "images", fileName + "." + ext);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                iconSessionPage.IconSess = fileName + "." + ext;

            }
            else
            {
                iconSessionPage.IconSess = "";
            }
            iconSessionPage.Datecreated = DateTime.Now;
            iconSessionPage.Dateupdated = DateTime.Now;
            iconSessionPageService.CreateIconSessionPage(iconSessionPage);
            return RedirectToAction("SessionPage");
        }
        [HttpGet]
        [Route("updateiconsessionpage/{id}")]
        public IActionResult UpdateIconSessionPage(string id)
        {

            return View("UpdateIconSessionPage", iconSessionPageService.FindByIdIconSessionPage(id));
        }

        [HttpPost]
        [Route("updateiconsessionpage/{id}")]
        public IActionResult UpdateIconSessionPage(IconSessionPage iconSessionPage, IFormFile file)
        {
            var currenticonSessionPage = iconSessionPageService.FindByIdIconSessionPage(iconSessionPage.IdIconSess);

           
            currenticonSessionPage.IdSess = iconSessionPage.IdSess;
            if (file != null)
            {
                string fileName = Guid.NewGuid().ToString();
                var ext = file.ContentType.Split(new char[] { '/' })[1];
                var path = Path.Combine(webHostEnvironment.WebRootPath, "images", fileName + "." + ext);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                currenticonSessionPage.IconSess = fileName + "." + ext;

            }
            else
            {
                currenticonSessionPage.IconSess = "";
            }
               
            currenticonSessionPage.Dateupdated = DateTime.Now;
            iconSessionPageService.UpdateIconSessionPage(currenticonSessionPage);
            return RedirectToAction("SessionPage");
        }
        [Route("deleteiconsessionpage/{id}")]
        public IActionResult DeleteIconSessionPage(string id)
        {
            iconSessionPageService.DeleteIconSessionPage(id);
            return RedirectToAction("SessionPage");
        }
        //<----------------------PhoTo session page---------->
        [HttpPost]
        [Route("addphotosessionpage")]
        public IActionResult AddPhotoSessionPage(PhotoSessionPage photoSessionPage, IFormFile file)
        {
            if (file != null)
            {
                string fileName = Guid.NewGuid().ToString();
                var ext = file.ContentType.Split(new char[] { '/' })[1];
                var path = Path.Combine(webHostEnvironment.WebRootPath, "images", fileName + "." + ext);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                photoSessionPage.PhotoSess = fileName + "." + ext;

            }
            else
            {
                photoSessionPage.PhotoSess = "";
            }
            photoSessionPage.Datecreated = DateTime.Now;
            photoSessionPage.Dateupdated = DateTime.Now;
            photoSessionPageService.CreatePhotoSessionPage(photoSessionPage);
            return RedirectToAction("SessionPage");
        }
        [HttpGet]
        [Route("updatephotosessionpage/{id}")]
        public IActionResult UpdatePhotoSessionPage(string id)
        {

            return View("UpdatePhotoSessionPage", photoSessionPageService.FindByIdPhotoSessionPage(id));
        }

        [HttpPost]
        [Route("updatephotosessionpage/{id}")]
        public IActionResult UpdatePhotoSessionPage(PhotoSessionPage photoSessionPage, IFormFile file)
        {
            var currentphotoSessionPage = photoSessionPageService.FindByIdPhotoSessionPage(photoSessionPage.IdPhotoSess);
          
            currentphotoSessionPage.IdSess = photoSessionPage.IdSess;
            if (file != null)
            {
                string fileName = Guid.NewGuid().ToString();
                var ext = file.ContentType.Split(new char[] { '/' })[1];
                var path = Path.Combine(webHostEnvironment.WebRootPath, "images", fileName + "." + ext);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
                currentphotoSessionPage.PhotoSess = fileName + "." + ext;

            }
            else
            {
                currentphotoSessionPage.PhotoSess = "";
            }
            currentphotoSessionPage.PhotoSess = photoSessionPage.PhotoSess;
            currentphotoSessionPage.Dateupdated = DateTime.Now;
            photoSessionPageService.UpdatePhotoSessionPage(currentphotoSessionPage);
            return RedirectToAction("SessionPage");
        }
        [Route("deletephotosessionpage/{id}")]
        public IActionResult DeletePhotoSessionPage(string id)
        {
            photoSessionPageService.DeletePhotoSessionPage(id);
            return RedirectToAction("SessionPage");
        }
        //<----------------------Subtitle session page---------->
        [HttpPost]
        [Route("addsubtitlesessionpage")]
        public IActionResult AddSubtitleSessionPage(SubtitleSessionPage subtitleSessionPage)
        {

            subtitleSessionPage.Datecreated = DateTime.Now;
            subtitleSessionPage.Dateupdated = DateTime.Now;
            subtitleSessionPageService.CreateSubtitleSessionPage(subtitleSessionPage);
            return RedirectToAction("SessionPage");
        }
        [HttpGet]
        [Route("updatesubtitlesessionpage/{id}")]
        public IActionResult UpdateSubtitleSessionPage(string id)
        {

            return View("UpdateSubtitleSessionPage", subtitleSessionPageService.FindByIdSubtitleSessionPage(id));
        }

        [HttpPost]
        [Route("updatesubtitlesessionpage/{id}")]
        public IActionResult UpdateSubtitleSessionPage(SubtitleSessionPage subtitleSessionPage)
        {
            var currentsubtitleSessionPage = subtitleSessionPageService.FindByIdSubtitleSessionPage(subtitleSessionPage.IdSubtitleSess);
          
            currentsubtitleSessionPage.IdSess = subtitleSessionPage.IdSess;
            currentsubtitleSessionPage.SubtitleSess = subtitleSessionPage.SubtitleSess;
            currentsubtitleSessionPage.ContentSubtitle = subtitleSessionPage.ContentSubtitle; 
            currentsubtitleSessionPage.Dateupdated = DateTime.Now;
            subtitleSessionPageService.UpdateSubtitleSessionPage(currentsubtitleSessionPage);
            return RedirectToAction("SessionPage");
        }
        [Route("deletesubtitlesessionpage/{id}")]
        public IActionResult DeleteSubtitleSessionPage(string id)
        {
            subtitleSessionPageService.DeleteSubtitleSessionPage(id);
            return RedirectToAction("SessionPage");
        }
        //<----------------------Url session page---------->
        [HttpPost]
        [Route("addurlsessionpage")]
        public IActionResult AddUrlSessionPage(UrlSessionPage urlSessionPage)
        {

            urlSessionPage.Datecreated = DateTime.Now;
            urlSessionPage.Dateupdated = DateTime.Now;
            urlSessionPageService.CreateUrlSessionPage(urlSessionPage);
            return RedirectToAction("SessionPage");
        }
        [HttpGet]
        [Route("updateurlsessionpage/{id}")]
        public IActionResult UpdateUrlSessionPage(string id)
        {

            return View("UpdateUrlSessionPage", urlSessionPageService.FindByIdUrlSessionPage(id));
        }

        [HttpPost]
        [Route("updateurlsessionpage/{id}")]
        public IActionResult UpdateUrlSessionPage(UrlSessionPage urlSessionPage)
        {
            var currenturlSessionPage = urlSessionPageService.FindByIdUrlSessionPage(urlSessionPage.IdUrlSess);
          
            currenturlSessionPage.IdSess = urlSessionPage.IdSess;
            currenturlSessionPage.UrlSess = urlSessionPage.UrlSess;
            currenturlSessionPage.Dateupdated = DateTime.Now;
            urlSessionPageService.UpdateUrlSessionPage(currenturlSessionPage);
            return RedirectToAction("SessionPage");
        }
        [Route("deleteurlsessionpage/{id}")]
        public IActionResult DeleteUrlSessionPage(string id)
        {
            urlSessionPageService.DeleteUrlSessionPage(id);
            return RedirectToAction("SessionPage");
        }
    }
}
