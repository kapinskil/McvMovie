﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace McvMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title{ get; set; }

        [DataType(DataType.Date)]
        public DateTime RelasesData { get; set; }
        public string Genre{ get; set; }
        public decimal Price { get; set; }
    }
}