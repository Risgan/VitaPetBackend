using Microsoft.AspNetCore.Mvc;
using VitaPetBackend.Dto.Rol;
using VitaPetBackend.Repositorios.Rol;

namespace VitaPetBackend.Controllers.Rol
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolController : Controller
    {
        private readonly IRolRepository _repository;

        public RolController(IRolRepository rolRepository)
        {
            _repository = rolRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                return Ok(await _repository.GetAll());
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
                    return Ok(await _repository.GetById(id));

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
        public async Task<ActionResult> PostUsuario([FromBody] RolCreateDto data)
        {
            try
            {
                return Ok(await _repository.Create(data));
            }
            catch (Exception ex)
            {

                return BadRequest(new { mensaje = "La solicitud fue rechazada debido a datos incorrectos." + ex.Message });
            }
        }

        [HttpPut("id")]
        public async Task<ActionResult> PutUsuario(int id, [FromBody] RolDto data)
        {
            try
            {
                return Ok(await _repository.Update(id, data));
            }
            catch (Exception ex)
            {

                return BadRequest(new { mensaje = "La solicitud fue rechazada debido a datos incorrectos." + ex.Message });
            }
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteUsuario(int id)
        {
            try
            {
                return Ok(await _repository.Delete(id));
            }
            catch (Exception ex)
            {

                return BadRequest(new { mensaje = "La solicitud fue rechazada debido a datos incorrectos." + ex.Message });
            }
        }
    }
}
