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
        public void OnGet()
        {
        }
        public User User { get; set; }
    }
}
