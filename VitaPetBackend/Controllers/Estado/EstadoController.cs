using Microsoft.AspNetCore.Mvc;

namespace VitaPetBackend.Controllers.Estado
{
    public class EstadoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
