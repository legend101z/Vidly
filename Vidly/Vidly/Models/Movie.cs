using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string  Name { get; set; }

       
        public Genre Genre { get; set; }


        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDateTime { get; set; } 
        public DateTime DateAddedTime { get; set; }

        [Display(Name = "Number In Stock")]
        [Range(1,20)] 
        public int NumberInStock { get; set; }


    }
}