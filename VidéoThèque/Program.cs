using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using VidéoThèque.Models;

namespace VidéoThèque
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Création d'un host (responsable de la gestion du démarrage et de la durée de vie de l'appli)
            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    //instance de contexte de base de données à partir du conteneur d’injection de dépendances
                    var context = services.
                        GetRequiredService<VidéoThèqueContext>();
                    context.Database.Migrate(); 
                    //appel de la méthode de remplissage de la bdd
                    SeedData.Initialize(services);
                    UserData.Initialize(services);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "Une erreur empêche l'ajout à la bdd.");
                }
            }

            host.Run();
        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
