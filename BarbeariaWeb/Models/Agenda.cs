using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarbeariaWeb.Models
{
    public class Agenda
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string Servico { get; set; }
        public double Valor { get; set; }
        public string DataHora { get; set; }
    }
}
