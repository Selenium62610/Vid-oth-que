using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VidéoThèque.Models
{
    public class Commande
    {
        //Déclaration de toutes les propriétés d'une Commande  (id, id du film, date de retour, id du loueur) avec leurs attributs
        //Clé primaire requise pour la base de données des commandes
        public int ID { get; set; }

        public int IDmovie { get; set; }

        public int dureeLocation { get; set; }

        public String IDuser { get; set; }

        public DateTime dateLocation
        { get; set; }

        private DateTime dr;

        public DateTime dateRetour
        {
            get
            {
                return dr;
            }
            set
            {
                DateTime d = dateLocation;
                double j = dureeLocation;
                dr = d.AddDays(j);
            }
        }

        public double price{ get; set;}

    }
}
