using System;
using System.Collections.Generic;
using Bikeshop.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Bikeshop.wwwroot.Data
{
    public class BikeDbContext : DbContext
    {
        public BikeDbContext(DbContextOptions<BikeDbContext> options) : base(options)
        {

        }
        public DbSet<Bike> Bikes { get; set; }
    }
}
