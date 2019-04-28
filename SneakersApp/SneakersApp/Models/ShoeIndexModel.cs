 using System.Collections.Generic;
using SneakersApp.Data.Models;

namespace SneakersApp.Models
{
    public class ShoeIndexModel
    {
        public IEnumerable<Shoes> Shoes { get; set; }
        public string SearchQuery { get; set; }
    }
}
