﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio5.Controllers
{
    [Route("signup")]
    public class SignupController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View();

        }
    }
}
