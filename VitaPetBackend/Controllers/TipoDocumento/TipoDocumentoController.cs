using Microsoft.AspNetCore.Mvc;
using VitaPetBackend.Dto.TipoDocumento;
using VitaPetBackend.Repositorios.TipoDocumento;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VitaPetBackend.Controllers.TipoDocumento
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoDocumentoController : Controller
    {
        private readonly ITipoDocumentoRepository _tipoDocumentoRespository;
        public TipoDocumentoController(ITipoDocumentoRepository tipoDocumentoRespository)
        {
            _tipoDocumentoRespository = tipoDocumentoRespository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                return Ok(await _tipoDocumentoRespository.GetAll());
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
                    return Ok(await _tipoDocumentoRespository.GetById(id));

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
        public async Task<ActionResult> PostUsuario([FromBody] TipoDocumentoCreateDto data)
        {
            try
            {
                return Ok(await _tipoDocumentoRespository.Create(data));
            }
            catch (Exception ex)
            {

                return BadRequest(new { mensaje = "La solicitud fue rechazada debido a datos incorrectos." + ex.Message });
            }
        }

        [HttpPut("id")]
        public async Task<ActionResult> PutUsuario(int id, [FromBody] TipoDocumentoDto data)
        {
            try
            {
                return Ok(await _tipoDocumentoRespository.Update(id, data));
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
                return Ok(await _tipoDocumentoRespository.Delete(id));
            }
            catch (Exception ex)
            {

                return BadRequest(new { mensaje = "La solicitud fue rechazada debido a datos incorrectos." + ex.Message });
            }
        }
    }
}
