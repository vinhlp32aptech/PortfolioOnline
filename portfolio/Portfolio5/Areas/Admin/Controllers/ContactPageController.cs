using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("contactpage")]
    [Route("admin/contactpage")]

    public class ContactPageController : Controller
    {
     
       
            [Route("index")]
            [Route("")]
            public IActionResult Index()
            {
                return View();
            }
        
    }
}
