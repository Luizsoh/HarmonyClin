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

        public async Task AddArtigo(Artigo artigo)
        {
            var validaConteudo = artigo.ValidaString(artigo.Conteudo, "Conteudo");
            var validaCategoria = artigo.ValidaInt(artigo.Categoria, "Categoria");

            if (validaCategoria && validaConteudo)
            {
                await _IArtigo.Add(artigo);
            }
        }

        public async Task UpdateArtigo(Artigo artigo)
        {
            var validaConteudo = artigo.ValidaString(artigo.Conteudo, "Conteudo");
            var validaCategoria = artigo.ValidaInt(artigo.Categoria, "Categoria");

            if (validaCategoria && validaConteudo)
            {
                await _IArtigo.Update(artigo);
            }
        }
    }
}
