using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using viewModelFun.Models;

namespace viewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string themessage = "This is the message from the homecontroller. Whatsup, bro?";
            return View("Index", themessage);
        }
        [HttpGet("user")]
        public IActionResult Useronly()
        {
            User mike = new User()
            {
                FirstName = "Michael",
                LastName = "Douglas"
            };
            return View("User", mike);
        }
        [HttpGet("users")]
        public IActionResult Users()
        {
            User mike = new User()
            {
                FirstName = "Michael",
                LastName = "Douglas"
            };
            User emma = new User()
            {
                FirstName = "Emma",
                LastName = "Watson"
            };
            User eve = new User()
            {
                FirstName = "Evelyn",
                LastName = "Jackson"
            };
            User aiden = new User()
            {
                FirstName = "Aiden",
                LastName = "Chi"
            };
            List<User> users = new List<User>()
            {
                mike,
                emma,
                eve,
                aiden,
            };
            return View(users);
        }
        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numArray = new int[]
            {
                1,432,6546,123,86,123,86,123
            };
            return View("Numbers", numArray);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
