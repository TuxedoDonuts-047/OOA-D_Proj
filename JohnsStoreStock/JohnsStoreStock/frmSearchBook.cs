using LibrarySystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JohnsStoreStock
{
    public partial class frmSearchBook : Form
    {
        private Library library;
        public frmSearchBook(Library libraryInstance)
        {
            InitializeComponent();
            library = libraryInstance;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();

            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            // Clear previous results
            lstResults.Items.Clear();

            // Search through books
            var results = library.Books
                .Where(b => b.getTitle.ToLower().Contains(searchText) ||
                            b.getAuthor.ToLower().Contains(searchText) ||
                            (b is EBook ebook && ebook.Description.ToLower().Contains(searchText)))
                .ToList();

            foreach (var book in results)
            {
                lstResults.Items.Add(book); 
            }
            if (results.Count == 0)
            {
                lstResults.Items.Add("No results found.");
            }
        }

        private void lstResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstResults.SelectedItem is Book selectedBook)
            {
                MessageBox.Show(
                    $"ID: {selectedBook.getID}\n" +
                    $"Title: {selectedBook.getTitle}\n" +
                    $"Author: {selectedBook.getAuthor}\n" +
                    $"Status: {(selectedBook.getCheckOutStatus ? "Checked Out" : "Available")}",
                    "Book Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
