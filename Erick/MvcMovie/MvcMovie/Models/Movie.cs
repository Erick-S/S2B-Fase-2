using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Title { get; set; }
        [Required]
        [StringLength(40, MinimumLength = 5)]
        public string Director { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [DataType(DataType.Currency)]
        public decimal Gross { get; set; }
        [Range(0.0, 10.0)]
        public double Rating { get; set; }
        public int GenreID { get; set; }
        public virtual Genre Genre { get; set; }
    }
}