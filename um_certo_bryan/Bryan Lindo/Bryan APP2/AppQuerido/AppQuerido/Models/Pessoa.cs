using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppQuerido.Models
{
    public class Pessoa
    {
        public int      PessoaId { get; set; }
        public string   Nome     { get; set; }
        public string   Sexo     { get; set; }
        public decimal  Salario  { get; set; }
        public DateTime DataNasc { get; set; }
    }
}