using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MayerP3.Models;

namespace MayerP3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Index
        public IActionResult Index()
        {
            InvestmentCalc inv = new InvestmentCalc();
            return View(inv);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        // POST: Index
        [HttpPost]
        public IActionResult Summary(InvestmentCalc inv)
        {
            if(ModelState.IsValid)
            {
                //For now just display the result of the calculation
                ViewData["info"] = $"{inv.FutureValue}";
            }
            else
            {
                ViewData["Info"] = "Inputs are invalid.";
            }
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
