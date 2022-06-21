using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppQuerido.Models;

namespace AppQuerido.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Funcionario()
        {
            Pessoa pessoa = new Pessoa
            {
                PessoaId = 171,
                Nome = "Larisa",
                Sexo = "F",
                Salario = 6000.50m,
                DataNasc = Convert.ToDateTime("16/07/2005")
            };

            return View(pessoa);

        }
    }
}