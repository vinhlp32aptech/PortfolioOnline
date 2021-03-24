using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.IO;

namespace DemoSession5_Form.Controllers
{
   

    [Route("demo")]
    public class DemoController : Controller
    {
        private IWebHostEnvironment webHostEnvironment;
        // Injetion, DI
        public DemoController(IWebHostEnvironment _webHostEnvironment)
        {
            webHostEnvironment = _webHostEnvironment;

        }

        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
     
        }

        [HttpPost]
        [Route("upload1")]
        public IActionResult UpLoad1(IFormFile photo)
        {
            if (photo != null && photo.Length > 0)
            {

                Debug.WriteLine("file name:" + photo.FileName);
                Debug.WriteLine("file type:" + photo.ContentType);
                Debug.WriteLine("file size:" + photo.Length);
                var fileName = System.Guid.NewGuid().ToString().Replace("-", "");
                Debug.WriteLine("filename: " + fileName);
                var ext = photo.ContentType.Split(new char[] { '/' })[1];
                Debug.WriteLine("ext;: " + ext);
                var path = Path.Combine(webHostEnvironment.WebRootPath, "images", fileName + "." + ext);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    photo.CopyTo(fileStream);
                }
            }
            return View("index");
        }



        [HttpPost]
        [Route("upload2")]
        public IActionResult UpLoad2(IFormFile[] photos)
        {
            if (photos != null && photos.Length > 0)
            {
                foreach (var photo in photos)
                {
                    Debug.WriteLine("file name:" + photo.FileName);
                    Debug.WriteLine("file type:" + photo.ContentType);
                    Debug.WriteLine("file size:" + photo.Length);
                    var fileName = System.Guid.NewGuid().ToString().Replace("-", "");
                    Debug.WriteLine("filename: " + fileName);
                    var ext = photo.ContentType.Split(new char[] { '/' })[1];
                    Debug.WriteLine("ext;: " + ext);
                    var path = Path.Combine(webHostEnvironment.WebRootPath, "images", fileName + "." + ext);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        photo.CopyTo(fileStream);
                    }
                }
            }
            return View("index");
        }
    }
}
