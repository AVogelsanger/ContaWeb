using ContaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ContaWeb.Repository
{
    public interface IContaCorrenteRepository
    {
        void Cadastrar(ContaCorrente contaCorrente);
        void Atualizar(ContaCorrente contaCorrente);
        ContaCorrente BuscarPorNumero(int numero);
        void Excluir(int numero);
        IList<ContaCorrente> Listar();
        IList<ContaCorrente> BuscarPor(Expression<Func<ContaCorrente, bool>> filtro);
    }
}
