using AplicacationApp.Interfaces;
using Dominio.Interfaces.InterfaceImagens;
using Dominio.Interfaces.InterfaceServices;
using Entidade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacationApp.OpenApp
{
    public class AppImagem : InterfaceImagem
    {
        IImagem _IImagem;
        IServiceImagem _IServiceImagem;

        public AppImagem(IImagem IImagem, IServiceImagem IServiceImagem)
        {
            _IImagem = IImagem;
            _IServiceImagem = IServiceImagem;
        }

        #region Customizados
        public async Task AddImagem(Imagem imagem)
        {
            await _IServiceImagem.AddImagem(imagem);
        }

        public async Task UpdateImagem(Imagem imagem)
        {
            await _IServiceImagem.UpdateImagem(imagem);
        }
        #endregion

        #region Generics
        public async Task Add(Imagem objeto)
        {
            await _IImagem.Add(objeto);
        }

        public async Task Update(Imagem objeto)
        {
            await _IImagem.Update(objeto);
        }

        public async Task Delete(Imagem objeto)
        {
            await _IImagem.Delete(objeto);
        }

        public  async Task<Imagem> GetEntityById(int id)
        {
            return await _IImagem.GetEntityById(id);
        }

        public async Task<List<Imagem>> List()
        {
            return await _IImagem.List();
        }
        #endregion
    }
}
