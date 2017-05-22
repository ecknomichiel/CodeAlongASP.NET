using CodeAlongMVC.DataAccess;
using CodeAlongMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeAlongMVC
{
    public class BookRepository
    {
        //private List<Book> context;
        private LibraryContext context = new LibraryContext();
        private int maxId;
        static private BookRepository instance = null;

        public IEnumerable<Book> GetAllBooks()
        {
            return context.Books;
        }

        public static BookRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookRepository();
                   // instance.context = new List<Book>(); 
                   // instance.Load();
                   // instance.maxId = instance.context.Max(book => book.ID);
                }
                return instance;
            }
        }

       /* private void Load()
        {
            LibraryContext lContext = new LibraryContext();
            context.AddRange(lContext.Books);
        }*/

        public Book GetBookByID(int aID)
        {
            return context.Books.SingleOrDefault<Book>(b => b.ID == aID);
        }
 
        private BookRepository()
        {
            
        }

        public int Add(Book book)
        {
            context.Books.Add(book);
            return book.ID;

        }
        /*
        private int GetNextID()
        {
            return ++maxId;
        }*/
    }
}