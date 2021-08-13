using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bikeshop.Models
{
    public class Bike
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Naam is verplicht!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Prijs is verplicht!")]
        public decimal Price { get; set; }
        public string Pic { get; set; }
    }
}
