using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace VitaPetBackend.Controllers.Auth
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class AuthController : Controller
    {
        public IConfiguration _configuration;
        //private readonly IJwtService jwtService;

        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public ActionResult Index()
        {
            //var jwt = _configuration.GetSection("Jwt");
            //var claim = new[]
            //{
            //    new C
            //}
            //var key = jqe
            return Ok(true);
        }
    }
}
