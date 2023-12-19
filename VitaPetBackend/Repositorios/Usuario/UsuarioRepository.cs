using VitaPetBackend.DataAccess;
using VitaPetBackend.Dto.Usuario;
using VitaPetBackend.Mappers.Usuario;
using VitaPetBackend.Models.Usuario;
using VitaPetBackend.Repositorios.Repository;
using VitaPetBackend.Services.Usuario;

namespace VitaPetBackend.Repositorios.Usuario
{
    public class UsuarioRepository : GenericRepository<UsuarioModel>, IUsuarioRepository
    {
        public UsuarioRepository(DbVitaPetContext context) : base(context)
        {
        }        
    }
}
