using CodeAlongMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeAlongMVC.Repositories
{
    public class BookRepository
    {
        private List<Book> context;

        public BookRepository() 
        {
            context = new List<Book>{
                new Book {ID=1, ISBN="111", Author="Stephen King", Title="Cell", Description="Horror"},
                new Book {ID=2, ISBN="111", Author="Stephen King", Title="It", Description="Horror"},
                new Book {ID=3, ISBN="113", Author="Diana Wynn Jones", Title="Howl's Moving Castle", Description="Fantasy"} 
            };
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return this.context.ToList();
        }

        public Book GetBookById(int Id)
        {
            return context.SingleOrDefault(book => book.ID == Id);
        }
    }
}