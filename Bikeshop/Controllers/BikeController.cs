using Microsoft.AspNetCore.Mvc;
using Bikeshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bikeshop.wwwroot.Data;

namespace Bikeshop.Controllers
{
    public class BikeController : Controller
    {
        BikeDbContext Context;
        public BikeController(BikeDbContext context)
        {
            Context = context;
        }
        public IActionResult Index()
        {
            Random rand = new Random();
            Bike eerste = Context.Bikes.FirstOrDefault();
            int totaal = eerste.Id;
            int Number = rand.Next(totaal, totaal + 4);
            var fiets = Context.Bikes.Where(a => a.Id == Number);
            return View(fiets.FirstOrDefault());
        }
        public IActionResult Detail(int id)
        {
            var fiets = Context.Bikes.Where(a => a.Id == id);
            return View(fiets.FirstOrDefault());
        }
        public IActionResult Carousel()
        {
            return View(Context.Bikes);
        }
    }
}
