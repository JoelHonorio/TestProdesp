#region Usings

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Prodesp.Negocios.IRepositories;
using Prodesp.Negocios.Models;
using Prodesp.ViewModels;

#endregion

namespace Prodesp.Controllers
{
    public class HomeController : BaseController
    {
        #region Injeção de dependências

        private readonly IMapper _mapper;
        private readonly IImunobiologicoRepository _imunobiologico;
        private readonly IFabricanteRepository _fabricante;

        public HomeController
        (
            IMapper mapper,
            IImunobiologicoRepository imunobiologico,
            IFabricanteRepository fabricante
        )
        {
            _mapper = mapper;
            _imunobiologico = imunobiologico;
            _fabricante = fabricante;
        }

        #endregion

        public async Task<IActionResult> Index()
        {
            var imunobiologicos = _mapper.Map<IEnumerable<ImunobiologicoViewModel>>(await _imunobiologico.ObterTodosImunobiologicos());

            foreach(var item in imunobiologicos)
            {
                var fabricante = await _fabricante.ObterPorId(item.FabricanteId);

                item.DataCriacaoString = item.DataCriacao.ToShortDateString();
                item.FabricanteString = fabricante.Marca;
            }

            return View(imunobiologicos);
        }

        public async Task<IActionResult> Criar()
        {
            await CarregaViewBagsAsync();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Criar(ImunobiologicoViewModel imunobiologicoViewModel)
        {
            if (!ModelState.IsValid)
            {
                await CarregaViewBagsAsync();

                return View(imunobiologicoViewModel);
            }

            if (imunobiologicoViewModel.AnoLote < DateTime.Now.Year -1)
            {
                await CarregaViewBagsAsync();

                return View(imunobiologicoViewModel);
            }

            imunobiologicoViewModel.DataCriacao = DateTime.Now;
            imunobiologicoViewModel.DataModificacao = DateTime.Now;

            var imunobiologico = _mapper.Map<Imunobiologico>(imunobiologicoViewModel);
            await _imunobiologico.Adicionar(imunobiologico);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Editar(Guid id)
        {
            var imunobiologicoViewModel = _mapper.Map<ImunobiologicoViewModel>(await _imunobiologico.ObterPorId(id));

            if (imunobiologicoViewModel == null)
            {
                return NotFound();
            }

            var fabricante = await _fabricante.ObterPorId(imunobiologicoViewModel.FabricanteId);

            imunobiologicoViewModel.FabricanteString = fabricante.Marca;

            await CarregaViewBagsAsync();

            return View(imunobiologicoViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(Guid id, ImunobiologicoViewModel imunobiologicoViewModel)
        {
            if (id != imunobiologicoViewModel.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                await CarregaViewBagsAsync();

                return View(imunobiologicoViewModel);
            }

            if (imunobiologicoViewModel.AnoLote < DateTime.Now.Year -1)
            {
                await CarregaViewBagsAsync();

                return View(imunobiologicoViewModel);
            }

            var imunobiologico = _mapper.Map<Imunobiologico>(imunobiologicoViewModel);

            imunobiologico.DataModificacao = DateTime.Now;

            await _imunobiologico.Atualizar(imunobiologico);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Deletar(Guid id)
        {
            var imunobiologicoViewModel = _mapper.Map<ImunobiologicoViewModel>(await _imunobiologico.ObterPorId(id));

            if (imunobiologicoViewModel == null)
            {
                return NotFound();
            }

            var fabricante = await _fabricante.ObterPorId(imunobiologicoViewModel.FabricanteId);

            imunobiologicoViewModel.DataCriacaoString = imunobiologicoViewModel.DataCriacao.ToShortDateString();
            imunobiologicoViewModel.FabricanteString = fabricante.Marca;

            return View(imunobiologicoViewModel);
        }

        [HttpPost, ActionName("Deletar")]
        public async Task<IActionResult> DeletarConfirmacao(Guid id)
        {
            var imunobiologico = await _imunobiologico.ObterImunobiologico(id);

            if (imunobiologico == null)
            {
                return NotFound();
            }

            await _imunobiologico.Remover(id);

            return RedirectToAction("Index");
        }

        public async Task CarregaViewBagsAsync()
        {
            ViewBag.Fabricantes = _mapper.Map<IEnumerable<FabricanteViewModel>>(await _fabricante.ObterTodosFabricantes());
        }
    }
}