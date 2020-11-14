using Entidade.Entities;
using System.Threading.Tasks;

namespace Dominio.Interfaces.InterfaceServices
{
    interface IServiceArtigo
    {
        Task AddArtigo(Artigo artigo);
        Task UpdateArtigo(Artigo artigo);
    }
}
