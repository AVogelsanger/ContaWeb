using ContaWeb.Persistence;
using ContaWeb.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContaWeb.Unit
{
    public class UnitOfWork : IDisposable
    {

        private ContaContext _context = new ContaContext();

        private IContaCorrenteRepository _contaCorrente;

        public IContaCorrenteRepository ContaCorrenteRepository
        {
            get
            {
                if (_contaCorrente == null)
                {
                    _contaCorrente = new ContaCorrenteRepository(_context);
                }
                return _contaCorrente;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }


        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}