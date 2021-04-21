using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Portfolio5.Models;
using Portfolio5.Services;
using Portfolio5.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Portfolio5.Controllers
{
    [Route("signup")]
    public class SignupController : Controller
    {
        private SignupService signupService;
        private IWebHostEnvironment webHostEnvironment;

        public SignupController(SignupService signupService, IWebHostEnvironment _webHostEnvironment)
        {
            this.signupService = signupService;
            this.webHostEnvironment = _webHostEnvironment;
        }

        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View();

        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(SignupViewModels signup)
        {
            if (ModelState.IsValid)
            {
                var acc = signupService.GetAccount(signup.Username.Trim());
                var account = new Account();
                if (acc == null)
                {   
                    // get idRole
                    string idRole = signupService.GetIdRoleByNameRol(signup.Role);
                    var numAlpha = new Regex("(?<Alpha>[a-zA-Z]*)(?<Numeric>[0-9]*)");
                    int num = 0;
                    if (signupService.GetNewestId(signup.Role) != null)
                    {
                        // get newest id account
                        var match = numAlpha.Match(signupService.GetNewestId(signup.Role));
                        //var alpha = match.Groups["Alpha"].Value;
                        num = Int32.Parse(match.Groups["Numeric"].Value);

                    }
                    account.Username = "Anonymous";
                    account.Email = signup.Username;
                    account.Datecreated = DateTime.Now;
                    account.Dateupdated = DateTime.Now;
                    account.Pass = BCrypt.Net.BCrypt.HashString(signup.Password);
                    account.Stat = false;

                    if (signupService.CountIdById(signup.Role) != 0)
                    {
                        account.IdAcc = signup.Role + (num + 1);
                        string idAcc = signupService.CreateAccount(account).IdAcc;
                        var user = new User();
                        user.IdUser = idAcc;
                        user.IdAcc = idAcc;
                        user.Datecreated = DateTime.Now;
                        user.Dateupdated = DateTime.Now;

                        var userRole = new UserRole();
                        userRole.IdAcc = idAcc;
                        userRole.IdRole = idRole;
                        userRole.Datecreated = DateTime.Now;
                        userRole.Dateupdated = DateTime.Now;

                        signupService.CreateUser(user);
                        signupService.CreateUserRole(userRole);

                    }
                    else
                    {
                        account.IdAcc = signup.Role + 1;
                        string idAcc = signupService.CreateAccount(account).IdAcc;
                        var user = new User();
                        user.IdUser = idAcc;
                        user.IdAcc = idAcc;
                        user.Datecreated = DateTime.Now;
                        user.Dateupdated = DateTime.Now;

                        var userRole = new UserRole();
                        userRole.IdAcc = idAcc;
                        userRole.IdRole = idRole;
                        userRole.Datecreated = DateTime.Now;
                        userRole.Dateupdated = DateTime.Now;

                        signupService.CreateUser(user);
                        signupService.CreateUserRole(userRole);
                    }
                    ViewData["message"] = "Account created successfully!";

                    return View("index");
                }
                else
                {
                    ViewData["message"] = "Email is already existed!";
                    return View("index");

                }

            }
            return View("index");

        }
    }
}
