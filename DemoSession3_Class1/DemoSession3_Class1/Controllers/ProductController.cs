using DemoSession3_Class1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession3_Class1.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        [Route("index")]
        [Route("")]
       
        public IActionResult Index()
        {
            var productmodel = new ProductModel();
            ViewBag.product = productmodel.findAll();
            return View("index");
        }

        [Route("details/{id}")]
        public IActionResult Details(string id)
        {
            var productmodel = new ProductModel();
            ViewBag.product = productmodel.find(id);
            return View("Details");

        }
    }
}
