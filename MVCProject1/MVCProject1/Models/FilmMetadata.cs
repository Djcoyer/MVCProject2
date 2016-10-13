using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCProject1.Models
{
    [MetadataType(typeof(Film.Metadata))]
    public partial class Film
    {
        sealed class Metadata
        {
            [Key]
            public System.Guid FilmId { get; set; }

            [Required]
            [Display(Name ="Film Genre")]
            public string Genre { get; set; }


            public string Series { get; set; }

            [Required]
            [Display(Name="Film Name")]
            public string Name { get; set; }

            [Required]
            [Display(Name ="Release Year")]
            [RegularExpression(@"^(19|20)\d{2}$", ErrorMessage ="Please enter a valid release year.")]
            public int Year { get; set; }

            public string Details { get; set; }

            [RegularExpression(@"^[1-9][0-9]?$|^100$")]
            public Nullable<int> NumberofSeries { get; set; }

            public bool Available { get; set; }
        }


    }
}