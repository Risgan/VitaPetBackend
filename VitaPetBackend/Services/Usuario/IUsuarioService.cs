using VitaPetBackend.Models.Usuario;
using VitaPetBackend.Repositorios.Repository;

namespace VitaPetBackend.Services.Usuario
{
    public interface IUsuarioService : IRepository<UsuarioModel>
    {
    }
}
