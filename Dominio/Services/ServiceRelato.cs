using Dominio.Interfaces.InterfaceRelatos;
using Dominio.Interfaces.InterfaceServices;
using Entidade.Entities;
using System;
using System.Threading.Tasks;

namespace Dominio.Services
{
    public class ServiceRelato : IServiceRelato
    {
        private readonly IRelatos _IRelato;

        public ServiceRelato(IRelatos IRelato)
        {
            _IRelato = IRelato;
        }
        public Task AddRelato(Relatos relato)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRelato(Relatos relato)
        {
            throw new NotImplementedException();
        }
    }
}
