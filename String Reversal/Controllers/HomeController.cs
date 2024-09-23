using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using String_Reversal.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace String_Reversal.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Call ReverseString method and send the output to Result.cshtml
        [HttpPost]
        public IActionResult Index(GetString model)
        {
            if (ModelState.IsValid) 
            {
                model.ReverseString();
                return View("Result", model);
            }
            return View(model);
        }
    }
}
