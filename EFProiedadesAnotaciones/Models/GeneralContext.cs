using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFProiedadesAnotaciones.Models
{
    public class GeneralContext : DbContext
    {
        public GeneralContext() 
            : base("DefaultConnection")
        {

        }


        public DbSet<Persona> Persona { get; set; }
    }

    
}