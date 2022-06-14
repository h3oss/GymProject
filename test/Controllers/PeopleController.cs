using Dapper;
using test.Models;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace test.Controllers
{
    public class PeopleController : Controller
    {
        private readonly string ConnectionString = "Host=localhost;Port=5432;Database=CrudDb;Username=postgres;Password=12345;Maximum Pool Size=100";

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
          public IActionResult Create (People people){
            if (ModelState.IsValid)
            {

                IDbConnection con;
    
                string insertQuery = "INSERT INTO people(name, phone) VALUES(@Name, @Phone)";
                con = new NpgsqlConnection(ConnectionString);
                con.Open();
                con.Execute(insertQuery, people);
                con.Close();
                return RedirectToAction(nameof(Index));
            }
            return View(people);
        }

    }

}