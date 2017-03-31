using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentacion.Controllers
{
    public class IniciarSesionController : Controller
    {
        //
        // GET: /IniciarSesion/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IniciarSesion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UsuarioNuevo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UsuarioRegistrado()
        {
            return View();
        }



    }
}
