using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VidéoThèque.Models;

namespace VidéoThèque.Pages.Movies
{
    public class CommandeModel : PageModel
    {
        // Déclaration d'un VidéoThèqueContext
        private readonly VidéoThèque.Models.VidéoThèqueContext _context;

        //Constructeur
        public CommandeModel(VidéoThèque.Models.VidéoThèqueContext context)
        {
            _context = context;
        }

        //Déclaration de la propriété obligatoire Movie
        public Movie Movie { get; set; }

        public User User { get; set; }

        //Gestion de l'accès à la page Commande et extraction du film de la bdd si c'est possible
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

        [BindProperty]
        public Commande Commande { get; set; }

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
            //Sinon on ajoute la commande
            _context.Commande.Add(Commande);
            await _context.SaveChangesAsync();

            //Incrémentation de nombre de location d'un film
            /*    Movie = await _context.Movie
                .AsNoTracking()
                .Include(movieNombreLocation => Movie.NbLocation+1)
                .FirstOrDefaultAsync(m => m.ID == Movie.ID);*/
            //var updateCommand = "Update Movie SET NbLocation=@movieNombreLocation WHERE Title=@movieId";
            //await _context.Movie.Add(Movie);


            //Redirection vers la page Index (l'accueil)
            return RedirectToPage("./Index");
        }
    }
}
