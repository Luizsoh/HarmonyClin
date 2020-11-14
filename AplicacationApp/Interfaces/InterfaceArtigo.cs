using Entidade.Entities;
using System.Threading.Tasks;

namespace AplicacationApp.Interfaces
{
    public interface InterfaceArtigo : InterfaceGeneric<Artigo>
    {
        Task AddArtigo(Artigo artigo);
        Task UpdateArtigo(Artigo artigo);
    }
}
