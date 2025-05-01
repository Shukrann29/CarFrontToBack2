using Microsoft.AspNetCore.Mvc;

namespace CarFrontToBack2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
