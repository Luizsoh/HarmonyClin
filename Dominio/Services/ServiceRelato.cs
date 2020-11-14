using Dominio.Interfaces.InterfaceRelatos;
using Dominio.Interfaces.InterfaceServices;
using Entidade.Entities;
using System;
using System.Threading.Tasks;

namespace Dominio.Services
{
    public class ServiceRelato : IServiceRelato
    {
        private readonly IRelato _IRelato;

        public ServiceRelato(IRelato IRelato)
        {
            _IRelato = IRelato;
        }
        public Task AddRelato(Relato relato)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRelato(Relato relato)
        {
            throw new NotImplementedException();
        }
    }
}
