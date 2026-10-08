using Microsoft.AspNetCore.Mvc;

namespace AulaGitApplication1.Models
{
    public class Aluno : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
