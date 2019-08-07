using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VotacionUCAWebApplication.Controllers
{
    public class VotacionesController : Controller
    {
        public void Listar()
        {
            RedirectToAction("Votaciones", "Inicio");
        }
        public ActionResult Crear()
        {
            return View();
        }
        public ActionResult Editar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Borrar()
        {
            return View();
        }

        public ActionResult Candidatos(int id)
        {
            Content("Funciona");
            System.Diagnostics.Debug.WriteLine("ID DE VOTACION> " + id);
            return View();
        }

        [HttpPost]
        public ActionResult Votar()
        {
            return View();
        }
    }
}