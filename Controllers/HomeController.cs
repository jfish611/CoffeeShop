using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoffeeShop.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;
using Unipluss.Sign.ExternalContract.Entities;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        IConfiguration ConfigRoot;
        SqlConnection connection;


        public HomeController(IConfiguration config)
        {
            ConfigRoot = config;
            connection = new SqlConnection(ConfigRoot.GetConnectionString("CoffeeShopDB"));
        }

        //public IActionResult Index()
        //{
        //    string queryString = "Select * from Product ORDER BY Category";
        //    IEnumerable<Product> p = connection.Query<Product>(queryString);
        //    var ProductList = connection.Query<Product>(queryString);

        //    ViewData["Products"] = p;
        //    return View();
        //}

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Registration(string FirstName, string LastName, string email, DateTime Birthday, string password, string passwordConfirm, string DietaryNeed)
        //{
        //    ViewData["firstName"] = FirstName;
        //    ViewData["lastName"] = LastName;
        //    ViewData["email"] = email;
        //    ViewData["dob"] = Birthday;
        //    ViewData["Diet"] = DietaryNeed;



        //    return View("Confirmation");
        //}

        [HttpPost]
        public IActionResult Registration(User u)
        {
            ViewData["firstName"] = u.FirstName;
            ViewData["lastName"] = u.LastName;
            ViewData["email"] = u.Email;
            ViewData["dob"] = u.Birthday;
            ViewData["Diet"] = u.DietaryNeed;



            return View("Confirmation", u);
        }

        //[HttpPost]
        //public IActionResult Registration(string fname, string lname)//Model will be important here. Model will get passed
        //{
        //    ViewData["firstName"] = fname;
        //    ViewData["lastName"] = lname;

        //    return View("Confirmation");
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
