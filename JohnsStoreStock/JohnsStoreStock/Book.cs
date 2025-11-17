using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    // AEIP - Abstraction: This class represents the concept of a Book.
    // We hide the details of how it works internally (like how checkout or return is handled).
    public class Book
    {
        // AEIP - Encapsulation: Keep fields private to protect the data.
        private int id;
        private string title;
        private string author;
        private bool isCheckedOut;

        // Constructor
        public Book(int id, string title, string author)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.isCheckedOut = false;
        }

        // Public properties to safely access data (Encapsulation)
        public int getID { 
            get { 
                return id;    
            }
        }
        public string getTitle {
            get {
                return title;
            }
        }
        public string getAuthor { 
            get {
                return author; 
            }
        }

        public bool getCheckOutStatus{
            get { 
                return isCheckedOut; 
            } 
        }

        // SOLID, Single Responsibility:
        // this class only deals with book related actions, not UI or database.
        public void Checkout()
        {
            if (isCheckedOut)
            {
                Console.WriteLine("'" + title + "' is already checked out.");
            }
            else
            {
                isCheckedOut = true;
                Console.WriteLine("You checked out '" + title + "'.");
            }
        }

        public void ReturnBook()
        {
            if (!isCheckedOut)
            {
                Console.WriteLine(" ' " + title + " ' was not checked out.");
            }
            else
            {
                isCheckedOut = false;
                Console.WriteLine("You returned '" + title + "'.");
            }
        }

        // AEIP - Polymorphism: This method can be overridden later by subclasses (like EBook).
        public virtual void displayBookInfo()
        {
            Console.WriteLine("[" + id + "] " + title + " by " + author + " - " + (isCheckedOut ? "Checked Out" : "Available"));
        }
    }
}
