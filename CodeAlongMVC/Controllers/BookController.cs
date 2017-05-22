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
            repo = new BookRepository();
        }

        // GET: Book
        public ActionResult Index()
        {
            return View(repo.GetAllBooks());
        }

        public ActionResult Details(int Id)
        {
            return View(repo.GetBookById(Id));
        }
        public ActionResult Delete(Book b)
        {
            repo.RemoveBook(b);
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
            repo.AddNewBook(b);
            return RedirectToAction("Index");
        }
    }
}