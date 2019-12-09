using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VidéoThèque.Models
{
    // spécifie les entités qui sont incluses dans le modèle de données
    public class VidéoThèqueContext : DbContext
    {
        public VidéoThèqueContext (DbContextOptions<VidéoThèqueContext> options)
            : base(options)
        {
        }

        public DbSet<VidéoThèque.Models.Movie> Movie { get; set; }

        public DbSet<VidéoThèque.Models.User> User { get; set; }

    }
}