using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarbeariaWeb.Models
{
    public class Servico
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome do serviço é obrigatorio! ")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="O valor do serviço é Obrigatorio")]

        public double Valor { get; set; }
    }
}
