namespace CodeAlongMVC.Migrations
{
    using CodeAlongMVC.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeAlongMVC.DataAccess.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeAlongMVC.DataAccess.LibraryContext context)
        {
            context.Books.AddOrUpdate(
                b => b.ID,
                new Book { ISBN = "111", Author = "Stephen King", Title = "Cell", Description = "Horror" },
                new Book { ISBN = "112", Author = "Stephen King", Title = "It", Description = "Horror" },
                new Book { ISBN = "113", Author = "Diana Wynn Jones", Title = "Howl's Moving Castle", Description = "Fantasy" }
                );
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
        }
    }
}
