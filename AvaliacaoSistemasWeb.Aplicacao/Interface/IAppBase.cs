using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoSistemasWeb.Aplicacao
{
    public interface IAppBase<T> where T : class
    {
        //Casos de Uso base para todas as classes

        //Terá as mesmas definições de contrato do Repositório

        void Adicionar(T obj);
        T RecuperarPorId(Guid id);
        void Atualizar(T obj);
        void Excluir(T obj);
        IReadOnlyList<T> Listar();

    }
}
