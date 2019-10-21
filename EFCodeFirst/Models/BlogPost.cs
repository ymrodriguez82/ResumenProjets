using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFCodeFirst.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Contenido { get; set; }
        //[StringLength(100, MinimumLength =50, ErrorMessage ="El campo {0} debe tener una logitud minima de {2} y maxima de {100}")]
        //[Range(18, 100, ErrorMessage ="EL campo {0} debe tener valores entre {1} y {2}")]
        [StringLength(100)]
        public string Autor { get; set; }
        public DateTime Publicacion { get; set; }
        public List<Comentario> Comentarios { get; set; }
    }
}