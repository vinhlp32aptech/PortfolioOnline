using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession4_class1.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("product")]
    [Route("admin/product")]
    public class ProductController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("add")]
        public IActionResult Add()
        {
            return View("Add");
        }

        [Route("list")]
        public IActionResult ListProduct()
        {
            return View("List");
        }
    }
}
