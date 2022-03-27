using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoSistemasWeb.Dominio.Core.Interfaces
{
    //Interface para contrato base
    public interface IBase<T> where T : class 
    {
        //Adicionar
        void Adicionar(T obj);

        //Ler
        T RecuperarPorId(Guid id);

        //Atualizar
        void Atualizar(T obj);

        //Excluir
        void Excluir(T obj);

        //Listar
        IReadOnlyList<T> Listar();

    }
}
