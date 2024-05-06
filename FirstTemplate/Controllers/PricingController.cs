using Microsoft.AspNetCore.Mvc;

namespace FirstTemplate.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
