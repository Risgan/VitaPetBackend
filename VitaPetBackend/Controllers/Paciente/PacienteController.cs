using Microsoft.AspNetCore.Mvc;

namespace VitaPetBackend.Controllers.Paciente
{
    public class PacienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
