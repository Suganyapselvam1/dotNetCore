using dotNetCoreWebApp_MVC_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetCoreWebApp_MVC_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult RazorPage()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View("RazorPage");
            //return View("../../TempView/RazorViewEmpty");
            //return View("TempView/RazorViewEmpty.cshtml");
           // return View("../../TempView/RazorPageEmpty");
            //return View("TempView/RazorPageEmpty.cshtml");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
