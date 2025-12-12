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

namespace LibrarySystem
{

    public partial class frmBookAnalysis : Form
    {
        private Library library;
        public frmBookAnalysis(Library libraryInstance)
        {
            InitializeComponent();
            library = libraryInstance;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            lstResults.Items.Clear();

            var results = library.Books
                .Where(b => b.getTitle.ToLower().Contains(searchText) ||
                            b.getAuthor.ToLower().Contains(searchText) ||
                            (b is EBook ebook && ebook.Description.ToLower().Contains(searchText))).ToList();

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
                string details =
                    $"Title: {selectedBook.getTitle}\n" +
                    $"Author: {selectedBook.getAuthor}\n\n" +
                    $"Description:\n{selectedBook.getDescription}\n\n" +
                    $"Status: {(selectedBook.getCheckOutStatus ? "Checked Out" : "Available")}\n" +
                    $"Times Checked Out: {selectedBook.getCheckoutCount}";

                MessageBox.Show(details, "Book Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();

            this.Hide();
        }
    }
}
