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
        

        // GET: Book
        public ActionResult Index()
        {
            return View(BookRepository.Instance.GetAllBooks());
        }

        public ActionResult Details(int id)
        {
            return View(BookRepository.Instance.GetBookByID(id));
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Book book)
        {
            int Id =  BookRepository.Instance.Add(book);
            return RedirectToAction("Index");
        }

        public BookController()
        {

        }

        
    }
}