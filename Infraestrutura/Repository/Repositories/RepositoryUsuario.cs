using Dominio.Interfaces.InterfaceUsuario;
using Entidade.Entities;
using Infraestrutura.Configuration;
using Infraestrutura.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Repository.Repositories
{
    public class RepositoryUsuario : RepositoryGenerics<Usuario>, IUsuario
    {
        private readonly DbContextOptions<ContextBase> _optionsBuilder;

        public RepositoryUsuario()
        {
            _optionsBuilder = new DbContextOptions<ContextBase>();
        }

        public async Task<Usuario> RealizaLogin(string CPF, string Senha)
        {
            using(var contexto = new ContextBase(_optionsBuilder))
            {
                var retorno = await contexto.Usuario.Where(x => x.CPF.ToLower() == CPF.ToLower() && x.Senha.ToLower() == Senha.ToLower()).FirstOrDefaultAsync();

                return retorno;
            }
        }
    }
}
