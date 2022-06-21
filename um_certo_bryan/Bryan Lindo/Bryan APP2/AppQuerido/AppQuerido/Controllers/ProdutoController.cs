using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppQuerido.Models;

namespace AppQuerido.Controllers
{
    public class ProdutoController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Produto prod)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", prod);
            }

            return View();
        }

        public ActionResult ValidaLogin(string Login)
        {
            var dbBanco = new Collection<string>
            {
                "Mini Craque",
                "Vampeta",
                "Vaselina"
            };

            return Json(dbBanco.All(a => a.ToLower() != Login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}