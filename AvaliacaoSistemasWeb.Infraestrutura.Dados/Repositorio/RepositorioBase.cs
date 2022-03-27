using AvaliacaoSistemasWeb.Dominio.Core.Interfaces;
using AvaliacaoSistemasWeb.Infraestrutura.Dados.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoSistemasWeb.Infraestrutura.Dados.Repositorio
{
    public class RepositorioBase<T> : IBase<T>, IDisposable where T : class
    {

        private readonly DbContextOptions<AvaliacaoSistemasWebDbContext> _optionsBuilder;

        public RepositorioBase()
        {
            //Aqui há dependência, mas é aceitável, uma vez que já tenho uma dependência no Property
            _optionsBuilder = new DbContextOptions<AvaliacaoSistemasWebDbContext>();
        }


        public void Adicionar(T obj)
        {
            //Chama cnstrutor com parâmetro de OptionsBuilder, que criei na DBContext
            using (var db = new AvaliacaoSistemasWebDbContext(_optionsBuilder))
            {
                db.Set<T>().Add(obj);  //onde T é o tipo genérico passado à classe.
                db.SaveChanges();
            }
        }

        public void Atualizar(T obj)
        {
            using (var db = new AvaliacaoSistemasWebDbContext(_optionsBuilder))
            {
                db.Set<T>().Update(obj);
                db.SaveChanges();
            }
        }

        public void Excluir(T obj)
        {
            using (var db = new AvaliacaoSistemasWebDbContext(_optionsBuilder))
            {
                db.Set<T>().Remove(obj);
                db.SaveChanges();
            }
        }

        public IReadOnlyList<T> Listar()
        {
            using (var db = new AvaliacaoSistemasWebDbContext(_optionsBuilder))
            {
                return db.Set<T>().AsNoTracking().ToList(); //AsNoTracking tira o rastreamento... é bom para quando trabalhamos apenas com leitura
            }
        }

        public T RecuperarPorId(Guid id)
        {
            using (var db = new AvaliacaoSistemasWebDbContext(_optionsBuilder))
            {
                return db.Set<T>().Find(id);
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
