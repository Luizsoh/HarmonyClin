using System.Collections.Generic;
using System.Threading.Tasks;

namespace AplicacationApp.Interfaces
{
    public interface InterfaceGeneric<T> where T : class
    {
        Task Add(T objeto);
        Task Update(T objeto);
        Task Delete(T objeto);
        Task<T> GetEntityById(int id);
        Task<List<T>> List();
    }
}
