using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppQuerido.Areas.Financeiro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Financeiro/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}