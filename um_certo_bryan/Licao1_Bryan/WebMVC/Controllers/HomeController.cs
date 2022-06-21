using AppBancoDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lista()
        {
            var metodosUsuarios = new UsuarioDAO();
            var listarUsuarios = metodosUsuarios.Select();
            return View(listarUsuarios);
        }
   
    }
}