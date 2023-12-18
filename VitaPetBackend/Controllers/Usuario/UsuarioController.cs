using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VitaPetBackend.Repositorios.Usuario;

namespace VitaPetBackend.Controllers.Usuario
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                return Ok(await _usuarioRepository.GetAll());
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
                    return Ok(await _usuarioRepository.GetById(id));

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
