using VitaPetBackend.Dto.Usuario;
using VitaPetBackend.Mappers.Usuario;
using VitaPetBackend.Models.Usuario;
using VitaPetBackend.Services.Usuario;

namespace VitaPetBackend.Repositorios.Usuario
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioRepository(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public Task<bool> Create(UsuarioCreateDto usuario)
        {
            return _usuarioService.Add(UsuarioMapper.MapCreate(usuario));
        }

        public Task<bool> Delete(int id)
        {
            return _usuarioService.Delete(id);
        }

        public async Task<IEnumerable<UsuarioDto>> GetAll()
        {
            return UsuarioMapper.MapResponse(await _usuarioService.GetAll());
        }

        public async Task<UsuarioDto> GetById(int id)
        {
            return UsuarioMapper.MapResponse(await _usuarioService.Get(id));
        }

        public Task<bool> Update(int id, UsuarioDto usuario)
        {
            return _usuarioService.Update(id, UsuarioMapper.MapResponse(usuario));
        }
    }
}
