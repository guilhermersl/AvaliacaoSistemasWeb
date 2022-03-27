using AvaliacaoSistemasWeb.Dominio.Core.Entidades;
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
    public class EstacaoRecargaRepositorio : RepositorioBase<EstacaoRecarga>, IEstacaoRecarga
    {
    }
}
