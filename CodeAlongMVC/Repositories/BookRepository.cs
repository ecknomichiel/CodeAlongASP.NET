using CodeAlongMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeAlongMVC
{
    public class BookRepository
    {
        private List<Book> context;
        private int maxId;
        static private BookRepository instance = null;

        public IEnumerable<Book> GetAllBooks()
        {
            return context.ToList();
        }

        public static BookRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookRepository();
                    instance.context = new List<Book>() 
                    { 
                        new Book(){ID = 2, Author = "John Grisham", Description = "Novel", ISBN="112-1", Title = "For whom the bells toll."},
                        new Book(){ID = 1, Author = "Stephen King", Description = "Horror", ISBN="111-1", Title = "Cell"},
                        new Book(){ID = 3, Author = "Ian Mc Ewan", Description = "Novel", ISBN="113-1", Title = "The Innocent"},
                        new Book(){ID = 4, Author = "Michael Conelly", Description = "Novel", ISBN="114-1", Title = "The Poet"}
                    };
                    instance.maxId = instance.context.Max(book => book.ID);
                }
                return instance;
            }
        }

        public Book GetBookByID(int aID)
        {
            return context.SingleOrDefault<Book>(b => b.ID == aID);
        }
 
        private BookRepository()
        {
            
        }

        public int Add(Book book)
        {
            if (book.ID == 0)
                book.ID = GetNextID();
            context.Add(book);
            return book.ID;

        }

        private int GetNextID()
        {
            return ++maxId;
        }
    }
}