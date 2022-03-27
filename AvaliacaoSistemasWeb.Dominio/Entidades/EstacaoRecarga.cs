using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoSistemasWeb.Dominio.Core.Entidades
{
    public class EstacaoRecarga : EntidadeBase
    {
        public string Nome { get; set; }
        public string Tipo{ get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
