using FormulariosRaizorVistas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormulariosRaizorVistas.Services
{
    public class AccesData
    {
        public static List<Persona> ListadoPersonas()
        {
            
            var personas = new List<Persona>()
            {
                new Persona()
                {
                    Nombre = "Yuni",
                    Edad = 37
                },
                 new Persona()
                {
                    Nombre = "Yusme",
                    Edad = 27
                },
                  new Persona()
                {
                    Nombre = "Risquel",
                    Edad = 1
                },
                   new Persona()
                {
                    Nombre = "Dani",
                    Edad = 11
                }
            };

            return personas;


        }
    }
}