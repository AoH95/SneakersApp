using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SneakersApp.Data.Models
{
    public class Collection
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }
        public IList<Shoes> Shoes { get; set; }
    }
}
