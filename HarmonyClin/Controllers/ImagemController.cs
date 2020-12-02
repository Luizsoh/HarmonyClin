using AplicacationApp.Interfaces;
using Entidade.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HarmonyClin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagemController : ControllerBase
    {
        public readonly InterfaceImagem _InterfaceImagem;

        public ImagemController(InterfaceImagem interfaceImagem)
        {
            _InterfaceImagem = interfaceImagem;
        }

        // GET: Imagens
        [HttpGet]
        [Route("ListarImagens")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> ListarImagens()
        {
            var imagens = await _InterfaceImagem.List();

            if (imagens != null)
            {

                foreach (var imagem in imagens)
                {
                    if (Debugger.IsAttached)
                        imagem.FilePath = "localhost:44335" + imagem.FilePath;
                    else
                        imagem.FilePath = "localhost:44335" + imagem.FilePath; //ATUALIZAR PARA LINK DO SITE
                }

                return new(imagens);
            }
            else
            {
                return NoContent();
            }
        }

        // GET: Imagens/Details/5
        [HttpGet]
        [Route("DetalharImagem/{id}")]
        [Authorize]
        public async Task<ActionResult<dynamic>> DetalharImagem(int id)
        {
            var imagem = await _InterfaceImagem.GetEntityById(id);

            if (imagem != null)
            {
                if (Debugger.IsAttached)
                    imagem.FilePath = "localhost:44335" + imagem.FilePath;
                else
                    imagem.FilePath = "localhost:44335" + imagem.FilePath; //ATUALIZAR PARA LINK DO SITE

                return new(imagem);
            }
            else
            {
                return NotFound(new { message = "Imagem não encontrada" });
            }
        }


        // POST: Imagens/Create
        [HttpPost]
        [Route("CadastrarImagem")]
        [Authorize]
        public async Task<ActionResult<dynamic>> CadastrarImagem([FromBody]Imagem imagem)
        {
            try
            {
                //TODO Montar logica para salvar arquivo, ao preencher o filepath colocar apenas o caminho onde a pasta foi salvo sem o localhost ou endereço do site
                if (Request.Form.Files.Count > 0)
                {
                    var files = Request.Form.Files[0];

                    using (var ms = new MemoryStream())
                    {
                        files.CopyTo(ms);
                        var fileBytes = ms.ToArray();

                        imagem.FileName = files.FileName;

                        await _InterfaceImagem.AddImagem(imagem);

                        if (imagem.ListNotifies.Any())
                        {
                            foreach (var erro in imagem.ListNotifies)
                            {
                                ModelState.AddModelError(erro.NomePropriedade, erro.Mensagem);
                            }
                            return BadRequest(ModelState);
                        }
                        return Ok();
                    }
                }
                else
                    return BadRequest();
            }
            catch
            {
                return StatusCode(500, "Erro ao salvar imagem");
            }
        }

        // POST: Imagens/Edit/5
        [HttpPost]
        [Route("EditarImagem")]
        [Authorize]
        public async Task<ActionResult<dynamic>> Edit([FromBody]Imagem imagem)
        {
            try
            {
                //TODO Montar logica para excluir arquivo antigo e salvar novo arquivo
                if (Request.Form.Files.Count > 0)
                {
                    var files = Request.Form.Files[0];

                    using (var ms = new MemoryStream())
                    {
                        files.CopyTo(ms);
                        var fileBytes = ms.ToArray();

                        imagem.FileName = files.FileName;

                        await _InterfaceImagem.UpdateImagem(imagem);

                        if (imagem.ListNotifies.Any())
                        {
                            foreach (var erro in imagem.ListNotifies)
                            {
                                ModelState.AddModelError(erro.NomePropriedade, erro.Mensagem);
                            }
                            return BadRequest(ModelState);
                        }
                        return Ok();
                    }
                }
                else
                {
                    await _InterfaceImagem.UpdateImagem(imagem);
                    return Ok();
                }
            }
            catch
            {
                return StatusCode(500, "Erro ao salvar imagem");
            }
        }

        [HttpPost]
        [Route("RemoverImagem/{id}")]
        [Authorize]
        public async Task<ActionResult<dynamic>> RemoverImagem(int id)
        {
            try
            {
                var imagem = await _InterfaceImagem.GetEntityById(id);

                //TODO encontrar a imagem no fileSystem e remove-la

                await _InterfaceImagem.Delete(imagem);
                return Ok();
            }
            catch
            {
                return StatusCode(500, "Erro ao salvar imagem");
            }

        }
    }
}
