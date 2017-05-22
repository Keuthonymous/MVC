using CodeAlongMVC.DataAccess;
using CodeAlongMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeAlongMVC.Repositories
{
    public class BookRepository
    {
        //private static List<Book> context = new List<Book>{
        //        new Book {ID=1, ISBN="111", Author="Stephen King", Title="Cell", Description="Horror"},
        //        new Book {ID=2, ISBN="112", Author="Stephen King", Title="It", Description="Horror"},
        //        new Book {ID=3, ISBN="113", Author="Diana Wynn Jones", Title="Howl's Moving Castle", Description="Fantasy"} 
        //    };

        LibraryContext context = new LibraryContext();

        public IEnumerable<Book> GetAllBooks()
        {
            return context.Books.ToList();
        }

        public Book GetBookById(int Id)
        {
            return context.Books.SingleOrDefault(book => book.ID == Id);
        }

        public void  AddNewBook(Book book)
        {
            int next = context.Books.Max(b => b.ID) + 1;
            book.ID = next;
            context.Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            context.Books.Remove(book);
        }
    }
}