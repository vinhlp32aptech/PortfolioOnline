using DemoSession5_Form.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DemoSession5_Form.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("login")]
        public IActionResult Login()
        {
            return View("login");
        }
      
    
        [HttpPost]
        [Route("login")]
        public IActionResult Login(string username, string password)
        {
            Debug.WriteLine("username: " + username);
            Debug.WriteLine("password: " + password);
            if (username.Equals("a") && password.Equals("a"))
            {
                ViewBag.username = username;
                return View("welcome");
            }
            else
            {
                ViewBag.msg = "Invalid";
                return View("login");
            }
           
        }

        [Route("logout")]
        public IActionResult Logout()
        {
            return RedirectToAction("login" , "account");
        }

        [HttpPost]
        [Route("search1")]
        public IActionResult Search1(string keyword)
        {
            ViewBag.keyword = keyword;
            Debug.WriteLine("gia tri :" + keyword);
            return View("index");
        }

        [HttpGet]
        [Route("search2")]
        public IActionResult Search2([FromQuery(Name = "keyword2")]string keyword2)
        {
            ViewBag.keyword = keyword2;
            Debug.WriteLine("gia tri 2:" + keyword2);
            return View("index");
        }

        [HttpPost]
        [Route("search3")]
        public IActionResult Search3(int min, int max)
        {

            Debug.WriteLine("gia tri min:" + min);
            Debug.WriteLine("gia tri max:" + max);
            return View("index");
        }


        [HttpGet]
        [Route("search4")]
        public IActionResult Search4([FromQuery(Name = "min")]int min, [FromQuery(Name = "max")] int max)
        {

            Debug.WriteLine("gia tri min:" + min);
            Debug.WriteLine("gia tri max:" + max);
            ViewBag.min = min;
            ViewBag.max = max;

            return View("index");
        }

        [HttpGet]
        [Route("register")]
        public IActionResult Register()
        {
            var account = new Account()
            {
                Id = 123,
                Username = "acc1",
                Description = "abc",
                Status = true,
                Gender = "male",
                Role = "r2",
                Address = new Address
                {
                    Street = "asdf",
                    Ward = "asdf",
                    District = "as"
                }
            };
            return View("Register", account);
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(Account account)
        {
            Debug.WriteLine("Id: " + account.Id);
            Debug.WriteLine("username: " + account.Username);
            Debug.WriteLine("password: " + account.Password);
            Debug.WriteLine("des: " + account.Description);
            Debug.WriteLine("status: " + account.Status);
            Debug.WriteLine("gender: " + account.Gender);
            Debug.WriteLine("Street: " + account.Address.Street);
            Debug.WriteLine("Ward: " + account.Address.Ward);
            Debug.WriteLine("District: " + account.Address.District);
            string hash = BCrypt.Net.BCrypt.HashString(account.Password);
            Debug.WriteLine("hash: " + hash);
            return View("success");
        }
    }
}
