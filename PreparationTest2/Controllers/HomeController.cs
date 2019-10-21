using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PreparationTest2.Models;

namespace PreparationTest2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Yuni = "Yuni";
            return View();
        }

        //Descargando un documento pdf
        public FileResult Archivo()
        {
            var ruta = Server.MapPath("~/Files/test.pdf");
            return File(ruta, "application/pdf", "Formulario");
           // return View();
        }

        //ContentResult retorna texto 
        public ContentResult About()
        {
            //ViewBag.Message = "Your application description page.";

            return Content("<b>Mendez</b>");
            //return Content("Mendez", "text/html");
        }

        //Hacer redirecciones 
        public ActionResult Redirect()
        {
            //Hace una redirecion hacias la regla de ruteo Ejemplo
            return RedirectToRoute("Ejemplo");

            //tipo de dato que retorna RedirectToRouteResult
            //return RedirectToAction("Home");

            //tipo de dato que retorna RedirectResult
            //return Redirect("http:google.com");

        }

        //retornando un Json 
        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";
            var pelicula = new Pelicula()
            {
                Titulo = "Plan Escape",
                Duracion = 115,
                Pais = "Usa",
                Publicacion =Convert.ToDateTime( new DateTime(2013, 12, 5))
            };
            var pelicula2 = new Pelicula()
            {
                Titulo = "Capitan America",
                Duracion = 145,
                Pais = "Usa",
                Publicacion = new DateTime(2016, 09, 5)
            };

            return Json(new List<Pelicula>() { pelicula, pelicula2 }, JsonRequestBehavior.AllowGet);
            return View();
        }
    }
}