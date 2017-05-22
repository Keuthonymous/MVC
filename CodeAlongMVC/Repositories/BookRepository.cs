using CodeAlongMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeAlongMVC.Repositories
{
    public class BookRepository
    {
        private static List<Book> context = new List<Book>{
                new Book {ID=1, ISBN="111", Author="Stephen King", Title="Cell", Description="Horror"},
                new Book {ID=2, ISBN="112", Author="Stephen King", Title="It", Description="Horror"},
                new Book {ID=3, ISBN="113", Author="Diana Wynn Jones", Title="Howl's Moving Castle", Description="Fantasy"} 
            };

        public static IEnumerable<Book> GetAllBooks()
        {
            return context.ToList();
        }

        public static Book GetBookById(int Id)
        {
            return context.SingleOrDefault(book => book.ID == Id);
        }

        public static void  AddNewBook(Book book)
        {
            int next = context.Max(b => b.ID) + 1;
            book.ID = next;
            context.Add(book);
        }

        public static void RemoveBook(Book b)
        {
            context.Remove(b);
        }
    }
}