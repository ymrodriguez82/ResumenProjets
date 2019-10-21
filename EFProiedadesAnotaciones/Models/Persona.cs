using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EFProiedadesAnotaciones.Models
{
    public class Persona
    {
        public int Id { get; set; }

        [Required(ErrorMessage = ("El campo {0} es obligatorio"))]
        [StringLength(40, ErrorMessage = ("EL campo {0} no puede pasar los {1} caracteres"))]
        public string Nombre { get; set; }

        [StringLength(6, MinimumLength = 5, ErrorMessage = ("EL campo {0} debe tener logintud minima de {2} y maxima de {1}"))]
        [Required(ErrorMessage = ("El campo {0} es obligatorio"))]
        public string CodigoPostal { get; set; }

        [Range(18, 120, ErrorMessage = ("El campo {0} de estar en el rango de {1} y {2}"))]
        public int Edad { get; set; }

        //[StringLength(200)]
        //[Display(Name = "Email address")]
        [Required(ErrorMessage = "The {0} is required")]
        //[EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [NotMapped]
        [Compare("Email", ErrorMessage = ("El email no match con la  {0}"))]
        public string ConfirmarEmail { get; set; }

        [CreditCard(ErrorMessage = ("Tarjeta invalida verifique por favor"))]
        public string TarjetaCredito { get; set; }

    }
}