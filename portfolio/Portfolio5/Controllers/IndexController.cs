using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Controllers
{
    [Route("index")]   
    public class IndexController : Controller
    {
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            // truoc khi dung session nho dung cau nay
            if (HttpContext.Session.GetString("idacc") != null)
            {
                //  HttpContext.Session.SetString("idacc", JsonConvert.SerializeObject(account.IdAcc));
                ViewBag.loggedin = true;
            }
            return View();
        }
    }
}
