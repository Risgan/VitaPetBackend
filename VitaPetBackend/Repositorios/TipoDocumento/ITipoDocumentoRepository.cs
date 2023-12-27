using VitaPetBackend.Dto.TipoDocumento;

namespace VitaPetBackend.Repositorios.TipoDocumento
{
    public interface ITipoDocumentoRepository
    {
        Task<IEnumerable<TipoDocumentoDto>> GetAll();
        Task<TipoDocumentoDto> GetById(int id);
        Task<bool> Create(TipoDocumentoCreateDto tipoDocumento);
        Task<bool> Update(int id, TipoDocumentoDto tipoDocumento);
        Task<bool> Delete(int id);
    }
}
