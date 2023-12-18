using Microsoft.EntityFrameworkCore;
using VitaPetBackend.Models.Rol;
using VitaPetBackend.Models.TipoDocumento;
using VitaPetBackend.Models.Usuario;

namespace VitaPetBackend.DataAccess
{
    public class DbVitaPetContext : DbContext
    {
        public DbVitaPetContext(DbContextOptions<DbVitaPetContext> options) : base(options)
        {
            
        }

        public DbSet<UsuarioModel> UsuarioModel { get; set; }
        public DbSet<TipoDocumentoModel> TipoDocumentoModel { get; set; }
        public DbSet<RolModel> RolModel { get; set; }

    }
}
