using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace VidéoThèque.Models
{
    public class VidéoThèqueContext : DbContext
    {
        public VidéoThèqueContext (DbContextOptions<VidéoThèqueContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
    }
}
