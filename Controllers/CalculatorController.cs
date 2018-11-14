using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebCalculator.Models;


using CalculatorLibrary;

namespace MyWebCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Add(decimal left, decimal right)
        {
            
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["Add Result"] = $"{left} plus {right} is {left + right}";
            return View();
            
        }

        public IActionResult Subtract(decimal left, decimal right)
        {
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["Subtract Result"] = $"{left} Minus {right} is {left - right}";
            return View();
            
        }

        public IActionResult Multiply(decimal left, decimal right)
        {
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["Multiply Result"] = $"{left} Multiply by {right} is {left * right}";
            return View();
            
        }

        public IActionResult Divide(decimal left, decimal right)
        {
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["Divide Result"] = $"{left} Divided by {right} is {left / right}";
            return View();
           
        }

        public string Power(double x, double y)
        {
            MyMath cal = new MyMath();
            double result = Math.Pow(x, y);
            return  $"The power of {x} is {result}";
        }

        public string Ceiling(decimal number)
        {
            MyMath cal = new MyMath();
            decimal result = Math.Ceiling(number);
            return  $"The celling of {number} is {result}";
        }

        public string Floor(decimal number)
        {
            MyMath cal = new MyMath();
            decimal result = Math.Floor(number);
            return  $"The flooring of {number} is {result}";
        }    
            
    }
}
