using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppQuerido.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Pessoa()
        {
            ViewBag.PessoaId = 12;
            ViewBag.Nome = "Enildo";
            ViewBag.Sexo = "M";
            return View();
        }

        public ActionResult Data()
        {
            ViewData["PessoaId"] = 13;
            ViewData["Nome"] = "Magrela";
            ViewData["Sexo"] = "F";
            return View();
        }
    }
}