using LibrarySystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace JohnsStoreStock
{
    public class Customer
    {
        // AEIP - Encapsulation: Keep fields private to protect the data.
        private int AccountID;
        private string Name;
        private int Age;
        private string Email;
        private string PhoneNo;
        private string MembershipStatus;

        public int AccountIDColumn => AccountID;
        public string NameColumn => Name;
        public int AgeColumn => Age;
        public string EmailColumn => Email;
        public string PhoneNoColumn => PhoneNo;
        public string MembershipStatusColumn => MembershipStatus;

        public static LinkedList<Customer> AllCustomers = new LinkedList<Customer>();
        public LinkedList<Book> CheckedOutBooks { get; set; } = new LinkedList<Book>();
        public static int booksCheckoutCount = 0;

        public int getCheckoutCount => booksCheckoutCount;

        // Constructor
        public Customer(string name, int age, string email, string phoneNo, string membershipStatus)
        {
            this.AccountID = getNextAccountID(); // auto-generate ID
            this.Name = name;
            this.Age = age;
            this.Email = email;
            this.PhoneNo = phoneNo;
            this.MembershipStatus = membershipStatus;

            // Add to global list of customers
            AllCustomers.AddLast(this);
        }

        

        // Public properties to safely access data (Encapsulation)
        public int getAccountID()
        {
            return AccountID;
        }
        public string getName()
        {
            return Name;
        }
        public int getAge()
        {
            return Age;
        }
        public string getEmail()
        {
            return Email;
        }
        public string getPhoneNo()
        {
            return PhoneNo;
        }
        public string getMembershipStatus()
        {
            return MembershipStatus;
        }
        
        public void setAccountID(int accountID)
        {
            this.AccountID = accountID;
        }
        public void setName(string name)
        {
            this.Name = name;
        }
        public void setAge(int age)
        {
            this.Age = age;
        }
        public void setEmail(string email)
        {
            this.Email = email;
        }
        public void setPhoneNo(string phoneNo)
        {
            this.PhoneNo = phoneNo;
        }
        public void setMembershipStatus(string membershipStatus)
        {
            this.MembershipStatus = membershipStatus;
        }
        
        public void ShowCheckedOutBooks(string text)
        {
            Console.WriteLine($"{Name}'s Checked Out Books:");
            if(CheckedOutBooks.Count == 0)
            {
                Console.WriteLine(" - No books currently checked out.");
                return;
            }
            foreach (var book in CheckedOutBooks)
            {
                Console.WriteLine(" - ID: " + book.getID + ", Title: " + book.getTitle + ", Author: " + book.getAuthor);
            }
        }
        public override string ToString()
        {
            return "";
        }

        public static int getNextAccountID()
        {
            if(AllCustomers.Count == 0)
            {
                return 1;
            }
            int maxID = AllCustomers.Max(c => c.AccountID);
            return maxID + 1;
        }

        public static Customer getCustomer(int id)
        {
            foreach (Customer c in AllCustomers)
            {
                if (c.AccountID == id)
                    return c;
            }
            
            return null; // Not found
        }
    }
}
