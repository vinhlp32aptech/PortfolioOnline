using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession3_Class1.Controllers
{
    [Route("news")]
    public class NewsController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
