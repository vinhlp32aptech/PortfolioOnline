using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Portfolio5.Models;
using Portfolio5.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Portfolio5.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("account")]
    [Route("admin/account")]
    public class AccountController : Controller
    {

        private AccountService AccountService;
        private IWebHostEnvironment webHostEnvironment;

        public AccountController(AccountService _accountService, IWebHostEnvironment _webHostEnvironment)
        {
            AccountService = _accountService;
            this.webHostEnvironment = _webHostEnvironment;
        }

        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.accounts = AccountService.FindAll();
            ViewBag.listRoles = AccountService.GetAllRole();
            return View("index");
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(Account account )
        {
            // get idRole
            string nameRole = Request.Form["selectRole"];
            string idRole = AccountService.GetIdRoleByNameRol(nameRole);
            var numAlpha = new Regex("(?<Alpha>[a-zA-Z]*)(?<Numeric>[0-9]*)");
            int num = 0;
            if (AccountService.GetNewestId(nameRole) != null)
            {
                // get newest id account
                var match = numAlpha.Match(AccountService.GetNewestId(nameRole));
                //var alpha = match.Groups["Alpha"].Value;
                num = Int32.Parse(match.Groups["Numeric"].Value);

            }

            account.Datecreated = DateTime.Now;
            account.Dateupdated = DateTime.Now;
            account.Pass = BCrypt.Net.BCrypt.HashString(account.Pass);
            account.Stat = false;

            if (AccountService.CountIdById(nameRole) != 0)
            {
                account.IdAcc = nameRole + (num + 1);
                string idAcc = AccountService.CreateAccount(account).IdAcc;
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

                AccountService.CreateUser(user);
                AccountService.CreateUserRole(userRole);

            }
            else
            {
                account.IdAcc = nameRole + 1;
                string idAcc = AccountService.CreateAccount(account).IdAcc;
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

                AccountService.CreateUser(user);
                AccountService.CreateUserRole(userRole);
            }

            return RedirectToAction("index");
        }

        [Route("delete/{idAcc}")]
        public IActionResult Delete(string idAcc)
        {
            AccountService.Delete(idAcc);
            return RedirectToAction("index");
        }
    }
}
