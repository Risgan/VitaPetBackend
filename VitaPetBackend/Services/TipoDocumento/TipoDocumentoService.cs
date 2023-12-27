using VitaPetBackend.DataAccess;
using VitaPetBackend.Models.TipoDocumento;
using VitaPetBackend.Repositorios.Repository;

namespace VitaPetBackend.Services.TipoDocumento
{
    public class TipoDocumentoService : GenericRepository<TipoDocumentoModel>, ITipoDocumentoService
    {
        private readonly DbVitaPetContext _context;

        public TipoDocumentoService(DbVitaPetContext context) : base(context)
        {
            _context = context;
        }
    }
}
