using Dominio.Interfaces.Generics;
using Entidade.Entities;
using System.Threading.Tasks;

namespace Dominio.Interfaces.InterfaceUsuario
{
    public interface IUsuario : IGeneric<Usuario>
    {
        Task<Usuario> RealizaLogin(string CPF, string Senha);
    }
}
