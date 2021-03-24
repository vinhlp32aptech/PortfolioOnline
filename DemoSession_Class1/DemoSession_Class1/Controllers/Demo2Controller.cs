using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession_Class1.Controllers
{
    [Route("demo2")]
    [Route("~/")]
    public class Demo2Controller : Controller
    {
      [Route("index")]
      [Route("")]
      
        public IActionResult Index()
        {

            return View();
        }

        [Route("index2/{id}")]
        public IActionResult Index2(int id)
        {
            Debug.WriteLine("id: " + id);
            return View("Index2");
        }

        [Route("index3/{id1}/{id2}")]
        public IActionResult Index3(int id1, string id2)
        {
            Debug.WriteLine("id1 = " + id1);
            Debug.WriteLine("id2 = " + id2);
            return View("Index3");
        }

        [Route("index4")]
        public IActionResult Index4([FromQuery(Name = "id1")] int id1, [FromQuery(Name = "id2")] string id2)
        {
            Debug.WriteLine("id1 = " + id1);
            Debug.WriteLine("id2 = " + id2);
            return View("Index4");
        }

        [Route("index5")]
        public IActionResult Index5()
        {

            return View("index5");
        }
    }
}
