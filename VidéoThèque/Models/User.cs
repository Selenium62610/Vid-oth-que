using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VidéoThèque.Models
{
    public class User
    {
        //Déclaration de toutes les propriétés d'un User (id, nom, prénom, identifiant ...)
        public int ID { get; set; }


        [Required(ErrorMessage = "Un nom est requis.")]
        [Display(Name = "Nom")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Un prénom est requis.")]
        [Display(Name = "Prenom")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "Une date de naissance est requise.")]
        [Display(Name = "Date de Naissance")]
        public DateTime DateDeNaissance { get; set; }

        [Required(ErrorMessage = "Un identifiant est requis. Il vous servira lors de la connexion.")]
        [Display(Name = "Identifiant")]
        public string Identifiant { get; set; }

        [Required(ErrorMessage = "Un mot de passe est requis. Il vous servira lors de la connexion.")]
        [Display(Name = "Mot de passe")]
        public string MotDePasse { get; set; }
    }

}
