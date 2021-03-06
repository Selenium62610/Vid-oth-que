using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
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
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            
            //Si erreur liée au modèle, le formulaire est réaffiché
            if (!ModelState.IsValid)
            {
                return Page();
            }
            //Sinon on ajoute la commande
            _context.Commande.Add(Commande);
            // On incrémente également de nb de locations du films dans la base de donées Movie
            var query = from m in _context.Movie where m.ID == id select m;
            foreach (Movie m in query)
            {
                m.NbLocation += 1;
            }
            // On sauvegarde ces changements
            await _context.SaveChangesAsync();
            //Redirection vers la page qui indique que la commande a été prise en compte
            return RedirectToPage("./ValidationCommande");
        }      
    }
}
