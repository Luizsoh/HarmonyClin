using AplicacationApp.Interfaces;
using Dominio.Interfaces.InterfaceRelatos;
using Dominio.Interfaces.InterfaceServices;
using Entidade.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AplicacationApp.OpenApp
{
    public class AppRelato : InterfaceRelato
    {
        IRelato _IRelato;
        IServiceRelato _IServiceRelato;

        public AppRelato(IRelato IRelato, IServiceRelato IServiceRelato)
        {
            _IRelato = IRelato;
            _IServiceRelato = IServiceRelato;
        }

        #region Customizados
        public async Task UpdateRelato(Relato relato)
        {
            await _IServiceRelato.UpdateRelato(relato);
        }
        public async Task AddRelato(Relato relato)
        {
            await _IServiceRelato.AddRelato(relato);
        }
        #endregion

        #region Generics
        public async Task Add(Relato objeto)
        {
            await _IRelato.Add(objeto);
        }

        public async Task Delete(Relato objeto)
        {
            await _IRelato.Delete(objeto);
        }

        public async Task Update(Relato objeto)
        {
            await _IRelato.Update(objeto);
        }

        public async Task<Relato> GetEntityById(int id)
        {
            return await _IRelato.GetEntityById(id);
        }

        public async Task<List<Relato>> List()
        {
            return await _IRelato.List();
        }
        #endregion
    }
}
