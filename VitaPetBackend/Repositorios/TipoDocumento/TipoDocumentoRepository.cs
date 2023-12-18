using VitaPetBackend.Dto.TipoDocumento;
using VitaPetBackend.Mappers.TipoDocumento;
using VitaPetBackend.Services.TipoDocumento;

namespace VitaPetBackend.Repositorios.TipoDocumento
{
    public class TipoDocumentoRepository : ITipoDocumentoRepository
    {
        private readonly ITipoDocumentoService _tipoDocumentoService;

        public TipoDocumentoRepository(ITipoDocumentoService tipoDocumentoService)
        {
            _tipoDocumentoService = tipoDocumentoService;
        }

        public Task<bool> Create(TipoDocumentoCreateDto tipoDocumento)
        {
            return _tipoDocumentoService.Add(TipoDocumentoMapper.MapCreate(tipoDocumento));
        }

        public Task<bool> Delete(int id)
        {
            return _tipoDocumentoService.Delete(id);
        }

        public async Task<IEnumerable<TipoDocumentoDto>> GetAll()
        {
            return TipoDocumentoMapper.MapResponse(await _tipoDocumentoService.GetAll());
        }

        public async Task<TipoDocumentoDto> GetById(int id)
        {
            return TipoDocumentoMapper.MapResponse(await _tipoDocumentoService.Get(id));
        }

        public Task<bool> Update(int id, TipoDocumentoDto tipoDocumento)
        {
            return _tipoDocumentoService.Update(id, TipoDocumentoMapper.MapResponse(tipoDocumento));
        }
    }
}
