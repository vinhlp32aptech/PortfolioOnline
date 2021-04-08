using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Portfolio5.Services;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return View("index");
        }
    }
}
