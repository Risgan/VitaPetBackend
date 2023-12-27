using Microsoft.EntityFrameworkCore;
using VitaPetBackend.DataAccess;
using VitaPetBackend.Models.Usuario;
using VitaPetBackend.Repositorios.Repository;

namespace VitaPetBackend.Services.Usuario
{
    public class UsuarioService : GenericRepository<UsuarioModel>, IUsuarioService
    {
        private readonly DbVitaPetContext _context;

        public UsuarioService(DbVitaPetContext context) : base(context)
        {
            _context = context;
        }
    }
}
