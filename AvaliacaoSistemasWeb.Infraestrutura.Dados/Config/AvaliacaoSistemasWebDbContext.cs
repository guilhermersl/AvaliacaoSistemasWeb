using AvaliacaoSistemasWeb.Dominio.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoSistemasWeb.Infraestrutura.Dados.Config
{
    public class AvaliacaoSistemasWebDbContext : DbContext
    {
        public DbSet<EstacaoRecarga> EstacaoRecargas { get; set; }

        public AvaliacaoSistemasWebDbContext()
        {

        }

        public AvaliacaoSistemasWebDbContext(DbContextOptions<AvaliacaoSistemasWebDbContext> options) : base(options)
        {

        }


        //Configora a Conexão com o BD
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = AvaliacaoSistemasWeb-2022-03-26; Trusted_Connection = True; MultipleActiveResultSets = True");
            
            base.OnConfiguring(optionsBuilder);
        }
    }
}
