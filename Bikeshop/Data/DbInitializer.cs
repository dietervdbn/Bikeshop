using Bikeshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bikeshop.wwwroot.Data
{
    public class DbInitializer
    {
        public static void Seed(BikeDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Bikes.Any())
            {
                return;
            }
            var fietsLijst = new List<Bike>()
            {
            new Bike {Price= decimal.Parse("150"), Name="fietsje", Pic=@"images/bike1.jpg"},
            new Bike {Price= decimal.Parse("200"), Name="fietsje2", Pic=@"images/bike2.jpg"},
            new Bike {Price= decimal.Parse("250"), Name="fietsje3", Pic=@"images/bike3.jpg"},
            new Bike {Price= decimal.Parse("350"), Name="fietsje4", Pic=@"images/bike4.jpg"}
            };
            foreach (var fiets in fietsLijst)
            {
                context.Bikes.Add(fiets);
            }
            context.SaveChanges();
        }
    }
}
