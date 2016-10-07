using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }
  
        public DateTime ReleaseDateTime { get; set; }
        public DateTime DateAddedTime { get; set; }

        [Range(1, 20)]
        public int NumberInStock { get; set; }
    }
}