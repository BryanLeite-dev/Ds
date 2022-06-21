using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppQuerido.Models;

namespace AppQuerido.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.PessoaId = 15;
            pessoa.Nome = "Bob";
            pessoa.Sexo = "M";
            pessoa.Salario = 6000.50m;

            return View(pessoa);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}