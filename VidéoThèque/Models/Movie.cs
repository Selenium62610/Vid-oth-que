using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        //Interdit d'entrer un titre contenant moins de 3 lettres et plus de 60 caractères
        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Titre")]
        public string Title { get; set; }

        [Display(Name ="Date de Sortie")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        [Range(1, 100)]
        [Display(Name = "Prix")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public string Realisateur { get; set; }


        public string Acteurs { get; set; }

        public string Synopsis { get; set; }
    }
}
