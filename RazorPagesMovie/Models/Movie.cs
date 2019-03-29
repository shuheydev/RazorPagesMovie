using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60,MinimumLength =3)]
        [Required]
        [Display(Name ="タイトル")]
        public string Title { get; set; }

        [Display(Name ="公開日")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(1,100)]
        [DataType(DataType.Currency)]
        [Display(Name = "価格")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        [Display(Name ="ジャンル")]
        public string Genre { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        [Display(Name ="レーティング")]
        public string Rating { get; set; }
    }
}
