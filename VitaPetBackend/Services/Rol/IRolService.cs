using VitaPetBackend.Dto.Rol;
using VitaPetBackend.Models.Rol;
using VitaPetBackend.Repositorios.Repository;

namespace VitaPetBackend.Services.Rol
{
    public interface IRolService
    {
        Task<IEnumerable<RolDto>> GetAll();
        Task<RolDto> GetById(int id);
        Task<bool> Create(RolCreateDto rol);
        Task<bool> Update(int id, RolDto rol);
        Task<bool> Delete(int id);
    }
}
