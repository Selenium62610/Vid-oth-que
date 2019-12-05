using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        //Déclaration de toutes les propriétés d'un Movie (id, titre, genre ...) avec leurs attributs

        //Clé primaire requise pour la base de données des films
        public int ID { get; set; }


        //Interdit d'entrer un titre contenant moins de 3 lettres et plus de 60 caractères
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "Un titre est requis, il doit contenir moins de 3 lettres et plus de 60 caractères.")]
        [Display(Name = "Titre")]
        public string Title { get; set; }


        [Display(Name ="Date de Sortie")]
        [Required(ErrorMessage = "Une date de sortie est requise")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }


        public string Genre { get; set; }


        [Range(1, 100)]
        [Display(Name = "Prix")]
        [Required(ErrorMessage = "Un prix est requis")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }


        public string Realisateur { get; set; }


        public string Acteurs { get; set; }


        public string Synopsis { get; set; }
    }
}
