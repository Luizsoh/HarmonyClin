using Dominio.Interfaces.InterfaceImagens;
using Dominio.Interfaces.InterfaceServices;
using Entidade.Entities;
using System;
using System.Threading.Tasks;

namespace Dominio.Services
{
    public class ServiceImagens : IServiceImagem
    {
        private readonly IImagem _IImagens;

        public ServiceImagens(IImagem IImagens)
        {
            _IImagens = IImagens;
        }

        public Task AddImagem(Imagem imagem)
        {
            throw new NotImplementedException();
        }

        public Task UpdateImagem(Imagem imagem)
        {
            throw new NotImplementedException();
        }
    }
}
