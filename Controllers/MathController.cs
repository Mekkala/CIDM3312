using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Midterm2.Models;

using MathLibrary;


namespace Midterm2.Controllers
{
    public class MathController : Controller
    {
         [HttpGet]
        public IActionResult DoCalculacation()
        {   
            return View();
        }

        [HttpPost]
        public IActionResult ShowCalculationResults(MathOperation cal)
        {
           
            cal.Result = MyMath.Add(cal.LeftOperand, cal.RightOperand);

            cal.Result = MyMath.Subtract(cal.LeftOperand, cal.RightOperand);
               
            cal.Result = MyMath.Multiply(cal.LeftOperand, cal.RightOperand);
               
            cal.Result = MyMath.Divide(cal.LeftOperand, cal.RightOperand);
            
                           
            return View(cal);
            
        }

        
    }
}
