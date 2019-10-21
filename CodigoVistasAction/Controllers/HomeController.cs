using CodigoVistasAction.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace CodigoVistasAction.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           
            var persona = new Persona
            {
                Nombre = "Yuni",
                Edad = 37,
                Empleado = false,
                Nacimiento = new DateTime(2010, 09, 08)
            };
            ViewBag.Propiedad = persona;
            return View();
        }

        public ActionResult About(int edad, string nom)
        {
            ViewBag.Message = "Your application description page."+ edad+" "+ nom;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AfficherDropDowList()
        {

            //string recibirOption = option;
            var listado = AccesoData.ObeterListado();
            ViewBag.listado = listado;

            var listadoSinModeleDropDown = AccesoData.ObtenerListeSinModeleDropDownListe<OperacionesEnum>();

            ViewBag.listadoSinModeleDropDown = listadoSinModeleDropDown;


            return View();
        }

        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public bool Empleado { get; set; }
            public DateTime Nacimiento { get; set; }

           
        }


        
    }
}