using AvaliacaoSistemasWeb.Dominio.Core.Entidades;
using AvaliacaoSistemasWeb.Dominio.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoSistemasWeb.Aplicacao
{
    public class EstacaoRecargaApp : IEstacaoRecargaApp
    {
        //Referência ao Domínio - via interface de repositório
        IEstacaoRecarga _estacaoRecargaRepo;

        public EstacaoRecargaApp(IEstacaoRecarga estacaoRecargaRepo)
        {
            _estacaoRecargaRepo = estacaoRecargaRepo;
        }

        //

        public void Adicionar(EstacaoRecarga obj)
        {
            _estacaoRecargaRepo.Adicionar(obj);
        }

        public void Atualizar(EstacaoRecarga obj)
        {
            _estacaoRecargaRepo.Atualizar(obj);
        }

        public void Excluir(EstacaoRecarga obj)
        {
            _estacaoRecargaRepo.Excluir(obj);
        }

        public IReadOnlyList<EstacaoRecarga> Listar()
        {
            return _estacaoRecargaRepo.Listar();
        }

        public EstacaoRecarga RecuperarPorId(Guid id)
        {
            return _estacaoRecargaRepo.RecuperarPorId(id);
        }
    }
}
