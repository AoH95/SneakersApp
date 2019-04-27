﻿using System;
using System.Collections.Generic;

namespace SneakersApp.Data.Models
{
    public class Shoes
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public string Url { get; set; }
        public virtual IEnumerable<Tag> Tags { get; set; }
    }
}
