using Dominio.Interfaces.InterfaceImagens;
using Entidade.Entities;
using Infraestrutura.Repository.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Repository.Repositories
{
    public class RepositoryImagem : RepositoryGenerics<Imagem>, IImagem
    {
    }
}
