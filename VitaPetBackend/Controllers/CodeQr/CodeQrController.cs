using Microsoft.AspNetCore.Mvc;

namespace VitaPetBackend.Controllers.CodeQr
{
    public class CodeQrController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
