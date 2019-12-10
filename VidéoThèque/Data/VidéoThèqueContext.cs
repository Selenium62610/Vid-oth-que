using Microsoft.EntityFrameworkCore;

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
