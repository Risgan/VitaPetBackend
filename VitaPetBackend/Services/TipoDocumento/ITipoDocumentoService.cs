using VitaPetBackend.Dto.TipoDocumento;
using VitaPetBackend.Models.TipoDocumento;
using VitaPetBackend.Repositorios.Repository;

namespace VitaPetBackend.Services.TipoDocumento
{
    public interface ITipoDocumentoService
    {
        Task<IEnumerable<TipoDocumentoDto>> GetAll();
        Task<TipoDocumentoDto> GetById(int id);
        Task<bool> Create(TipoDocumentoCreateDto tipoDocumento);
        Task<bool> Update(int id, TipoDocumentoDto tipoDocumento);
        Task<bool> Delete(int id);
    }
}
