using AplicacationApp.Interfaces;
using Entidade.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarmonyClin.Controllers
{
    public class ImagensController : Controller
    {
        public readonly InterfaceImagem _InterfaceImagem;

        public ImagensController(InterfaceImagem interfaceImagem)
        {
            _InterfaceImagem = interfaceImagem;
        }

        // GET: Imagens
        public async Task<IActionResult> Index()
        {
            return View(await _InterfaceImagem.List());
        }

        // GET: Imagens/Details/5
        public async Task<IActionResult> Details(int id)
        {
            return View(await _InterfaceImagem.GetEntityById(id));
        }

        // GET: Imagens/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: Imagens/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Imagem imagem)
        {
            try
            {
                await _InterfaceImagem.AddImagem(imagem);

                if (imagem.ListNotifies.Any())
                {
                    foreach (var erro in imagem.ListNotifies)
                    {
                        ModelState.AddModelError(erro.NomePropriedade, erro.Mensagem);
                    }
                    return View("Edit", imagem);
                }
            }
            catch
            {
                return View("Edit", imagem);
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Imagens/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            return View(await _InterfaceImagem.GetEntityById(id));
        }

        // POST: Imagens/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Imagem imagem)
        {
            try
            {

                await _InterfaceImagem.UpdateImagem(imagem);

                if (imagem.ListNotifies.Any())
                {
                    foreach (var erro in imagem.ListNotifies)
                    {
                        ModelState.AddModelError(erro.NomePropriedade, erro.Mensagem);
                    }
                    return View("Edit", imagem);
                }
            }
            catch
            {
                return View("Edit", imagem);
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Imagens/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            return View(await _InterfaceImagem.GetEntityById(id));
        }

        // POST: Imagens/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Imagem imagem)
        {
            try
            {
                var imagemDeletar = await _InterfaceImagem.GetEntityById(id);

                await _InterfaceImagem.Delete(imagemDeletar);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
