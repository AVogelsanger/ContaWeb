using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContaWeb.Models
{
    public class ContaCorrente
    {
        public int ID { get; set; }
        public int Agencia { get; set; }
        public int NumeroConta { get; set; }
        public double Saldo { get; set; }
        public string Nome { get; set; }
        public double Movimentacao { get; set; }
    }
}