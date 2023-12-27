using VitaPetBackend.Dto.Usuario;
using VitaPetBackend.Models.Usuario;

namespace VitaPetBackend.Repositorios.Usuario
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<UsuarioDto>> GetAll();
        Task<UsuarioDto> GetById(int id);
        Task<bool> Create(UsuarioCreateDto usuario);
        Task<bool> Update(int id, UsuarioDto usuario);
        Task<bool> Delete(int id);
    }
}
