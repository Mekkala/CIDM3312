using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Midterm2.Models;

usign MathLibrary;

namespace Midterm2.Controllers
{
    public class MathController : Controller
    {
         [HttpGet]
        public IActionResult DoCaclucation()
        {
           MathOperation model = new MathOperation();
           ViewData["Message"] = "";
            return View(model);
        }

        [HttpPost]
        public IActionResult ShowCalculationResults(MathOperation model)
        {
            return View(model);
        }

        
    }
}
