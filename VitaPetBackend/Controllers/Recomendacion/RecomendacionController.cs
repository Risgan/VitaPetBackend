using Microsoft.AspNetCore.Mvc;

namespace VitaPetBackend.Controllers.Recomendacion
{
    public class RecomendacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
