using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VidéoThèque.Models;

namespace VidéoThèque.Pages.Movies
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
        public IList<Movie> Movie { get;set; }
        [BindProperty(SupportsGet = true)]

        //Contient le texte de l'utilisateur entrée dans la zone de recherche
        public string SearchString { get; set; }

        //Contient le texte de l'utilisateur entrée dans la zone de recherche de date (plus récent ou plus vieux)
        public string SearchDate { get; set; }

        public string SearchLocation { get; set; }

        //Contient la liste des genres
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]

        //Contient le genre sélectionné par l'utilisateur
        public string MovieGenre { get; set; }

        public String NFilm { get; set; }


        public async Task OnGetAsync(string sortOrder)
        {
            
            SearchDate = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            SearchLocation = sortOrder == "Date" ? "date_desc" : "Date";
            IQueryable<string> genreQuery = from m in _context.Movie orderby m.Genre select m.Genre;

            var movies = from m in _context.Movie select m;

            IQueryable<Movie> MovieQuery = (from m in _context.Movie
                                           select m);


            //Si la requête n'est pas nul (SearchString) la requête sur les film est modifié on affiche telle type de film
            if (!string.IsNullOrEmpty(SearchString)) 
            {
                MovieQuery = MovieQuery.Where(s => s.Title.Contains(SearchString));
            }

            if(!string.IsNullOrEmpty(MovieGenre))
            {
                MovieQuery = MovieQuery.Where(x => x.Genre == MovieGenre);
            }
            if (NFilm == "50")
            {
                MovieQuery.OrderBy(m => m.NbLocation).Take(2);
            }
            switch (sortOrder)
            {
                case "name_desc":
                    MovieQuery = MovieQuery.OrderByDescending(m => m.ReleaseDate);
                    break;
                case "Date":
                    MovieQuery = MovieQuery.OrderBy(m => m.NbLocation).Take(10);
                    break;
                case "date_desc":
                    MovieQuery = MovieQuery.OrderByDescending(m => m.NbLocation);
                    break;
                default:
                    MovieQuery = MovieQuery.OrderBy(m => m.ReleaseDate);
                    break;
            }

            //On affiche la requête si elle est modifié, tout les films sinon.
            Movie = await MovieQuery.AsNoTracking().ToListAsync();

            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());

        }
    }
}
