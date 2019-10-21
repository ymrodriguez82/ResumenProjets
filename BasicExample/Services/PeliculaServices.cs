using BasicExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicExample.Services
{
    public class PeliculaServices
    {
        public Pelicula ObtenerPelicula()
        {
            return new Pelicula()
            {
                Titulo = "Plan Escape",
                Duracion = 115,
                Pais = "Usa",
                Publicacion = new DateTime(2013, 12, 5)
            };
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            var pelicula1 = new Pelicula()
            {
                Titulo = "Plan Escape",
                Duracion = 115,
                Pais = "Usa",
                Publicacion = new DateTime(2013, 12, 5)
            };

            var pelicula2 = new Pelicula()
            {
                Titulo = "Capitan America",
                Duracion = 145,
                Pais = "Usa",
                Publicacion = new DateTime(2016, 09, 5)
            };

            return new List<Pelicula> { pelicula1, pelicula2 };
        }
    }
}