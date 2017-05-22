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
            context.Books.AddOrUpdate(book => book.ID, new Book(){ID = 2, Author = "John Grisham", Description = "Novel", ISBN="112-1", Title = "For whom the bells toll."});
            context.Books.AddOrUpdate(book => book.ID, new Book(){ID = 1, Author = "Stephen King", Description = "Horror", ISBN="111-1", Title = "Cell"});
            context.Books.AddOrUpdate(book => book.ID, new Book(){ID = 3, Author = "Ian Mc Ewan", Description = "Novel", ISBN="113-1", Title = "The Innocent"});
            context.Books.AddOrUpdate(book => book.ID, new Book() { ID = 4, Author = "Michael Conelly", Description = "Novel", ISBN = "114-1", Title = "The Poet" });
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
