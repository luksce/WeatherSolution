using Microsoft.AspNetCore.Mvc;

namespace WeatherSolution.Controllers
{
    public class PrevisaoClimaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
