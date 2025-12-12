using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{   
    public partial class frmCheckoutBook : Form
    {
        private Library library;
        private frmMainMenu mainMenu;
        public frmCheckoutBook(Library libraryInstance, frmMainMenu mainMenu)
        {
            InitializeComponent();
            library = libraryInstance;
            this.mainMenu = mainMenu;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //return to main menu form
            this.Hide();
            mainMenu.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            // Clear previous results
            dataGridResults.DataSource = null;

            // Simple LINQ query: case-insensitive, starts-with
            var results = library.Books
                .Cast<Book>() // ArrayList → Book objects
                .Where(b => b.getTitle.StartsWith(searchText, StringComparison.OrdinalIgnoreCase) && !b.getCheckOutStatus).ToList();

            dataGridResults.DataSource = results;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dataGridResults.CurrentRow != null) // make sure something is selected
            {
                // Get the bound Book object from the selected row
                Book selectedBook = dataGridResults.CurrentRow.DataBoundItem as Book;

                if (selectedBook != null)
                {
                    selectedBook.Checkout();
                    MessageBox.Show($"Book '{selectedBook.getTitle}' has been checked out.");
                    Book.checkoutCount++;
                    string searchText = txtSearch.Text.Trim();
                    var results = library.Books
                        .Cast<Book>()
                        .Where(b => b.getTitle.StartsWith(searchText, StringComparison.OrdinalIgnoreCase) && !b.getCheckOutStatus)
                        .ToList();

                    dataGridResults.DataSource = null;
                    dataGridResults.DataSource = results;
                }
            }
            else
            {
                MessageBox.Show("Please select a book to checkout.");
            }
        }
    }
}
