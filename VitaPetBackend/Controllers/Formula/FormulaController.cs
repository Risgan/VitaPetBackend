using Microsoft.AspNetCore.Mvc;

namespace VitaPetBackend.Controllers.Formula
{
    public class FormulaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
