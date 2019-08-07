using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using VotacionUCAWebApplication.Models;

namespace VotacionUCAWebApplication.Controllers
{
    public class InicioController : Controller
    {
        public ActionResult Acceso()
        {
            return View();
        }

        public async Task<ActionResult> Gestion()
        {
            List<Votaciones> votaciones = await ClienteWeb.ListarVotaciones();
            ViewBag.ListaVotaciones = votaciones;
            return View();
        }

        public ActionResult Votaciones()
        {
            return View();
        }
    }
}