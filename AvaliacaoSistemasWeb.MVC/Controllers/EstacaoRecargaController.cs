using AvaliacaoSistemasWeb.Aplicacao;
using AvaliacaoSistemasWeb.Dominio.Core.Entidades;
using AvaliacaoSistemasWeb.Infraestrutura.Dados.Config;
using AvaliacaoSistemasWeb.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AvaliacaoSistemasWeb.MVC.Controllers
{
    public class EstacaoRecargaController : Controller
    {
        private readonly IEstacaoRecargaApp _estacaoRecargaApp;

        public EstacaoRecargaController(IEstacaoRecargaApp estacaoRecargaApp)
        {
            _estacaoRecargaApp = estacaoRecargaApp;
        }

        //GET EstacoesRecarga
        public IActionResult Index()
        {
            return View(_estacaoRecargaApp.Listar());
        
        }

        //GET: EstacaoRecarga/Create
        public IActionResult Create()
        {
            return View();
        }

        //POST: EstacaoRecarga/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EstacaoRecarga estacaoRecarga)
        {
            try
            {
                estacaoRecarga.Id = new Guid();
                _estacaoRecargaApp.Adicionar(estacaoRecarga);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return View(estacaoRecarga);    
            }

        }

        // GET: EstacaoRecarga/Edit/5
        public ActionResult Edit(Guid id)
        {
            return View(_estacaoRecargaApp.RecuperarPorId(id));
        }

        // POST: EstacaoRecarga/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EstacaoRecarga estacaoRecarga)
        {
            try
            {
                // TODO: Add update logic here
                _estacaoRecargaApp.Atualizar(estacaoRecarga);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstacaoRecarga/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_estacaoRecargaApp.RecuperarPorId(id));
        }

        // POST: EstacaoRecarga/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(EstacaoRecarga estacaoRecarga)
        {
            try
            {
                // TODO: Add delete logic here
                _estacaoRecargaApp.Excluir(estacaoRecarga);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstacaoRecarga/Details/5
        public ActionResult Details(Guid id)
        {
            var estacaoRecarga = _estacaoRecargaApp.RecuperarPorId(id);
            return View(estacaoRecarga);
        }

    }
}
