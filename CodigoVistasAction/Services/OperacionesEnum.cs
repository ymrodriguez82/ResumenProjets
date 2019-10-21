using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CodigoVistasAction.Services
{
    public enum OperacionesEnum
    {
        Aprobado = 1,
        Rechazado = 2,
        Pendiente = 7,
        //anotacion permite que el enum sea puede visualizar separadas las dos palabras
        [Description("Pendiente Operacion")]
        PedienteAprobacion = 9
    }


} 