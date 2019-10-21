using BasicExample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var peliculaService = new PeliculaServices();

            var model = peliculaService.ObtenerPelicula();

            return View(model);

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var peliculaService = new PeliculaServices();

            var model = peliculaService.ObtenerPeliculas();

            return View(model);
        }
    }
}