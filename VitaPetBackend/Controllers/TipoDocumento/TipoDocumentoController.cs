using Microsoft.AspNetCore.Mvc;
using VitaPetBackend.Dto.TipoDocumento;
using VitaPetBackend.Repositorios.TipoDocumento;
using VitaPetBackend.Services.TipoDocumento;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VitaPetBackend.Controllers.TipoDocumento
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoDocumentoController : Controller
    {
        private readonly ITipoDocumentoService _tipoDocumentoService;
        public TipoDocumentoController(ITipoDocumentoService tipoDocumentoService)
        {
            _tipoDocumentoService = tipoDocumentoService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                return Ok(await _tipoDocumentoService.GetAll());
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
                    return Ok(await _tipoDocumentoService.GetById(id));

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
                return Ok(await _tipoDocumentoService.Create(data));
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
                return Ok(await _tipoDocumentoService.Update(id, data));
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
                return Ok(await _tipoDocumentoService.Delete(id));
            }
            catch (Exception ex)
            {

                return BadRequest(new { mensaje = "La solicitud fue rechazada debido a datos incorrectos." + ex.Message });
            }
        }
    }
}
