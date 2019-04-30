using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SneakersApp.Data.Models
{
    public class Shoes
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public string Url { get; set; }
        public virtual IEnumerable<Tag> Tags { get; set; }
        public string CollectionID { get; set; }
        public string UserId { get; set; }
    }
}
