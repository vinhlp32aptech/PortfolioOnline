using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioOnline.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("footer")]
    [Route("admin/footer")]

    public class FooterController : Controller
    {
 
            [Route("index")]
            [Route("")]
            public IActionResult Index()
            {
                return View();
            }
        
    }
}
