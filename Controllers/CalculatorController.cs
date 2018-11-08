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
        public string Add(decimal left, decimal right)
        {

            MyMath cal = new MyMath();
            decimal value = cal.Add(left, right);
            return $"{left} plus {right} is {left + right}";
        }

        public string Subtract(decimal left, decimal right)
        {
            MyMath cal = new MyMath();
            decimal value = cal.Subtract(left, right);
            return $"{left} Minus {right} is {left - right}";
        }

        public string Multiply(decimal left, decimal right)
        {
            MyMath cal = new MyMath();
            decimal value = cal.Multiply(left, right);
            return $"{left} Multiply by {right} is {left * right}";
        }

        public string Divide(decimal left, decimal right)
        {
            MyMath cal = new MyMath();
            decimal value = cal.Divide(left, right);
            return $"{left} Divided by {right} is {left / right}";
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
