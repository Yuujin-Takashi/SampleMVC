using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestProject.Models;


namespace TestProject.Controllers
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

        public IActionResult UserAccess()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserAccess(User user)
        {
            string username = user.Username ;
            string firstname = user.Firstname;
            string lastname = user.Lastname; 
            string email = user.Email;
            string password = user.Password;
            string creationtime = user.CreationTime;

            return View();
        }

         public IActionResult Purchase()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Purchase(TestPurchase item)
        {
            string purchaseitem = item.PurchseItem;
            int purchasevalue = item.PurchaseValue;
            string purchasedate = item.PurchaseDate; 

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
