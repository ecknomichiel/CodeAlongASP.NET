﻿using CodeAlongMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeAlongMVC
{
    public class BookRepository
    {
        private List<Book> context;

        public IEnumerable<Book> GetAllBooks()
        {
            return context.ToList();
        }

        public Book GetBookByID(int aID)
        {
            return context.SingleOrDefault<Book>(b => b.ID == aID);
        }
 
        public BookRepository()
        {
           context = new List<Book>() 
            { 
                new Book(){ID = 2, Author = "John Grisham", Description = "Novel", ISBN="112-1", Title = "For whom the bells toll."},
                new Book(){ID = 1, Author = "Stephen King", Description = "Horror", ISBN="111-1", Title = "Cell"},
                new Book(){ID = 3, Author = "Ian Mc Ewan", Description = "Novel", ISBN="113-1", Title = "The Innocent"},
                new Book(){ID = 4, Author = "Michael Conelly", Description = "Novel", ISBN="114-1", Title = "The Poet"}
            };
        }
    }
}