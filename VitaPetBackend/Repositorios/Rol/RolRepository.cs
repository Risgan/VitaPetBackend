using Microsoft.EntityFrameworkCore;
using VitaPetBackend.Dto.Rol;
using VitaPetBackend.Mappers.Rol;
using VitaPetBackend.Models.Rol;
using VitaPetBackend.Repositorios.Repository;
using VitaPetBackend.Services.Rol;

namespace VitaPetBackend.Repositorios.Rol
{
    public class RolRepository : GenericRepository<RolModel>, IRolRepository
    {
        public RolRepository(DbContext context) : base(context)
        {
        }
    }
}
