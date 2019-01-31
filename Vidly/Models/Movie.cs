﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dddd, MMMM dd, yyyy}")]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dddd, MMMM dd, yyyy}")]
        public DateTime? DateAdded { get; set; }

        [Display(Name = "Number In Stock")]
        public int NumberInStock { get; set; }
    }
}
