using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TheRideYouRent.Models;

namespace TheRideYouRent.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static SqlConnection sqlConnection { get; set; }
        public static String connectionString { get; private set; }
        public static List<Driver> drivers { get; set; }
        public static List<Car> cars { get; set; }
        public static List<Rental> rentals { get; set; }
        public static List<Return> returns { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //connectionString = "Server=tcp:10117299.database.windows.net,1433;Initial Catalog=DB;Persist Security Info=False;User ID=adm10117299;Password=Landseen76;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            //sqlConnection = new SqlConnection(connectionString);

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Drivers()
        {

            return View();
        }

        public IActionResult Cars()
        {
            return View();
        }

        public IActionResult Rentals()
        {
            return View();
        }

        public IActionResult Returns()
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
