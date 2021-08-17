using Bikeshop.Models;
using Bikeshop.wwwroot.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Bikeshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        BikeDbContext Context;

        public HomeController(ILogger<HomeController> logger, BikeDbContext context)
        {
            _logger = logger;
            Context = context;
        }
                
        public IActionResult Index()
        {
            Random rand = new Random();
            Bike eerste = Context.Bikes.FirstOrDefault();
            int EersteId = eerste.Id;
            int Number = rand.Next(EersteId, EersteId + 4);
            var fiets = Context.Bikes.Where(a => a.Id == Number);
            return View(fiets.FirstOrDefault());
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
