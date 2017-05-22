using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeAlongMVC.Models;

namespace CodeAlongMVC.Controllers
{
    
    public class BookController : Controller
    {
        public BookRepository repo;

        // GET: Book
        public ActionResult Index()
        {
            return View(repo.GetAllBooks());
        }

        public ActionResult Details(int id)
        {
            return View(repo.GetBookByID(id));
        }

        public BookController()
        {
            repo = new BookRepository();
        }
    }
}