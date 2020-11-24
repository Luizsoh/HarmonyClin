using Entidade.Entities;
using System.Threading.Tasks;

namespace Dominio.Interfaces.InterfaceServices
{
    public interface IServiceUsuario
    {
        Task AddUsuario(Usuario usuario);
        Task UpdateUsuario(Usuario usuario);
        Task<string> GenerateToken(Usuario usuario);
        Task<Usuario> RealizaLogin(string CPF, string Senha);
    }
}
