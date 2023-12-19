using VitaPetBackend.DataAccess;
using VitaPetBackend.Dto.TipoDocumento;
using VitaPetBackend.Mappers.TipoDocumento;
using VitaPetBackend.Models.TipoDocumento;
using VitaPetBackend.Repositorios.Repository;
using VitaPetBackend.Repositorios.TipoDocumento;

namespace VitaPetBackend.Services.TipoDocumento
{
    public class TipoDocumentoService :  ITipoDocumentoService
    {
        private readonly ITipoDocumentoRepository _tipoDocumentoRepository;

        public TipoDocumentoService(ITipoDocumentoRepository tipoDocumentoRepository)
        {
            _tipoDocumentoRepository = tipoDocumentoRepository;
        }

        public Task<bool> Create(TipoDocumentoCreateDto tipoDocumento)
        {
            return _tipoDocumentoRepository.Add(TipoDocumentoMapper.MapCreate(tipoDocumento));
        }

        public Task<bool> Delete(int id)
        {
            return _tipoDocumentoRepository.Delete(id);
        }

        public async Task<IEnumerable<TipoDocumentoDto>> GetAll()
        {
            return TipoDocumentoMapper.MapResponse(await _tipoDocumentoRepository.GetAll());
        }

        public async Task<TipoDocumentoDto> GetById(int id)
        {
            return TipoDocumentoMapper.MapResponse(await _tipoDocumentoRepository.Get(id));
        }

        public Task<bool> Update(int id, TipoDocumentoDto tipoDocumento)
        {
            return _tipoDocumentoRepository.Update(id, TipoDocumentoMapper.MapResponse(tipoDocumento));
        }

    }
}
