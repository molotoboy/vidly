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
        public string Name { get; set; }
        [Required]
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public DateTime Released { get; set; }
        public DateTime Added { get; set; }
        public byte InStock { get; set; }
    }

}