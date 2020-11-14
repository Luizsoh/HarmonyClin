using Entidade.Entities;
using System.Threading.Tasks;

namespace Dominio.Interfaces.InterfaceServices
{
    interface IServiceRelato
    {
        Task AddRelato(Relatos relato);
        Task UpdateRelato(Relatos relato);
    }
}
