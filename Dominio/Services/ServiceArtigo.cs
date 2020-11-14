using Dominio.Interfaces.InterfaceArtigo;
using Dominio.Interfaces.InterfaceServices;
using Entidade.Entities;
using System;
using System.Threading.Tasks;

namespace Dominio.Services
{
    public class ServiceArtigo : IServiceArtigo
    {
        private readonly IArtigo _IArtigo;

        public ServiceArtigo(IArtigo IArtigo)
        {
            _IArtigo = IArtigo;
        }

        public Task AddArtigo(Artigo artigo)
        {
            throw new NotImplementedException();
        }

        public Task UpdateArtigo(Artigo artigo)
        {
            throw new NotImplementedException();
        }
    }
}
