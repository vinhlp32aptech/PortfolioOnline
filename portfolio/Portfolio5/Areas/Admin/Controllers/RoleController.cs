using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Portfolio5.Areas.Admin.Services;
using Portfolio5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Portfolio5.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("role")]
    [Route("admin/role")]
    public class RoleController : Controller
    {
        private RoleService Roleservice;
        private IWebHostEnvironment webHostEnvironment;

        public RoleController(RoleService _roleservice, IWebHostEnvironment _webHostEnvironment)
        {
            Roleservice = _roleservice;
            this.webHostEnvironment = _webHostEnvironment;
        }

        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
                    
            List<Role> role = Roleservice.FindAll();
            ViewBag.roles = role;
            return View();
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(Role role)
        {
            var numAlpha = new Regex("(?<Alpha>[a-zA-Z]*)(?<Numeric>[0-9]*)");
            var match = numAlpha.Match("codename123");

            var alpha = match.Groups["Alpha"].Value;
            var num = match.Groups["Numeric"].Value;

            role.Datecreated = DateTime.Now;
            role.Dateupdated = DateTime.Now;
            if(role.NameRole == "Admin")
            {
                if (Roleservice.CountIdById("Admin") != 0)
                {
                    role.IdRole = role.NameRole + (Roleservice.CountIdById("Admin") + 1);
                    Roleservice.Create(role);
                }
                else
                {
                    role.IdRole = role.NameRole + 1;
                    Roleservice.Create(role);
                }
            }
            else if(role.NameRole == "Manager"){
                if (Roleservice.CountIdById("Manager") != 0)
                {
                    role.IdRole = role.NameRole + (Roleservice.CountIdById("Manager") + 1);
                    Roleservice.Create(role);
                }
                else
                {
                    role.IdRole = role.NameRole + 1;
                    Roleservice.Create(role);
                }
            }
            else if (role.NameRole == "User")
            {
                if (Roleservice.CountIdById("User") != 0)
                {
                    role.IdRole = role.NameRole + (Roleservice.CountIdById("User") + 1);
                    Roleservice.Create(role);
                }
                else
                {
                    role.IdRole = role.NameRole + 1;
                    Roleservice.Create(role);
                }
            }
            else if (role.NameRole == "Enterprise")
            {
                if (Roleservice.CountIdById("Enterprise") != 0)
                {
                    role.IdRole = role.NameRole + (Roleservice.CountIdById("Enterprise") + 1);
                    Roleservice.Create(role);
                }
                else
                {
                    role.IdRole = role.NameRole + 1;
                    Roleservice.Create(role);
                }
            }
                    return RedirectToAction("index");

        }

        
        [Route("delete/{idRole}")]
        public IActionResult Delete(string idRole)
        {
            Roleservice.Delete(idRole);
            return RedirectToAction("index");
        }
    }
}
