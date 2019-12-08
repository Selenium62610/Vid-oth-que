using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VidéoThèque.Models
{
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