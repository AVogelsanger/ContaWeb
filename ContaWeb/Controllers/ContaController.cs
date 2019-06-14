using ContaWeb.Models;
using ContaWeb.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContaWeb.Controllers
{
    public class ContaController : Controller
    {

        UnitOfWork _unit = new UnitOfWork();


        [HttpPost]
        public ActionResult Depositar(int id, string valor)
        {
            var valorFormatado = double.Parse(valor);
            var conta = _unit.ContaCorrenteRepository.BuscarPorNumero(id);
            var teste = conta.Saldo;
            teste = teste + valorFormatado;
            conta.Saldo = teste;
            _unit.ContaCorrenteRepository.Atualizar(conta);

            return PartialView();
        }

        [HttpPost]
        public ActionResult Sacar(int id, double valor)
        {
            var conta = _unit.ContaCorrenteRepository.BuscarPorNumero(id);
            var teste = conta.Saldo;
            teste = teste - valor;
            conta.Saldo = teste;
            _unit.ContaCorrenteRepository.Atualizar(conta);

            return PartialView();
        }



        [HttpGet]
        public ActionResult Buscar(int? idConta)
        {
            var conta = _unit.ContaCorrenteRepository.BuscarPor(c => (idConta != null ? c.ID == idConta : 0 == 0));
            return PartialView(conta);
        }

        //[HttpPost]
        //public JsonResult ChamaConta(int dadosConta)
        //{
        //    var modulos = (_unit.ContaCorrenteRepository.BuscarPorNumero(dadosConta));
        //    return Json(new { n = modulos.Nome });
        //}


        public ActionResult Listar()
        {
            ViewBag.Conta = new SelectList(_unit.ContaCorrenteRepository.Listar(), "ID","NumeroConta");
            return View();
            //return View(_unit.ContaCorrenteRepository.Listar());
        }

        [HttpPost]
        public ActionResult Cadastrar(ContaCorrente cc)
        {
            _unit.ContaCorrenteRepository.Cadastrar(cc);
            _unit.Save();
            return RedirectToAction("Listar");
        }


        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }


        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }

    }
}
