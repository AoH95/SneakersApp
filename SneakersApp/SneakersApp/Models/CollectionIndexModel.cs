using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SneakersApp.Data.Models;

namespace SneakersApp.Models
{
    public class CollectionIndexModel
    {
        public IEnumerable<Collection> Collection { get; set; }
        public string SearchQuery { get; set; }
    }
}
