using Microsoft.AspNetCore.Mvc;

namespace AulaGitApplication1.Models
{
    public class Escola : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
