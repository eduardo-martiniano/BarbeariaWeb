using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarbeariaWeb.Models
{
    public class Agenda
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo 'Nome' é obrigatório!")]
        [MaxLength(30, ErrorMessage = "O campo 'Nome' deve conter o máximo de 30 números!")]
        public string NomeCliente { get; set; }
        public string Servico { get; set; }
        public double Valor { get; set; }
        [Required(ErrorMessage = "O campo 'Data' é obrigatório!")]
        [MaxLength(10, ErrorMessage = "A data deve está no formato correto! Ex: 10/10/2020")]
        [MinLength(10, ErrorMessage = "A data deve está no formato correto! Ex: 10/10/2020")]
        public string DataHora { get; set; }
    }
}
