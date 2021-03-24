using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession4_class1.Areas.Customer.Controllers
{
    [Area("customer")]
    [Route("customer")]
    [Route("customer/invoice")]

    public class InvoiceController : Controller
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
            return View("Index");
        }
    }
}
