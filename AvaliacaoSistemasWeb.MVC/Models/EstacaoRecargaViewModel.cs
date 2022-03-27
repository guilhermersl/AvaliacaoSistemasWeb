using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaliacaoSistemasWeb.MVC.Models
{
    public class EstacaoRecargaViewModel
    {
        public Guid Id { get; set; }
        
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "O campo Tipo é obrigatório.")]
        public Tipos Tipo { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public enum Tipos
    {
        Veicular,
        Movel
    }
}
