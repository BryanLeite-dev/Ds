using AppLoginAutenticar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppLoginAutenticar.ViewModels;

namespace AppLoginAutenticar.Controllers
{
    public class AutenticacaoController : Controller
    {
        Usuario novousuario = new Usuario();
        // GET: Autenticacao
        [HttpGet]
        public ActionResult Insert()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Insert(CadastroUsuarioViewModel viewmodel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewmodel);
            }

            
            {
                string UsuNome = viewmodel.UsuNome;
                string Login = viewmodel.Login;
                string Senha = viewmodel.Senha;
            };

            novousuario.InsertUsuario(novousuario);

            return RedirectToAction("Index", "Home");
        }

        public ActionResult SelectLogin(string Login) 
        {
            bool LoginExist;
            string login = novousuario.SelectLogin(Login);

            if (login.Length == 0) 
            {
                LoginExist = false;
            }
            else 
            { 
                LoginExist = true; 
            }
            return Json(!LoginExist, JsonRequestBehavior.AllowGet);
        }

    }
}