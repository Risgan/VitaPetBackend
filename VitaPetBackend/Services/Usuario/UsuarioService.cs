using Microsoft.EntityFrameworkCore;
using VitaPetBackend.DataAccess;
using VitaPetBackend.Dto.Usuario;
using VitaPetBackend.Mappers.Usuario;
using VitaPetBackend.Models.Usuario;
using VitaPetBackend.Repositorios.Repository;
using VitaPetBackend.Repositorios.Usuario;

namespace VitaPetBackend.Services.Usuario
{
    public class UsuarioService :  IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Task<bool> Create(UsuarioCreateDto usuario)
        {
            return _usuarioRepository.Add(UsuarioMapper.MapCreate(usuario));
        }

        public Task<bool> Delete(int id)
        {
            return _usuarioRepository.Delete(id);
        }

        public async Task<IEnumerable<UsuarioDto>> GetAll()
        {
            return UsuarioMapper.MapResponse(await _usuarioRepository.GetAll());
        }

        public async Task<UsuarioDto> GetById(int id)
        {
            return UsuarioMapper.MapResponse(await _usuarioRepository.Get(id));
        }

        public Task<bool> Update(int id, UsuarioDto usuario)
        {
            return _usuarioRepository.Update(id, UsuarioMapper.MapResponse(usuario));
        }
    }
}
