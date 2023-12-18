using Microsoft.EntityFrameworkCore;
using VitaPetBackend.Models.Rol;
using VitaPetBackend.Repositorios.Repository;

namespace VitaPetBackend.Services.Rol
{
    public class RolService : GenericRepository<RolModel>, IRolService
    {
        public RolService(DbContext context) : base(context)
        {
        }
    }
}
