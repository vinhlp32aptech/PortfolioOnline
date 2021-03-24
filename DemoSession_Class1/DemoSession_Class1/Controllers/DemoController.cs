using DemoSession_Class1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession_Class1.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.age = 20;
            ViewBag.username = "acc1";
            ViewBag.status = true;
            ViewBag.photo = "1.jpg";
            ViewBag.price = 4.5;
            ViewBag.quantity = 20;
            var names = new List<string>
            {
                "Name1", "Name2", "Name3", "Name4"
            };
            ViewBag.names = names;
            return View();
        }

        public IActionResult Index2()
        {
            var studentModel = new StudentModel();
            ViewBag.student = studentModel.Find();
            return View("Index2");
        }

        public IActionResult Index3()
        {
            var studentModel = new StudentModel();
            ViewBag.students = studentModel.FindAll();
            return View("Index3");
        }
    }
}
