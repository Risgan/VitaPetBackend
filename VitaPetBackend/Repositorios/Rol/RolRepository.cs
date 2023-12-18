using VitaPetBackend.Dto.Rol;
using VitaPetBackend.Mappers.Rol;
using VitaPetBackend.Services.Rol;

namespace VitaPetBackend.Repositorios.Rol
{
    public class RolRepository : IRolRepository
    {
        private readonly IRolService _rolService;

        public RolRepository(IRolService rolService)
        {
            _rolService = rolService;
        }

        public Task<bool> Create(RolCreateDto rol)
        {
            return _rolService.Add(RolMapper.MapCreate(rol));
        }

        public Task<bool> Delete(int id)
        {
            return _rolService.Delete(id);
        }

        public async Task<IEnumerable<RolDto>> GetAll()
        {
            return RolMapper.MapResponse(await _rolService.GetAll());
        }

        public async Task<RolDto> GetById(int id)
        {
            return RolMapper.MapResponse(await _rolService.Get(id));
        }

        public Task<bool> Update(int id, RolDto rol)
        {
            return _rolService.Update(id, RolMapper.MapResponse(rol));
        }
    }
}
