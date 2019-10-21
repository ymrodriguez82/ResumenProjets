using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace CodigoVistasAction.Services
{
    public class AccesoData
    {
        public static List<SelectListItem> ObeterListado()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text = "Si",
                    Value = "1"
                },
                new SelectListItem()
                {
                    Text = "No",
                    Value = "2"
                },
                new SelectListItem()
                {
                    Text = "Quizas",
                    Value = "1",
                    Disabled = true
                }
            };
        }


        //Metodo generico que obtiene los valores de un enum
        public static List<SelectListItem> ObtenerListeSinModeleDropDownListe<T>()
        {
            var t = typeof(T);

            if (!t.IsEnum) { throw new ApplicationException("Tipo debe ser enum"); }

            var members = t.GetFields(BindingFlags.Public | BindingFlags.Static);

            var result = new List<SelectListItem>();

            foreach (var member in members)
            {
                var attributeDescription = member.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute),
                    false);
                var descripcion = member.Name;

                if (attributeDescription.Any())
                {
                    descripcion = ((System.ComponentModel.DescriptionAttribute)attributeDescription[0]).Description;
                }

                var valor = ((int)Enum.Parse(t, member.Name));
                result.Add(new SelectListItem()
                {
                    Text = descripcion,
                    Value = valor.ToString()
                });
            }
            return result;
        }


    }
}