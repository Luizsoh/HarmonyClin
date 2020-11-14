using Dominio.Interfaces.InterfaceArtigo;
using Entidade.Entities;
using Infraestrutura.Repository.Generics;

namespace Infraestrutura.Repository.Repositories
{
    public class RepositoryArtigo : RepositoryGenerics<Artigo>, IArtigo
    {
    }
}
