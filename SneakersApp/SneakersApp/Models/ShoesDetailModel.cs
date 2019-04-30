﻿using System;
using System.Collections.Generic;

namespace SneakersApp.Models
{
    public class ShoesDetailModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public string Url { get; set; }
        public List<string> Tags { get; set; }
    }
}
