using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VitaPetBackend.Repositorios.Usuario;
using VitaPetBackend.Services.Usuario;

namespace VitaPetBackend.Controllers.Usuario
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                return Ok(await _usuarioService.GetAll());
            }
            catch (Exception ex)
            {

                return BadRequest(new { mensaje = "La solicitud fue rechazada debido a datos incorrectos." + ex.Message });

            }            
        }

        [HttpGet("id")]
        public async Task<ActionResult> GetById(int id)
        {
            try
            {
                if (id != 0)
                {
                    return Ok(await _usuarioService.GetById(id));

                }
                else
                {
                    return NoContent();
                }
            }
            catch (Exception ex)
            {

                return BadRequest(new { mensaje = "La solicitud fue rechazada debido a datos incorrectos." + ex.Message });

            }
            
        }

        [HttpPost]
        public async Task<ActionResult> PostUsuario([FromBody]  int id)
        {
            return Ok(true);
        }

        [HttpPut]
        public async Task<ActionResult> PutUsuario([FromBody] int id)
        {
            return Ok(true);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteUsuario(int id)
        {
            return Ok(true);
        }
    }
}
