using System;
using System.Collections.Generic;
using System.Text;

namespace SneakersApp.Data.Models
{
    public class Shoes
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public string Url { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public string Status { get; set; }
    }
}
