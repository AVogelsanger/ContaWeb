using ContaWeb.Models;
using ContaWeb.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContaWeb.Metodos
{
    public class Movimentacao
    {

        //private ContaContext _context;

        //public Movimentacao(ContaContext context)
        //{
        //    _context = context;
        //}

        public Movimentacao() { }

        public double Deposito(ContaCorrente cc)
        {
            cc.Saldo += cc.Movimentacao;

            return cc.Saldo;
        }

        public double Saque(ContaCorrente cc)
        {
            cc.Saldo -= cc.Movimentacao;

            return cc.Saldo;
        }

    }
}