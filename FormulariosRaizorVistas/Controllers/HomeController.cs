using FormulariosRaizorVistas.Models;
using FormulariosRaizorVistas.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormulariosRaizorVistas.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Persona p)
        {
            ViewBag.Message = "Exitoso";
            return View(p);
        }

        public ActionResult About()
        {
            var ListadoPersonas = AccesData.ListadoPersonas();
            ViewBag.Message = "Your contact page.";
            ViewBag.ListadoPersonas = ListadoPersonas;
            return View();
        }

        public ActionResult Contact()
        {
            var ListadoPersonas = AccesData.ListadoPersonas();
            ViewBag.Message = "Your contact page.";
            ViewBag.ListadoPersonas = ListadoPersonas;

            return View();
        }
    }
}