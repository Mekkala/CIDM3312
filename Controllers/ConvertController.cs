using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment6.Models;

using ConversionLibrary;

namespace Assignment6.Controllers
{
    public class ConvertController: Controller
    {
       // Temperature Conversion 
       public IActionResult CelsiusToFahrenheit(decimal tempC)
        {
            ViewData["TempIn"] = tempC;
            ViewData["Result"] = $"{tempC} is {TempConversion.CToF(tempC)}";
            return View();
        }

        public IActionResult CelsiusToKevin(decimal tempIn)
        {
            ViewData["TempIn"] = tempIn;
            ViewData["Result"] = $"{tempIn} is {TempConversion.CToK(tempIn)}";
            return View();
        }

        public IActionResult FahrenheitToCelsius(decimal tempIn)
        {
            ViewData["TempIn"] = tempIn;
            ViewData["Result"] = $"{tempIn} is {TempConversion.FToC(tempIn)}";
            return View();
        }

        public IActionResult FahrenheitToKevin(decimal tempIn)
        {
            ViewData["TempIn"] = tempIn;
            ViewData["Result"] = $"{tempIn} is {TempConversion.FToK(tempIn)}";
            return View();
        }

        public IActionResult KevinToCelsius(decimal tempIn)
        {
            ViewData["TempIn"] = tempIn;
            ViewData["Result"] = $"{tempIn} is {TempConversion.KToC(tempIn)}";
            return View();
        }

        public IActionResult KevinToFahrenheit(decimal tempIn)
        {
            ViewData["TempIn"] = tempIn;
            ViewData["Result"] = $"{tempIn} is {TempConversion.KToF(tempIn)}";
            return View();
        }

        // Length Conversion

        public IActionResult MetersToFeet(decimal lengthIn)
        {
            ViewData["Length"] = lengthIn;
            ViewData["Result"] = $"{lengthIn} is {LengthConversion.MetersToFeet(lengthIn)}";
            return View();
        }

        public IActionResult MetersToYard(decimal lengthIn)
        {
            ViewData["Length"] = lengthIn;
            ViewData["Result"] = $"{lengthIn} is {LengthConversion.MetersToYard(lengthIn)}";
            return View();
        }
        public IActionResult FeetToMeter(decimal lengthIn)
        {
            ViewData["Length"] = lengthIn;
            ViewData["Result"] = $"{lengthIn} is {LengthConversion.FeetToMeter(lengthIn)}";
            return View();
        }
        public IActionResult FeetToYard(decimal lengthIn)
        {
            ViewData["Length"] = lengthIn;
            ViewData["Result"] = $"{lengthIn} is {LengthConversion.FeetToYard(lengthIn)}";
            return View();
        }
        public IActionResult YardToMeter(decimal lengthIn)
        {
            ViewData["Length"] = lengthIn;
            ViewData["Result"] = $"{lengthIn} is {LengthConversion.YardToMeter(lengthIn)}";
            return View();
        }
        public IActionResult YardToFeet(decimal lengthIn)
        {
            ViewData["Length"] = lengthIn;
            ViewData["Result"] = $"{lengthIn} is {LengthConversion.YardToFeet(lengthIn)}";
            return View();
        }

        // Mass Conversion

        public IActionResult OunceToPound(decimal massIn)
        {
            ViewData["Mass"] = massIn;
            ViewData["Result"] = $"{massIn} is {MassConversion.OunceToPound(massIn)}";
            return View();
        }

        public IActionResult OunceToGram(decimal massIn)
        {
            ViewData["Mass"] = massIn;
            ViewData["Result"] = $"{massIn} is {MassConversion.OunceToGram(massIn)}";
            return View();
        }

        public IActionResult OunceToKilogram(decimal massIn)
        {
            ViewData["Mass"] = massIn;
            ViewData["Result"] = $"{massIn} is {MassConversion.OunceToKilogram(massIn)}";
            return View();
        }

        public IActionResult PoundToOunce(decimal massIn)
        {
            ViewData["Mass"] = massIn;
            ViewData["Result"] = $"{massIn} is {MassConversion.PoundToOunce(massIn)}";
            return View();
        }

        public IActionResult PoundToGram(decimal massIn)
        {
            ViewData["Mass"] = massIn;
            ViewData["Result"] = $"{massIn} is {MassConversion.PoundToGram(massIn)}";
            return View();
        }

        public IActionResult PoundToKilogram(decimal massIn)
        {
            ViewData["Mass"] = massIn;
            ViewData["Result"] = $"{massIn} is {MassConversion.PoundToKilogram(massIn)}";
            return View();
        }

        public IActionResult GramToOunce(decimal massIn)
        {
            ViewData["Mass"] = massIn;
            ViewData["Result"] = $"{massIn} is {MassConversion.GramToOunce(massIn)}";
            return View();
        }

        public IActionResult GramToPound(decimal massIn)
        {
            ViewData["Mass"] = massIn;
            ViewData["Result"] = $"{massIn} is {MassConversion.GramToPound(massIn)}";
            return View();
        }

        public IActionResult GramToKilogram(decimal massIn)
        {
            ViewData["Mass"] = massIn;
            ViewData["Result"] = $"{massIn} is {MassConversion.GramToKilogram(massIn)}";
            return View();
        }

        public IActionResult KilogramToOunce(decimal massIn)
        {
            ViewData["Mass"] = massIn;
            ViewData["Result"] = $"{massIn} is {MassConversion.KilogramToOunce(massIn)}";
            return View();
        }

        public IActionResult KilogramToPound(decimal massIn)
        {
            ViewData["Mass"] = massIn;
            ViewData["Result"] = $"{massIn} is {MassConversion.KilogramToPound(massIn)}";
            return View();
        }

        public IActionResult KilogramToGram(decimal massIn)
        {
            ViewData["Mass"] = massIn;
            ViewData["Result"] = $"{massIn} is {MassConversion.KilogramToGram(massIn)}";
            return View();
        }
       
    }
}