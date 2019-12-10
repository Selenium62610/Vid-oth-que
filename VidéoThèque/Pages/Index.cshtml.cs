using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using VidéoThèque.Models;
using Xceed.Wpf.Toolkit;

namespace VidéoThèque.Pages
{
    public class IndexModel : PageModel
    {
        // Déclaration d'un VidéoThèqueContext
        private readonly VidéoThèque.Models.VidéoThèqueContext _context;

        // Constructeur
        public IndexModel(VidéoThèque.Models.VidéoThèqueContext context)
        {
            _context = context;
        }

        //Permet la recherche par nom et par Genre
        public IList<User> User { get; set; }

        [BindProperty(SupportsGet = true)]
        //Contient le texte de l'utilisateur entrée dans la zone de recherche
        [Required(ErrorMessage = "Un identifiant est requis.")]
        public string SearchIdentifiant { get; set; }

        [BindProperty(SupportsGet = true)]
        [Required(ErrorMessage = "Un mot de passe est requis.")]
        //Contient le texte de l'utilisateur entrée dans la zone de recherche
        public string SearchMdp { get; set; }

        
        



        //Parmis tout les films on recherche celui qui contiens le même titre que celui dans la barre de recherche
        public async Task OnGetAsync()
        {
            //Récupère tout les gens de la liste  
            var users = from u in _context.User select u;

                //Si la requête n'est pas nul (SearchString) la requête sur les film est modifié on affiche telle type de film
            if (!string.IsNullOrEmpty(SearchIdentifiant) && !string.IsNullOrEmpty(SearchMdp)){
                users = users.Where(s => SearchIdentifiant==s.Identifiant);
                users = users.Where(s => SearchMdp == s.MotDePasse);
            }
            //On affiche la requête si elle est modifié, tout les films sinon.
            User = await users.ToListAsync();
        }

    }
}
