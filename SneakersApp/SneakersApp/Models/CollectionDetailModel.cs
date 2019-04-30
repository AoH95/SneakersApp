using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SneakersApp.Data.Models;

namespace SneakersApp.Models
{
    public class CollectionDetailModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<Shoes> Shoes { get; set; }
    }
}
