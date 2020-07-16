using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarbeariaWeb.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'CPF' é obrigatório!")]
        [MaxLength(11, ErrorMessage = "O campo 'CPF' deve conter o máximo de 11 números!")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "O campo 'Nome' é obrigatório!")]
        [MaxLength(30, ErrorMessage = "O campo 'Nome' deve conter o máximo de 30 números!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo 'Telefone' é obrigatório!")]
        [MaxLength(11, ErrorMessage = "O campo 'Telefone' deve conter o máximo de 9 números!")]
        public string Telefone { get; set; }

    }
}
