using Microsoft.AspNetCore.Mvc;

namespace FirstTemplate.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
