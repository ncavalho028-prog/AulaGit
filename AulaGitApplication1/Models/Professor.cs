using Microsoft.AspNetCore.Mvc;

namespace AulaGitApplication1.Models
{
    public class Professor : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
