using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace VidéoThèque.Models
{

    public static class UserData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VidéoThèqueContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<VidéoThèqueContext>>()))
            {
                //Si la base de données contient des utilisateurs
                if (context.User.Any())
                {

                    return;   // Aucun utilisateur n’est ajouté à la bdd

                }
                //Sinon les utilisateurs suivants sont ajoutés
                context.User.AddRange(
                    new User
                    {
                        Nom = "Admin",
                        Prenom = "Admin",
                        DateDeNaissance = DateTime.Parse("1989-2-12"),
                        Identifiant = "Admin",
                        MotDePasse = "Admin",
                        isAdmin = true
                    },

                    new User
                    {
                        Nom = "GRIMARD",
                        Prenom = "Bettino",
                        DateDeNaissance = DateTime.Parse("1989-2-12"),
                        Identifiant = "Bettino",
                        MotDePasse = "azerty123",
                        isAdmin = true
                    },
                    new User
                    {
                        Nom = "DELATTRE",
                        Prenom = "Edouard",
                        DateDeNaissance = DateTime.Parse("1997-1-25"),
                        Identifiant = "Sélénium",
                        MotDePasse = "azerty123",
                        isAdmin = false
                    }
                ); 
                context.SaveChanges();
            }
        }
    }
}
