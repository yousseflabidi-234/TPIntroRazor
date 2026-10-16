using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TPIntroRazor.Pages
{
    public class CalculModel : PageModel
    {
        // [BindProperty] associe directement les saisies du formulaire aux propriétés C#
        [BindProperty]
        public string Nom { get; set; } = string.Empty;

        [BindProperty]
        public int AnneeNaissance { get; set; }

        public string Message { get; set; } = string.Empty;

        public void OnGet() { }

        // OnPost() s'exécute à la soumission du formulaire (HTTP POST)
        public void OnPost()
        {
            int age = DateTime.Now.Year - AnneeNaissance;
            if (age < 0 || age > 120)
            {
                Message = "Année de naissance invalide !";
            }
            else
            {
                Message = $"Bonjour {Nom}, vous avez environ {age} ans cette année !";
            }
        }
    }
}