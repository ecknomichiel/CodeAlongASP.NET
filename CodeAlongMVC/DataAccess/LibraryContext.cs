using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CodeAlongMVC.Models;

namespace CodeAlongMVC.DataAccess
{
    public class LibraryContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public LibraryContext(): base("DefaultConnection")
        { }
    }
}