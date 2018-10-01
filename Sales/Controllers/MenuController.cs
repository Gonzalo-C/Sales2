using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sales.Controllers
{
    public class MenuController : Controller
    {

        private CLIEN_DB cliente = new CLIEN_DB();

        public ActionResult Inicio()
        {
            return View(cliente.Listar());
        }
    }
}