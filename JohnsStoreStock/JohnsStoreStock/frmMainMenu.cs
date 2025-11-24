using JohnsStoreStock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class frmMainMenu : Form
    {
        private Library library;  // shared instance
        public frmMainMenu()
        {
            InitializeComponent();
            library = new Library(); // create it ONCE here
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            //image used: https://www.nli.ie/sites/default/files/styles/image_with_caption_narrow/public/2022-10/nli-oct-screen-res-56.webp?h=78aab1d8&itok=qDrjbLV4
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddBook addBookForm = new frmAddBook(library, this);
            this.Hide();
            addBookForm.Show();

            this.Hide();
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditBook editBookForm = new frmEditBook(library, this);
            this.Hide();
            editBookForm.Show();

            this.Hide();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewCustomer addCustomerForm = new frmNewCustomer();
            this.Hide();
            addCustomerForm.Show();

            this.Hide();
        }

        private void editCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditCustomer editCustomerForm = new frmEditCustomer();
            this.Hide();
            editCustomerForm.Show();

            this.Hide();
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchBook searchBookForm = new frmSearchBook(library);
            this.Hide();
            searchBookForm.Show();

            this.Hide();
        }

        private void checkoutBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckoutBook checkoutBookForm = new frmCheckoutBook(library, this);
            this.Hide();
            checkoutBookForm.Show();

            this.Hide();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReturnBook returnBookForm = new frmReturnBook(library, this);
            this.Hide();
            returnBookForm.Show();

            this.Hide();
        }

        private void bookAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookAnalysis bookAnalysisForm = new frmBookAnalysis(library);
            this.Hide();
            bookAnalysisForm.Show();

            this.Hide();
        }
    }
}
