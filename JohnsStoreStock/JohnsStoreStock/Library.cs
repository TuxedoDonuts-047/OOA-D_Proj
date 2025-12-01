using JohnsStoreStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    // SOLID - Open/Closed:
    // The Library class is open for extension (we can add new types of books),
    // but closed for modification (we don’t need to change Book itself).
    public class Library
    {
        public LinkedList<Customer> Customers { get; set; }
        // Hard-coded data for prototype (no database)
        public List<Book> books = new List<Book>()
        {
            new Book(1, "The Hobbit", "J.R.R. Tolkien", "Fantastic series"),
            new Book(2, "1984", "George Orwell", "Fantastic series"),
            new Book(3, "Clean Code", "Robert C. Martin", "Fantastic series"),
            new EBook(4, "C# in Depth", "Jon Skeet", 5.2, "Fantastic series")
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

        public static void addBook(String title, String author, String description, Double sizeInMBs, Library library, bool checkedOut)
        {
            //adds book to DB/ArrayList as long as all fields have been filled and it does not clash with another stock

            // Basic validation
            if (string.IsNullOrWhiteSpace(title) ||
                string.IsNullOrWhiteSpace(author))
            {
                MessageBox.Show("Title and Author are required.");
                return;
            }

            // Generate a new ID automatically
            int newId = library.Books.Count + 1;

            Book bookToAdd;

            // Is it an EBook?
            if (sizeInMBs == -1)
            {
                Book b = new Book(newId, title, author, description);
                if (checkedOut)
                    b.Checkout();
                bookToAdd = b;
            }
            else
            {
                // Create a ebook
                EBook eb = new EBook(newId, title, author, sizeInMBs, description);
                // Set its checked-out status
                if (checkedOut)
                    eb.Checkout();
                bookToAdd = eb;
            }

            // Add to the library
            library.Books.Add(bookToAdd);
            MessageBox.Show("Book Added Successfully!");
        }


    }
}
