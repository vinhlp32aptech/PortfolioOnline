using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using DemoSession8_Validate.Models;
using Newtonsoft.Json;

namespace DemoSession8_Validate.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("age", 20);
            HttpContext.Session.SetString("username", "abc");
            var accounts = new List<Account>
            {
                new Account
                {
                      Username = "khi",
                Password = "asdf",
                Age = 23,
                Email = "asdfdsf@df.com",
                Website = "https://thegioididong.com"
                },

                   new Account
                {
                      Username = "cho",
                Password = "asdf",
                Age = 23,
                Email = "asdfdsf@df.com",
                Website = "https://thegioididong.com"
                },
                      new Account
                {
                      Username = "meo",
                Password = "asdf",
                Age = 23,
                Email = "asdfdsf@df.com",
                Website = "https://thegioididong.com"
                }


            };
            string jsonAccount = JsonConvert.SerializeObject(accounts);
            Debug.WriteLine("json: " + jsonAccount);
            HttpContext.Session.SetString("account",jsonAccount);
            return RedirectToAction("index2");
        }

        [Route("index2")]
        public IActionResult Index2()
        {
            HttpContext.Session.Remove("age");


            if(HttpContext.Session.GetInt32("age") != null)
            {
                int age = HttpContext.Session.GetInt32("age").Value;
                Debug.WriteLine("age: " + age);
            }

            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                Debug.WriteLine("username: " + username);
            }

            if (HttpContext.Session.GetString("account") != null)
            {
                int stt = 1;
                List<Account> accounts = JsonConvert.DeserializeObject<List<Account>>(HttpContext.Session.GetString("account"));
                foreach (var account in accounts)
                {
                    
                    Debug.WriteLine("Account " + stt);
                    Debug.WriteLine("username: " + account.Username);
                    Debug.WriteLine("pass: " + account.Password);
                    Debug.WriteLine("age: " + account.Age);
                    Debug.WriteLine("==================\n" + account.Age);
                    stt++;
                }



            }

            return View("index");
        }
    }
}
