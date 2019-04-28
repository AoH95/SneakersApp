﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SneakersApp.Data.Models
{
    public class Collection
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
    }
}
