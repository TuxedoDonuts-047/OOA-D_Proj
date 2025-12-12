using JohnsStoreStock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LibrarySystem
{
    public partial class frmReturnBook : Form
    {
        private Library library;
        private Customer customer;
        public frmMainMenu mainMenu;
        private frmMainMenu frmMainMenu;

        public frmReturnBook(Library library, frmMainMenu frmMainMenu)
        {
            InitializeComponent();
            this.library = library;
            this.frmMainMenu = frmMainMenu;
            Customer customer = Customer.AllCustomers.FirstOrDefault(c => c.getName() == cboName.Text);

        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            var customer = Customer.AllCustomers.FirstOrDefault(c => c.getName() == cboName.Text);
            if (customer != null && !string.IsNullOrEmpty(txtTitle.Text))
            {
                Book selectedBook = customer.CheckedOutBooks.FirstOrDefault(b => b.getTitle == txtTitle.Text);

                if (selectedBook != null)
                {
                    library.Return(selectedBook.getID);
                    customer.CheckedOutBooks.Remove(selectedBook);

                    MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book not found in customer's checked-out list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a customer and a book.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboName.Select();
            }
        }

        private void ResetForm()
        {
            cboName.Text = "";
            txtTitle.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            this.Hide();
            mainMenu.Visible = true;
        }

        private void frmReturnBook_Load(object sender, EventArgs e)
        {
            cboName.DataSource = Customer.AllCustomers.Select(c => c.getName()).ToList();
            cboName.SelectedIndex = -1;
        }

        private void cboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var customer = Customer.AllCustomers.FirstOrDefault(c => c.getName() == cboName.Text);
            if (customer != null && customer.CheckedOutBooks.Any())
            {
                txtTitle.Text = customer.CheckedOutBooks.First().getTitle;
            }
            else
            {
                txtTitle.Text = string.Empty;
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
