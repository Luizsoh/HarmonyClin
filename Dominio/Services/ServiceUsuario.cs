using Dominio.Interfaces.InterfaceServices;
using Dominio.Interfaces.InterfaceUsuario;
using Entidade.Entities;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Services
{
    public class ServiceUsuario : IServiceUsuario
    {
        private readonly IUsuario _IUsuario;

        public ServiceUsuario(IUsuario IUsuario)
        {
            _IUsuario = IUsuario;
        }

        public async Task AddUsuario(Usuario usuario)
        {
            var validaCPF = usuario.ValidaString(usuario.CPF, "CPF");
            var validaSenha = usuario.ValidaString(usuario.Senha, "Senha");

            if (validaCPF && validaSenha)
            {
                await _IUsuario.Add(usuario);
            }
        }

        public async Task UpdateUsuario(Usuario usuario)
        {
            var validaCPF = usuario.ValidaString(usuario.CPF, "CPF");
            var validaSenha = usuario.ValidaString(usuario.Senha, "Senha");

            if (validaCPF && validaSenha)
            {
                await _IUsuario.Add(usuario);
            }
        }

        public async Task<string> GenerateToken(Usuario usuario)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            string secret = Environment.GetEnvironmentVariable("ClientSecret");
            var key = Encoding.ASCII.GetBytes(secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, usuario.CPF),
                    new Claim(ClaimTypes.Role, "Adm")
                }),
                Expires = DateTime.UtcNow.AddMinutes(15),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);

        }

        public async Task<Usuario> RealizaLogin(string CPF, string senha)
        {
            return await _IUsuario.RealizaLogin(CPF, senha);
        }
    }
}
