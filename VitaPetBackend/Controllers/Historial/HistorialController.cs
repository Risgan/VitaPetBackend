using Microsoft.AspNetCore.Mvc;

namespace VitaPetBackend.Controllers.Historial
{
    public class HistorialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
