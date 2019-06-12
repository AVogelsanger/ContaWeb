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


        public ActionResult Listar()
        {
            var lista = _unit.ContaCorrenteRepository.Listar();
            return View(lista);
        }

        [HttpPost]
        public ActionResult Cadastrar(ContaCorrente cc)
        {
            _unit.ContaCorrenteRepository.Cadastrar(cc);
            _unit.Save();
            return RedirectToAction("Listar");
        }


        [HttpGet]
        public ActionResult Index()
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
