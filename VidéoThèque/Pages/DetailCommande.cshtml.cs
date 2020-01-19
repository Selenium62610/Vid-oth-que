using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VidéoThèque.Models;

namespace VidéoThèque.Pages
{
    public class DetailCommandeModel : PageModel
    {
        // Déclaration d'un VidéoThèqueContext
        private readonly VidéoThèque.Models.VidéoThèqueContext _context;

        public DetailCommandeModel(VidéoThèque.Models.VidéoThèqueContext context)
        {
            _context = context;
        }

        //Déclaration de la propriété obligatoire Movie
        public Commande Commande { get; set; }
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
