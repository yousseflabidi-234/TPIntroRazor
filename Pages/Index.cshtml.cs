using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TPIntroRazor.Pages
{
    public class IndexModel : PageModel
    {
        public string MessageAccueil { get; set; } = string.Empty;

        public List<string> Modules { get; set; } = new();

        public void OnGet()
        {
            MessageAccueil = "Bienvenue dans le monde de Razor Pages !";
            Modules = new List<string>
            {
                "Architecture d'un projet Razor Pages",
                "Syntaxe Razor (@)",
                "Liaison de données avec [BindProperty]",
                "Traitement de formulaires (GET / POST)"
            };
        }
    }
}