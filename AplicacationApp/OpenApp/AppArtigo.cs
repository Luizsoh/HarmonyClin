using AplicacationApp.Interfaces;
using Dominio.Interfaces.InterfaceArtigo;
using Dominio.Interfaces.InterfaceServices;
using Entidade.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AplicacationApp.OpenApp
{
    public class AppArtigo : InterfaceArtigo
    {
        IArtigo _IArtigo;
        IServiceArtigo _IServiceArtigo;

        public AppArtigo(IArtigo IArtigo, IServiceArtigo IServiceArtigo)
        {
            _IArtigo = IArtigo;
            _IServiceArtigo = IServiceArtigo;
        }

        #region Customizados
        public async Task UpdateArtigo(Artigo artigo)
        {
            await _IServiceArtigo.UpdateArtigo(artigo);
        }
        public async Task AddArtigo(Artigo artigo)
        {
            await _IServiceArtigo.AddArtigo(artigo);
        }
        #endregion

        #region Generics
        public async Task Add(Artigo objeto)
        {
            await _IArtigo.Add(objeto);
        }

        public async Task Delete(Artigo objeto)
        {
            await _IArtigo.Delete(objeto);
        }

        public async Task Update(Artigo objeto)
        {
            await _IArtigo.Update(objeto);
        }

        public async Task<Artigo> GetEntityById(int id)
        {
            return await _IArtigo.GetEntityById(id);
        }

        public async Task<List<Artigo>> List()
        {
            return await _IArtigo.List();
        }
        #endregion
    }
}
