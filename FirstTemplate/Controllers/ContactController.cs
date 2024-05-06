using Microsoft.AspNetCore.Mvc;

namespace FirstTemplate.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
