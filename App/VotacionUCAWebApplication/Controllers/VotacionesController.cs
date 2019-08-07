using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VotacionUCAWebApplication.Models;

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

        public async System.Threading.Tasks.Task<ActionResult> Candidatos(int id)
        {
            List<Candidatos> candidatos = await ClienteWeb.ListarCandidatos();
            List<Estudiantes> estudiantes = await ClienteWeb.ListarEstudiantes();
           
            List<Candidatos> candidatosFiltrado = new List<Candidatos>();

            foreach(Candidatos c in candidatos)
            {
                if(c.IdVotacion == id)
                {
                    candidatosFiltrado.Add(c);
                }
            }

            ViewBag.IdVotacion = id;
            ViewBag.ListaCandidatos = candidatosFiltrado;
            ViewBag.ListaEstudiantes = estudiantes;

            return View();
        }

        [HttpPost]
        public ActionResult Votar()
        {
            return View();
        }
    }
}