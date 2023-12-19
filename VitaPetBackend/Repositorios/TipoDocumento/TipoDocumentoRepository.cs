using VitaPetBackend.DataAccess;
using VitaPetBackend.Dto.TipoDocumento;
using VitaPetBackend.Mappers.TipoDocumento;
using VitaPetBackend.Models.TipoDocumento;
using VitaPetBackend.Repositorios.Repository;
using VitaPetBackend.Services.TipoDocumento;

namespace VitaPetBackend.Repositorios.TipoDocumento
{
    public class TipoDocumentoRepository : GenericRepository<TipoDocumentoModel>, ITipoDocumentoRepository
    {
        public TipoDocumentoRepository(DbVitaPetContext context) : base(context)
        {
        }        
    }
}
