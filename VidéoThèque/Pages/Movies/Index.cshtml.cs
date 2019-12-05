using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using VidéoThèque.Models;

namespace VidéoThèque.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly VidéoThèque.Models.VidéoThèqueContext _context;

        public IndexModel(VidéoThèque.Models.VidéoThèqueContext context)
        {
            _context = context;
        }

        //Permet la recherche par nom et par Genre
        public IList<Movie> Movie { get;set; }
        [BindProperty(SupportsGet = true)]

        //Contient le texte de l'utilisateur entrée dans la zone de recherche
        public string SearchString { get; set; }

        //Contient la liste des genres
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]

        //Contient le genre sélectionné par l'utilisateur
        public string MovieGenre { get; set; }



        //Parmis tout les films on recherche celui qui contiens le même titre que celui dans la barre de recherche
        public async Task OnGetAsync()
        {
            //Récupère tout les gens de la liste
            IQueryable<string> genreQuery = from m in _context.Movie orderby m.Genre select m.Genre;

            var movies = from m in _context.Movie select m;

            //Si la requête n'est pas nul (SearchString) la requête sur les film est modifié on affiche telle type de film
            if(!string.IsNullOrEmpty(SearchString)) 
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }

            if(!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Genre == MovieGenre);
            }

            //On affiche la requête si elle est modifié, tout les films sinon.
            Movie = await movies.ToListAsync();
        
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
        }
    }
}
