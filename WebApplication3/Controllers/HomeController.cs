using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult CalculatorView()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Total(string value1,string value2,string toDo)
        {
            int total = 0;
            switch (toDo)
            {
                case "topla":
                    {
                        total = Convert.ToInt32(value1) + Convert.ToInt32(value2);
                        break;
                    }
                case "çıkar":
                    {
                        total = Convert.ToInt32(value1) - Convert.ToInt32(value2);
                        break;
                    }
                case "çarp":
                    {
                        total = Convert.ToInt32(value1) * Convert.ToInt32(value2);
                        break;
                    }
                case "böl":
                    {
                        total = Convert.ToInt32(value1) / Convert.ToInt32(value2);
                        break;
                    }
                default:
                    {
                        total = 0;
                        break;
                    }
            }
            return Content(Convert.ToString(total));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
