using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace VidéoThèque.Models
{
    //Cette classe représente le début de la base de données qui contiendra les films
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VidéoThèqueContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<VidéoThèqueContext>>()))
            {
                //Si la base de données contient des films
                if (context.Movie.Any())
                {
                    return;   // Aucun film n’est ajouté à la bdd

                }
                //Sinon les films suivants sont ajoutés
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Realisateur = "Test",
                        Acteurs = "De Niro",
                        Synopsis = "La rencontre de deux personnes",
                        NbLocation = 2

                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Realisateur = "Test",
                        Acteurs = "De Niro",
                        Synopsis = "La rencontre de deux personnes",
                        NbLocation = 12
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Realisateur = "Test",
                        Acteurs = "De Niro",
                        Synopsis = "La rencontre de deux personnes"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Realisateur = "Test",
                        Acteurs = "De Niro",
                        Synopsis = "La rencontre de deux personnes"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
