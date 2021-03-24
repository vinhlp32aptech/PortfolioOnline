using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession4_class1.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
          
            return View();
        }
    }
}
