using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using VidéoThèque.Models;

namespace VidéoThèque.Pages.Movies
{
    public class EditModel : PageModel
    {
        // Déclaration d'un VidéoThèqueContext
        private readonly VidéoThèque.Models.VidéoThèqueContext _context;

        // Constructeur
        public EditModel(VidéoThèque.Models.VidéoThèqueContext context)
        {
            _context = context;
        }

        //Déclaration de la propriété obligatoire Movie
        [BindProperty]
        public Movie Movie { get; set; }

        //Gestion de l'accès à la page Edit et extraction du film de la bdd si c'est possible
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        // Edition du film s'il existe dans la bdd
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Movie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(Movie.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        // Renvoie true si le film est dans la bdd
        private bool MovieExists(int id)
        {
            return _context.Movie.Any(e => e.ID == id);
        }
    }
}
