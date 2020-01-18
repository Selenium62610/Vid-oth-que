using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VidéoThèque.Models;

namespace VidéoThèque.Pages
{
    public class CheckCommandeModel : PageModel
    {
        // Déclaration d'un VidéoThèqueContext
        private readonly VidéoThèque.Models.VidéoThèqueContext _context;

        //Constructeur
        public CheckCommandeModel(VidéoThèque.Models.VidéoThèqueContext context)
        {
            _context = context;
        }

        //Contient le texte de l'utilisateur entrée dans la zone de recherche
        public string SearchString { get; set; }

        //Déclaration de la propriété obligatoire Movie
        public Movie Movie { get; set; }

        //Déclaration de la propriété Commande
        public Commande Commande { get; set; }

        //Contient la liste des genres
        public SelectList Utilisateur { get; set; }
        [BindProperty(SupportsGet = true)]

        //List de commande temporaire (sera modifié pour modifié l'affichage de CheckCommande)
        public IList<Commande> CommandeList { get; set; }
        [BindProperty(SupportsGet = true)]

        //Contient le genre sélectionné par l'utilisateur
        public string MovieGenre { get; set; }


        public async Task OnGetAsync()
        {
            var commande = from m in _context.Commande select m;

            IQueryable<string> UtilisateurQuery = from m in _context.Commande orderby m.TitleMovie select m.TitleMovie;

            IQueryable < Commande > CommandeQuery = from m in _context.Commande
                                                    select m;

            //On vérifie que MovieGenre n'est pas null ou vide 
            if (!string.IsNullOrEmpty(MovieGenre))
            {
                CommandeQuery = CommandeQuery.Where(x => x.TitleMovie == MovieGenre);
            }

            if (!string.IsNullOrEmpty(SearchString))
            {
                CommandeQuery = CommandeQuery.Where(x => x.IDuser.Contains(SearchString));
            }

            CommandeList = await CommandeQuery.AsNoTracking().ToListAsync();

            Utilisateur = new SelectList(await UtilisateurQuery.Distinct().ToListAsync());
        }

    }
}
