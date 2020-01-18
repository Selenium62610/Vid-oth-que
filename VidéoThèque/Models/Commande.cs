using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace VidéoThèque.Models
{
    public class Commande
    {
        //Déclaration de toutes les propriétés d'une Commande  (id, id du film, date de retour, id du loueur) avec leurs attributs
        //Clé primaire requise pour la base de données des commandes
        public int ID { get; set; }

        // ID du film loué
        public int IDmovie { get; set; }

        // Durée de la location en jour
        public int dureeLocation { get; set; }

        // Identifiant de l'utilisateur
        public String IDuser { get; set; }

        // Titre du film
        public String TitleMovie { get; set; }

        [DataType(DataType.Date)]
        // Date du début de la location 
        public DateTime dateLocation
        { get; set; }

        // Prix de base du film
        public decimal prixDuFilm
        { get; set; }

        // Date de retour (calculé grâce à dr)
        private DateTime dr;
        [DataType(DataType.Date)]
        public DateTime dateRetour
        {
            get
            {
                return dateRetour = dr;
            }
            set
            {
                DateTime d = dateLocation;
                double j = dureeLocation;
                dr = d.AddDays(j);
            }
        }


        // Prix du film en fonction du nombre de jours de location
        private double calculPrix;
        public double price{ 
            get { return price = calculPrix; } 
            set { decimal d = prixDuFilm;
                double du = dureeLocation;
                decimal.ToDouble(d);
                calculPrix = decimal.ToDouble(d) + du;
            } 
        }

    }
}
