using Microsoft.AspNetCore.Mvc;

namespace Assig1.Controllers
{
    public class SpeedingOffencesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
