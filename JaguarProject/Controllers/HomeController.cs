using JaguarProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JaguarProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Rasp()
        {
            return View();
        }

        public IActionResult Gym()
        {
            return View();
        }

        public IActionResult CoopTrain()
        {
            return View();
        }

        public IActionResult Massage()
        {
            return View();
        }

        public IActionResult Sauna()
        {
            return View();
        }

        public IActionResult Solarium()
        {
            return View();
        }

        public IActionResult Tennis()
        {
            return View();
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
