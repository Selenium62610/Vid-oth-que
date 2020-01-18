using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VidéoThèque.Models
{
    public class CommandeData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VidéoThèqueContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<VidéoThèqueContext>>()))
            {
                //Si la base de données contient des films
                if (context.Commande.Any())
                {
                    return;   // Aucun film n’est ajouté à la bdd

                }
                //Sinon les films suivants sont ajoutés
                context.Commande.AddRange(
                    new Commande
                    {
                        IDmovie = 1,
                        dureeLocation = 2,
                        IDuser = "Sélénium",
                        dateLocation = DateTime.Parse("2019-4-15"),
                        dateRetour = DateTime.Parse("2019-4-17"),
                        price = 5.99
                    }
                ); ;
                context.SaveChanges();
            }
        }
    }
}