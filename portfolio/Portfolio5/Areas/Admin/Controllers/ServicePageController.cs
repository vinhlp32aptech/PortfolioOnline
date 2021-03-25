using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("servicepage")]
    [Route("admin/servicepage")]

    public class ServicePageController : Controller
    {
   
            [Route("index")]
            [Route("")]
            public IActionResult Index()
            {
                return View();
            }
      
    }
}
