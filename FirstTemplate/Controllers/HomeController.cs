using Microsoft.AspNetCore.Mvc;

namespace FirstTemplate.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
