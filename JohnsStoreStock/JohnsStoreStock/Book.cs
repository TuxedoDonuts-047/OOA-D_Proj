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
        private string description;
        public bool isCheckedOut;
        public static int checkoutCount = 0;

        public int getCheckoutCount => checkoutCount;

        // Constructor
        public Book(int id, string title, string author, string description)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.description = description;
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
        public string getDescription
        {
            get
            {
                return description;
            }
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public void setAuthor(string author)
        {
            this.author = author;
        }

        public void setDescription(string description)
        {
            this.description = description;
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
        public override string ToString()
        {
            return $"[{id}] {title} by {author}";
        }
    }
}
