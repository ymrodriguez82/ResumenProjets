namespace EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFCodeFirst.Models.BlogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        //Seed se ejecuta cada vez que ejecutamos el comando update-database
        //Se utiliza para insertar informacion que siempre quieres que este en la base de datos por ejemplo
        protected override void Seed(EFCodeFirst.Models.BlogContext context)
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

            context.Comentarios.AddOrUpdate(x => x.Id, new Models.Comentario()
            {
                Id=1, 
                Autor = "Pablo",
                BlogPostId = 1,
                Contenido = "Emplo de contenido"
            });
        }
    }
}
