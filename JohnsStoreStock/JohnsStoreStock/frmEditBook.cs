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
    public partial class frmEditBook : Form
    {
        private Library library;
        private frmMainMenu mainMenu;
        private Book selectedBook; // keep track of which book is being edited

        public frmEditBook(Library libraryInstance, frmMainMenu mainMenu)
        {
            InitializeComponent();
            library = libraryInstance;
            this.mainMenu = mainMenu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //return to main manu
            this.Hide();
            mainMenu.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //when pressed, updated the edited books details with new details, title and author must be filled

            //validation here, and confirmation to the confirmation

            if (selectedBook == null)
            {
                MessageBox.Show("No book selected.");
                return;
            }

            // Basic validation
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                (txtSizeInMBs.Visible && string.IsNullOrWhiteSpace(txtSizeInMBs.Text)))
            {
                MessageBox.Show("All fields must contain at least 1 character.");
                return;
            }

            // Update book fields
            selectedBook.setTitle(txtTitle.Text.Trim());
            selectedBook.setAuthor(txtAuthor.Text.Trim());
            selectedBook.setDescription(txtDescription.Text.Trim());

            if (selectedBook is EBook ebook)
            {
                if (double.TryParse(txtSizeInMBs.Text.Trim(), out double size))
                {
                    ebook.SetFileSizeMB(size);
                }
                else
                {
                    MessageBox.Show("Size in MBs must be a valid number.");
                    return;
                }
            }

            MessageBox.Show("Book updated successfully!");
            grpDetails.Visible = false; // hide details again if you want
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //when clicked, searches the db/array for given string, and pulls all matches into the data grid view box

            //note, once an item is selected in data grid view box, that selections details will fill into the group box for editing.
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            // Clear previous results
            dataGridResults.DataSource = null;

            // Simple LINQ query: case-insensitive, starts-with
            var results = library.Books
                .Cast<Book>() // ArrayList → Book objects
                .Where(b => b.getTitle.StartsWith(searchText, StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Bind results to DataGridView
            dataGridResults.DataSource = results;
        }

        private void dataGridResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridResults_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridResults.CurrentRow != null)
            {
                selectedBook = dataGridResults.CurrentRow.DataBoundItem as Book;
                if (selectedBook != null)
                {
                    // Show details group
                    grpDetails.Visible = true;

                    // Fill textboxes
                    txtTitle.Text = selectedBook.getTitle;
                    txtAuthor.Text = selectedBook.getAuthor;
                    txtDescription.Text = selectedBook.getDescription;

                    // If it's an EBook, show and fill size
                    if (selectedBook is EBook ebook)
                    {
                        txtSizeInMBs.Visible = true;
                        txtSizeInMBs.Text = ebook.GetFileSizeMB().ToString();
                        lblSizeInMBs.Visible = true;
                    }
                    else
                    {
                        txtSizeInMBs.Visible = false;
                    }
                }
            }
        }
    }
}
