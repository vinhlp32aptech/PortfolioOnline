﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio0.Areas.Admin.Controllers
{
    public class ProfieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
