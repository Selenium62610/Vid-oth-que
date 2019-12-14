using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VidéoThèque.Models
{
    public class User
    {
        //Déclaration de toutes les propriétés d'un User (id, nom, prénom, identifiant ...)
        public int ID { get; set; }

        [Display(Name = "Nom")]
        [Required(ErrorMessage = "Un nom est requis.")]
        public string Nom { get; set; }

        [Display(Name = "Prenom")]
        [Required(ErrorMessage = "Un prénom est requis.")]
        public string Prenom { get; set; }

        [Display(Name = "Date de Naissance")]
        [Required(ErrorMessage = "Une date de naissance est requise.")]
        public DateTime DateDeNaissance { get; set; }

        [Display(Name = "Identifiant")]
        [Required(ErrorMessage = "Un identifiant est requis. Il vous servira lors de la connexion.")]
        public string Identifiant { get; set; }

        [Display(Name = "Mot de passe")]
        [Required(ErrorMessage = "Un mot de passe est requis. Il vous servira lors de la connexion.")]
        public string MotDePasse { get; set; }
    }

}
