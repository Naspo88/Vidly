using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dddd, MMMM dd, yyyy}")]
        [Required]
        public DateTime? ReleaseDate { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dddd, MMMM dd, yyyy}")]
        public DateTime? DateAdded { get; set; }

        [Display(Name = "Number In Stock")]
        [Range(1, 20)]
        public int NumberInStock { get; set; }
    }
}