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

        public async Task AddRelato(Relato relato)
        {
            var validaDepoimento = relato.ValidaString(relato.Depoimento, "Depoimento");

            if (validaDepoimento)
            {
                await _IRelato.Add(relato);
            }
        }

        public async Task UpdateRelato(Relato relato)
        {
            var validaDepoimento = relato.ValidaString(relato.Depoimento, "Depoimento");

            if (validaDepoimento)
            {
                await _IRelato.Update(relato);
            }
        }
    }
}
