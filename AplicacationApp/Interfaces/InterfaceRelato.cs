using Entidade.Entities;
using System.Threading.Tasks;

namespace AplicacationApp.Interfaces
{
    public interface InterfaceRelato : InterfaceGeneric<Relato>
    {
        Task AddRelato(Relato relato);
        Task UpdateRelato(Relato relato);
    }
}
