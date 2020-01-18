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
    public class CheckCommandeModel : PageModel
    {
        private readonly VidéoThèque.Models.VidéoThèqueContext _context;

        public CheckCommandeModel(VidéoThèque.Models.VidéoThèqueContext context)
        {
            _context = context;
        }

        public Commande Commande { get; set; }

        public IList<Movie> Movie { get; set; }
        [BindProperty(SupportsGet = true)]

        //Contient le texte de l'utilisateur entrée dans la zone de recherche
        public string SearchString { get; set; }

        //Contient le texte de l'utilisateur entrée dans la zone de recherche de date (plus récent ou plus vieux)
        public string SearchDate { get; set; }

        public string SearchLocation { get; set; }

        //Contient le genre sélectionné par l'utilisateur
        public string MovieGenre { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Commande = await _context.Commande.FirstOrDefaultAsync(m => m.ID == id);

            if (Commande == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
