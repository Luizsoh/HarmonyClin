using Dominio.Interfaces.InterfaceImagens;
using Dominio.Interfaces.InterfaceServices;
using Entidade.Entities;
using System;
using System.Threading.Tasks;

namespace Dominio.Services
{
    public class ServiceImagens : IServiceImagens
    {
        private readonly IImagens _IImagens;

        public ServiceImagens(IImagens IImagens)
        {
            _IImagens = IImagens;
        }

        public Task AddImagem(Imagens imagem)
        {
            throw new NotImplementedException();
        }

        public Task UpdateImagem(Imagens imagem)
        {
            throw new NotImplementedException();
        }
    }
}
