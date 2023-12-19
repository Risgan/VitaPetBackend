using Microsoft.EntityFrameworkCore;
using VitaPetBackend.Dto.Rol;
using VitaPetBackend.Mappers.Rol;
using VitaPetBackend.Models.Rol;
using VitaPetBackend.Repositorios.Repository;
using VitaPetBackend.Repositorios.Rol;

namespace VitaPetBackend.Services.Rol
{
    public class RolService :  IRolService
    {   
        private readonly IRolRepository _rolRepository;

        public RolService(IRolRepository rolRepository)
        {
            _rolRepository = rolRepository;
        }

        public Task<bool> Create(RolCreateDto rol)
        {
            return _rolRepository.Add(RolMapper.MapCreate(rol));
        }

        public Task<bool> Delete(int id)
        {
            return _rolRepository.Delete(id);
        }

        public async Task<IEnumerable<RolDto>> GetAll()
        {
            return RolMapper.MapResponse(await _rolRepository.GetAll());
        }

        public async Task<RolDto> GetById(int id)
        {
            return RolMapper.MapResponse(await _rolRepository.Get(id));
        }

        public Task<bool> Update(int id, RolDto rol)
        {
            return _rolRepository.Update(id, RolMapper.MapResponse(rol));
        }
    }
}
