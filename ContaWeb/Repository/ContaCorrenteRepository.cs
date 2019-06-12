using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using ContaWeb.Models;
using ContaWeb.Persistence;
using System.Data.Entity;

namespace ContaWeb.Repository
{
    public class ContaCorrenteRepository : IContaCorrenteRepository
    {

        private ContaContext _context;

        public ContaCorrenteRepository(ContaContext context)
        {
            _context = context;
        }

        public void Atualizar(ContaCorrente conta)
        {
            _context.Entry(conta).State = EntityState.Modified;
        }

        public IList<ContaCorrente> BuscarPor(Expression<Func<ContaCorrente, bool>> filtro)
        {
            return _context.Contas.Where(filtro).ToList();
        }

        public ContaCorrente BuscarPorNumero(int numero)
        {
            return _context.Contas.Find(numero);
        }

        public void Cadastrar(ContaCorrente conta)
        {
            _context.Contas.Add(conta);
        }

        public void Excluir(int numero)
        {
            ContaCorrente cc = _context.Contas.Find(numero);
            _context.Contas.Remove(cc);
        }

        public IList<ContaCorrente> Listar()
        {
            return _context.Contas.ToList();
        }
    }
}