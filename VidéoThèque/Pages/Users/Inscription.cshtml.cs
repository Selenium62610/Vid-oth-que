using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VidéoThèque.Models;

namespace VidéoThèque.Pages.Users
{
    public class InscriptionModel : PageModel
    {
        // Déclaration d'un VidéoThèqueContext
        private readonly VidéoThèque.Models.VidéoThèqueContext _context;


        // Constructeur qui ajoute VidéoThèqueContext à la page
        public InscriptionModel(VidéoThèque.Models.VidéoThèqueContext context)
        {
            _context = context;
        }


        //Intialise l'état de la page
        public IActionResult OnGet()
        {
            //Permet de créer un objet PageResult qui affiche la page create.cshtml
            return Page();
        }
        [BindProperty]
        public new User User { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            //Si erreur liée au modèle, le formulaire est réaffiché
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Sinon on ajoute le film
            _context.User.Add(User);
            await _context.SaveChangesAsync();
            //Redirection vers la page Privacy 
            return RedirectToPage("../Privacy");
        }
    }
}
