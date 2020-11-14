using Entidade.Entities;
using System.Threading.Tasks;

namespace Dominio.Interfaces.InterfaceServices
{
    interface IServiceImagens
    {
        Task AddImagem(Imagens imagem);
        Task UpdateImagem(Imagens imagem);
    }
}
