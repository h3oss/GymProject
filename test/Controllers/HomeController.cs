using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using test.Models;

namespace test.Controllers
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

        public IActionResult Akcii()
        {
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }

        public IActionResult CoopTrain()
        {
            return View();
        }

        public IActionResult News()
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
        public IActionResult Contacts()
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

        public IActionResult Admin()
        {
            return View();
        }

        private readonly string ConnectionString = "Host=localhost;Port=5432;Database=CrudDb;Username=postgres;Password=12345;Maximum Pool Size=100";

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(People people)
        {
            if (ModelState.IsValid)
            {

                IDbConnection con;

                string insertQuery = "INSERT INTO people(name, phone) VALUES(@Name, @Phone)";
                con = new NpgsqlConnection(ConnectionString);
                con.Open();
                con.Execute(insertQuery, people);
                con.Close();
                return RedirectToAction(nameof(Contacts));
            }
            return View(people);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
