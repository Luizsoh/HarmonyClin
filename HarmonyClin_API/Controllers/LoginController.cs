using AplicacationApp.Interfaces;
using Entidade.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HarmonyClin_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        public readonly InterfaceUsuario _InterfaceUsuario;

        public LoginController(InterfaceUsuario interfaceUsuario)
        {
            _InterfaceUsuario = interfaceUsuario;
        }

        [HttpPost]
        [Route("LoginAdm")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Login([FromBody]Usuario usuario)
        {
            var user = await _InterfaceUsuario.RealizaLogin(usuario.CPF, usuario.Senha);

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = _InterfaceUsuario.GenerateToken(user);

            return new
            {
                token = token.Result
            };
        }

    }
}
