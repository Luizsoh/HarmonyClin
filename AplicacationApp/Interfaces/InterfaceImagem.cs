using Entidade.Entities;
using System.Threading.Tasks;

namespace AplicacationApp.Interfaces
{
    public interface InterfaceImagem : InterfaceGeneric<Imagem>
    {
        Task AddImagem(Imagem imagem);
        Task UpdateImagem(Imagem imagem);
    }
}
