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

        public Genre Genre { get; set; }

        [Required]
        [Display(Name="Genre")]
        public int GenreId { get; set; }

        [Display(Name = "Relesed Date")]
        public DateTime Released { get; set; }

        [Display(Name = "Added Date")]
        public DateTime Added { get; set; }

        [Display(Name = "Number in Stock")]
        public byte InStock { get; set; }
    }

}