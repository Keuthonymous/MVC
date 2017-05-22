using CodeAlongMVC.Models;
using CodeAlongMVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeAlongMVC.Controllers
{
    public class BookController : Controller
    {
        BookRepository repo = null;

        public BookController()
        {
            Console.WriteLine("Visited Constructor");
        }

        // GET: Book
        public ActionResult Index()
        {
            return View(BookRepository.GetAllBooks());
        }

        public ActionResult Details(int Id)
        {
            return View(BookRepository.GetBookById(Id));
        }
        public ActionResult Delete(Book b)
        {
            BookRepository.RemoveBook(b);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Book b)
        {
            BookRepository.AddNewBook(b);
            return RedirectToAction("Index");
        }
    }
}