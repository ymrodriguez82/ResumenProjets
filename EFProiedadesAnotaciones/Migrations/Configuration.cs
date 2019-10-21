namespace EFProiedadesAnotaciones.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFProiedadesAnotaciones.Models.GeneralContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EFProiedadesAnotaciones.Models.GeneralContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //Data que siempre quiero que este en la BD
            context.Persona.AddOrUpdate(x =>x.Id, new Models.Persona()
            {
                Id = 1,
                Nombre = "Yuni",
                Edad = 37, 
                CodigoPostal = "H5N4R7",
                Email = "yuni@gmail.com"               

            });

           
        }
    }
}
