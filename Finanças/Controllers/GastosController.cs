using Finanças.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finanças.Controllers
{
    public class GastosController : Controller
    {
        // GET: Gastos
        GastosRepo repositorio = new GastosRepo();
        public ActionResult Index()
        {
            var g = repositorio.getAll();

            return View(g);
        }

        public ActionResult create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult create(Gastos pGastos)
        {
            repositorio.create(pGastos);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int Id)
        {
            var gast = repositorio.getOne(Id);
            return View(gast);
        }

        [HttpPost]
        public ActionResult Update(Gastos pGastos)
        {
            repositorio.update(pGastos);
            return RedirectToAction("Index");
        }
    }
}