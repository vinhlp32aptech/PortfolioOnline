using DemoSession5_Form.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession5_Form.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private IWebHostEnvironment webHostEnvironment;
        // Injetion, DI
        public ProductController(IWebHostEnvironment _webHostEnvironment)
        {
            webHostEnvironment = _webHostEnvironment;

        }

        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            var productmodel = new ProductModel();
            ViewBag.products = productmodel.findAll();
            return View();
        }

        [HttpGet]
        [Route("searchbykeyword")]
        public IActionResult Searchbykeyword([FromQuery(Name = "name")] string name)
        {
            var productmodel = new ProductModel();
            ViewBag.products = productmodel.Search(name);
            return View("index");
        }

        [HttpGet]
        [Route("searchByPrice")]
        public IActionResult Searchbyprice([FromQuery(Name = "min")] double min, [FromQuery(Name = "max")] double max)
        {
            var productModel = new ProductModel();
            ViewBag.products = productModel.Search(min, max);
            return View("index");
        }

        [HttpPost]
        [Route("searchByDate")]
        public IActionResult SearchByDate(string from, string to)
        {
            var dateFrom = DateTime.ParseExact(from, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            var dateTo = DateTime.ParseExact(to, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            var productModel = new ProductModel();
            ViewBag.products = productModel.Search(dateFrom, dateTo);
            return View("index");
        }

        [HttpGet]
        [Route("importCSV")]
        public IActionResult ImportCSV()
        {
           
            return View("ImportCSV");
        }

        [HttpPost]
        [Route("importCSV")]
        public IActionResult ImportCSV(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
            
                    var fileName = System.Guid.NewGuid().ToString().Replace("-", "");
                   
                
                    var path = Path.Combine(webHostEnvironment.WebRootPath, "uploads", fileName + ".csv");
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                ViewBag.products = readCSV(path);
            }
            return View("Index");
        }

        private List<Product> readCSV(string fileName)
        {
            List<Product> products = null;
            string[] lines = System.IO.File.ReadAllLines(fileName);
            if (lines != null && lines.Length > 0)
            {
                products = new List<Product>();
                foreach(var line in lines)
                {
                    var result = line.Split(new char[] { ',' });
                    var product = new Product
                    {
                        Id = result[0],
                        Name = result[1],
                        Photo = result[2],
                        Price = double.Parse(result[3]),
                        Created = DateTime.ParseExact(result[4], "yyyy-MM-dd", CultureInfo.InvariantCulture)
                    };
                    products.Add(product);
                }
            }
            return products;
        }
    }
}
