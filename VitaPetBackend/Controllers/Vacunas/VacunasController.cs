using Microsoft.AspNetCore.Mvc;

namespace VitaPetBackend.Controllers.Vacunas
{
    public class VacunasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
