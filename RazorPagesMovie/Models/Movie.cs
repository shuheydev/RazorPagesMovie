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
        [Display(Name ="ID")]
        public int ID { get; set; }

        [Display(Name ="タイトル")]
        public string Title { get; set; }

        [Display(Name ="公開日")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name ="ジャンル")]
        public string Genre { get; set; }
        [Display(Name ="価格")]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
