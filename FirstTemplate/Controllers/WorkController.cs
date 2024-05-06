using Microsoft.AspNetCore.Mvc;

namespace FirstTemplate.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
