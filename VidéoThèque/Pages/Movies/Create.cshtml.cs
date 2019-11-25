using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovie.Models;
using VidéoThèque.Models;

namespace VidéoThèque.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly VidéoThèque.Models.VidéoThèqueContext _context;

        public CreateModel(VidéoThèque.Models.VidéoThèqueContext context)
        {
            _context = context;
        }

        /// /Intialise l'état de la page
        public IActionResult OnGet()
        {
            //Permet de créer un objet PageResult qui affiche la page create.cshtml
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            //Si erreur le formulaire est réaffiché
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Sinon on ajoute le film
            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();
        
            return RedirectToPage("./Index");
        }
    }
}
