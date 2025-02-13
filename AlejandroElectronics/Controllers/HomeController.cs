﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AlejandroElectronics.Models;

namespace AlejandroElectronics.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            

            return View();
        }

        public IActionResult Contact()
        {
            

            return View();
        }

        public IActionResult Welcome()
        {
            ViewData["Message"] = "Welcome to your Account";
            return View();
        }
 
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
