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

    public partial class frmAddBook : Form
    {
        Library library = new Library();
        public frmAddBook()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //return to main menu form
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            // reset all fields in the form to blank
            ResetForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //adds book to DB/ArrayList as long as all fields have been filled and it does not clash with another stock
       
            // Basic validation
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Title and Author are required.");
                return;
            }

            // Generate a new ID automatically
            int newId = library.Books.Count + 1;

            // Get checked-out status
            bool checkedOut = (cboStatus.SelectedItem.ToString() == "Y");

            Book bookToAdd;

            // Is it an EBook?
            if (cbSpecifyWhetherEBookOrBook.SelectedItem.ToString() == "Y")
            {
                double mb;

                if (!double.TryParse(txtSpecifyFileSize.Text, out mb))
                {
                    MessageBox.Show("Enter a valid number for file size.");
                    return;
                }

                // Create the EBook
                EBook eb = new EBook(newId, txtTitle.Text, txtAuthor.Text, mb);

                // Set its checked-out status
                if (checkedOut)
                    eb.Checkout();

                bookToAdd = eb;
            }
            else
            {
                // Create a normal Book
                Book b = new Book(newId, txtTitle.Text, txtAuthor.Text);

                if (checkedOut)
                    b.Checkout();

                bookToAdd = b;
            }

            // Add to the library
            library.Books.Add(bookToAdd);

            MessageBox.Show("Book Added Successfully!");

            ResetForm();
        }

        private void ResetForm()
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtDescription.Text = "";

            cboStatus.SelectedIndex = 0; // CheckOut CB
            cbSpecifyWhetherEBookOrBook.SelectedIndex = 0;

            txtSpecifyFileSize.Text = "";
            lblSpecifyFileSizeInMBs.Visible = false;
            txtSpecifyFileSize.Visible = false;
        }


        private void frmAddBook_Load(object sender, EventArgs e)
        {

        }

        private void cbSpecifyWhetherEBookOrBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSpecifyWhetherEBookOrBook.SelectedItem.ToString() == "Y")
            {
                lblSpecifyFileSizeInMBs.Visible = true;
                txtSpecifyFileSize.Visible = true;
            }
            else
            {
                lblSpecifyFileSizeInMBs.Visible = false;
                txtSpecifyFileSize.Visible = false;
                txtSpecifyFileSize.Text = "";
            }
        }
    }
}
