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
    [Route("view")]
    [Route("admin/view")]
    public class ViewController : Controller
    {
        private ViewService viewService;
        private IWebHostEnvironment webHostEnvironment;

        public ViewController(ViewService _viewService, IWebHostEnvironment _webHostEnvironment)
        {
            viewService = _viewService;
            this.webHostEnvironment = _webHostEnvironment;
        }
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.views = viewService.FindAll();
            return View("index", new View());

        }
        [Route("add")]
        [HttpPost]
        public IActionResult Add(View view)
        {

            view.Datecreated = DateTime.Now;
            view.Dateupdated = DateTime.Now;
            viewService.Create(view);

            return RedirectToAction("index");
        }
        [Route("delete/{id}")]

        public IActionResult Delete(string id)
        {
            viewService.Delete(id);
            return RedirectToAction("index");
        }
        [Route("edit/{id}")]
        public IActionResult Edit(string id)
        {

            return View("Edit", viewService.Find(id));
        }
        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(View view)
        {
            var currentView = viewService.Find(view.IdView);
            currentView.Dateupdated = DateTime.Now;
            currentView.IdAcc = view.IdAcc;
            currentView.IdViewer = view.IdViewer;
            currentView.NumOfView = view.NumOfView;

            viewService.Update(currentView);


            return RedirectToAction("index");
        }
    }
}
