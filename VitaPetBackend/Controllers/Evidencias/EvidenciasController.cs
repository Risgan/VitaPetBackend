using Microsoft.AspNetCore.Mvc;

namespace VitaPetBackend.Controllers.Evidencias
{
    public class EvidenciasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
