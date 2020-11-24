using AplicacationApp.Interfaces;
using Dominio.Interfaces.InterfaceUsuario;
using Dominio.Interfaces.InterfaceServices;
using Entidade.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AplicacationApp.OpenApp
{
    public class AppUsuario : InterfaceUsuario
    {
        IUsuario _IUsuario;
        IServiceUsuario _IServiceUsuario;

        public AppUsuario(IUsuario IUsuario, IServiceUsuario IServiceUsuario)
        {
            _IUsuario = IUsuario;
            _IServiceUsuario = IServiceUsuario;
        }

        #region Customizados
        public async Task UpdateUsuario(Usuario Usuario)
        {
            await _IServiceUsuario.UpdateUsuario(Usuario);
        }
        public async Task AddUsuario(Usuario Usuario)
        {
            await _IServiceUsuario.AddUsuario(Usuario);
        }

        public async Task<string> GenerateToken(Usuario usuario)
        {
            return await _IServiceUsuario.GenerateToken(usuario);

        }

        public async Task<Usuario> RealizaLogin(string CPF, string Senha)
        {
            return await _IServiceUsuario.RealizaLogin(CPF, Senha);
        }
        #endregion

        #region Generics
        public async Task Add(Usuario objeto)
        {
            await _IUsuario.Add(objeto);
        }

        public async Task Delete(Usuario objeto)
        {
            await _IUsuario.Delete(objeto);
        }

        public async Task Update(Usuario objeto)
        {
            await _IUsuario.Update(objeto);
        }

        public async Task<Usuario> GetEntityById(int id)
        {
            return await _IUsuario.GetEntityById(id);
        }

        public async Task<List<Usuario>> List()
        {
            return await _IUsuario.List();
        }
        #endregion
    }
}
