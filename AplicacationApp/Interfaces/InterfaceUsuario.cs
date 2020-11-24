using Entidade.Entities;
using System.Threading.Tasks;

namespace AplicacationApp.Interfaces
{
    public interface InterfaceUsuario : InterfaceGeneric<Usuario>
    {
        Task AddUsuario(Usuario usuario);
        Task UpdateUsuario(Usuario usuario);
        Task<string> GenerateToken(Usuario usuario);
        Task<Usuario> RealizaLogin(string CPF, string Senha);
    }
}
