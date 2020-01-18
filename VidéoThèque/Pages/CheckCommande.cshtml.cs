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

        //Déclaration de la propriété obligatoire Movie
        public Movie Movie { get; set; }

        //Déclaration de la propriété Commande
        public Commande Commande { get; set; }

        [BindProperty(SupportsGet = true)]
        //Liste de commande temporaire (sera modifié pour modifié l'affichage de CheckCommande)
        public IList<Commande> CommandeList { get; set; }



        //Contient la liste des locations
        public SelectList Locations { get; set; }

        [BindProperty(SupportsGet = true)]
        //Contient le nom du film sélectionné par l'utilisateur
        public string EtatCommande { get; set; }

        
        [BindProperty(SupportsGet = true)]
        //Contient le nom du film sélectionné par l'utilisateur
        public string MovieTitre { get; set; }
   
        //Contient la liste des films
        public SelectList Films { get; set; }
       

        [BindProperty(SupportsGet = true)]
        //Contient le texte de l'utilisateur entrée dans la zone de recherche
        public string SearchString { get; set; }

        public int SearchNumber { get; set; }

        public async Task OnGetAsync()
        {
            var commande = from m in _context.Commande select m;

            IQueryable<string> UtilisateurQuery = from m in _context.Commande orderby m.TitleMovie select m.TitleMovie;

            IQueryable < Commande > CommandeQuery = from m in _context.Commande
                                                    select m;

            //On vérifie que MovieTitre n'est pas null ou vide 
            if (!string.IsNullOrEmpty(MovieTitre))
            {
                CommandeQuery = CommandeQuery.Where(x => x.TitleMovie == MovieTitre);
            }

            if (!string.IsNullOrEmpty(SearchString))
            {
                CommandeQuery = CommandeQuery.Where(x => x.IDuser.Contains(SearchString));
            }

            if (EtatCommande == "EnCours")
            {
                CommandeQuery = CommandeQuery.Where(x => DateTime.Compare(DateTime.Now, x.dateRetour)<0);
            }
            if (EtatCommande == "Finis")
            {
                CommandeQuery = CommandeQuery.Where(x => DateTime.Compare(DateTime.Now, x.dateRetour) > 0);
            }

            CommandeList = await CommandeQuery.ToListAsync();

            Films = new SelectList(await CommandeQuery.Distinct().ToListAsync());

            Locations = new SelectList(await CommandeQuery.Distinct().ToListAsync());
        }

    }
}
