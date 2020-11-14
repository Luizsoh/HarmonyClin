using Entidade.Entities;
using System.Threading.Tasks;

namespace Dominio.Interfaces.InterfaceServices
{
    public interface IServiceImagem
    {
        Task AddImagem(Imagem imagem);
        Task UpdateImagem(Imagem imagem);
    }
}
