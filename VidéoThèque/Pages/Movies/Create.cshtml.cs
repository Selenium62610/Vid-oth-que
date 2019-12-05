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
        // Déclaration d'un VidéoThèqueContext
        private readonly VidéoThèque.Models.VidéoThèqueContext _context;


        // Constructeur qui ajoute VidéoThèqueContext à la page
        public CreateModel(VidéoThèque.Models.VidéoThèqueContext context)
        {
            _context = context;
        }


        //Intialise l'état de la page
        public IActionResult OnGet()
        {
            //Permet de créer un objet PageResult qui affiche la page create.cshtml
            return Page();
        }

        //Déclaration de la propriété obligatoire Movie
        [BindProperty]
        public Movie Movie { get; set; }


        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        //Instructions de retour de la page 
        public async Task<IActionResult> OnPostAsync()
        {
            //Si erreur liée au modèle, le formulaire est réaffiché
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Sinon on ajoute le film
            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();
            //Redirection vers la page Index (l'accueil)
            return RedirectToPage("./Index");
        }
    }
}
