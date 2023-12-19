using VitaPetBackend.Dto.Usuario;
using VitaPetBackend.Models.Usuario;
using VitaPetBackend.Repositorios.Repository;

namespace VitaPetBackend.Services.Usuario
{
    public interface IUsuarioService
    {
        Task<IEnumerable<UsuarioDto>> GetAll();
        Task<UsuarioDto> GetById(int id);
        Task<bool> Create(UsuarioCreateDto usuario);
        Task<bool> Update(int id, UsuarioDto usuario);
        Task<bool> Delete(int id);
    }
}
