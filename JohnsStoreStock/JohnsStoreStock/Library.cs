using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    // SOLID - Open/Closed:
    // The Library class is open for extension (we can add new types of books),
    // but closed for modification (we don’t need to change Book itself).
    public class Library
    {
        // Hard-coded data for prototype (no database)
        private List<Book> books = new List<Book>()
        {
            new Book(1, "The Hobbit", "J.R.R. Tolkien"),
            new Book(2, "1984", "George Orwell"),
            new Book(3, "Clean Code", "Robert C. Martin"),
            new EBook(4, "C# in Depth", "Jon Skeet", 5.2)
        };

        // SOLID - Liskov Substitution:
        // We can store both Book and EBook objects in the same list.
        public List<Book> Books
        {
            get { return books; }
        }

        public Book Search(string name)
        {
            foreach (Book b in books)
            {
                if (b.getTitle.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return b;
                }
            }
            return null;
        }

        public void Checkout(int bookId)
        {
            foreach (Book b in books)
            {
                if (b.getID == bookId)
                {
                    b.Checkout();
                    return;
                }
            }
            Console.WriteLine("Book not found.");
        }

        public void Return(int bookId)
        {
            foreach (Book b in books)
            {
                if (b.getID == bookId)
                {
                    b.ReturnBook();
                    return;
                }
            }
            Console.WriteLine("Book not found.");
        }
    }
}
