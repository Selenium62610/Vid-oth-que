using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using VidéoThèque.Models;


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

        //Permet la recherche par Identifiant et Mot de passe 
        public new IList<User> User { get; set; }

        //Lit la valeur du Mot de passe du formulaire
        [BindProperty(SupportsGet = true)]
        //Champs obligatoire

        [Required(ErrorMessage = "Un identifiant est requis.")]
        //Contient le texte de l'utilisateur entrée dans la zone de recherche
        public string SearchIdentifiant { get; set; }

        //Lit la valeur du Mot de passe du formulaire
        [BindProperty(SupportsGet = true)]
        //Champs obligatoire
        [Required(ErrorMessage = "Un mot de passe est requis.")]
        //Contient le texte de l'utilisateur entrée dans la zone de recherche
        public string SearchMdp { get; set; }

        // Liste de claims (revendications) 
        public List<Claim> claims = new List<Claim>();

        //Parmis tout les utilisateurs on recherche celui qui contient les mêmes identifiants et mot de passe que celui dans la barre de recherche (s'il existe)
        public async Task OnGetAsync()
        {
            //Récupère tout les gens de la liste  
            var users = from u in _context.User select u;


            //Si les champs Identifiants et Mot de Passe ne sont pas nuls
            if (!string.IsNullOrEmpty(SearchIdentifiant) && !string.IsNullOrEmpty(SearchMdp))
            {
                users = users.Where(s => SearchIdentifiant == s.Identifiant);
                users = users.Where(s => SearchMdp == s.MotDePasse);
                // S'il n'y a pas d'utilisateurs avec ces identifiant et mot de passe
                if (users.Count() == 0)
                {
                    //Redirection vers la page d'inscription
                    Response.Redirect("./Users/Inscription");

                }
                // Sinon redirection vers page d'accueil client 
                else
                {
                    bool role = true;
                    String id = "";
                    // On récupère le role de l'utilisateur (role = true si c'est l'admin et false sinon) et son id
                    foreach (User u in users)
                    {
                        role = u.isAdmin;
                        id = u.ID.ToString();
                    }
                    try
                    {
                        // Setting, le type de Name prend la valeur de l'identifiant de l'user
                        claims.Add(new Claim(ClaimTypes.Name, SearchIdentifiant));
                        claims.Add(new Claim(ClaimTypes.NameIdentifier, id));
                        var claimIdenties = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var claimPrincipal = new ClaimsPrincipal(claimIdenties);
                        var authenticationManager = Request.HttpContext;
                        // Authentification 
                        await authenticationManager.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimPrincipal, new AuthenticationProperties() { IsPersistent = true });
                    }
                    catch (Exception ex)
                    {
                        // Info    
                    }
                    // Si l'utilisateur n'est pas un admin
                    if (role.CompareTo(true) != 0)
                    {
                        // Redirection liste de films à louer
                        Response.Redirect("./MovieDisplay");
                    }
                    // Sinon il s'agit de l'admin
                    else
                    {
                        // Redirection à la page des films de la vidéothèque
                        Response.Redirect("./Movies/Index");   
                    }
                }

            }
        }
    }
}

