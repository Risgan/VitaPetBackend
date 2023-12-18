using VitaPetBackend.Dto.Rol;

namespace VitaPetBackend.Repositorios.Rol
{
    public interface IRolRepository
    {
        Task<IEnumerable<RolDto>> GetAll();
        Task<RolDto> GetById(int id);
        Task<bool> Create(RolCreateDto rol);
        Task<bool> Update(int id, RolDto rol);
        Task<bool> Delete(int id);
    }
}
