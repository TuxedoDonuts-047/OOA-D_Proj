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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibrarySystem
{
    public partial class frmNewCustomer : Form
    {
        frmMainMenu mainMenu;
        private Customer customer;
        private Library library;
        public frmNewCustomer(Library lib, frmMainMenu menu, Customer customerInstance = null)
        {
            InitializeComponent();
            library = lib;
            mainMenu = menu;
            customer = customerInstance;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please re-enter the customer's name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Please re-enter the customer's age", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please re-enter the customer's email address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhoneNo.Text))
            {
                MessageBox.Show("Please re-enter the customer's phone number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNo.Focus();
                return;
            }
            if (cboMember.SelectedItem == null)
            {
                MessageBox.Show("Please select a membership status of the customer", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for duplicates
            string[] nameParts = txtName.Text.Trim().Split(' ');
            string lastName = nameParts[nameParts.Length - 1];

            bool conflictExists = Customer.AllCustomers.Any(c =>
                (c.getEmail() == txtEmail.Text || c.getPhoneNo() == txtPhoneNo.Text) &&
                !(c.getName().Equals(lastName, StringComparison.OrdinalIgnoreCase))
            );

            if (conflictExists)
            {
                MessageBox.Show(
                    "This phone number or email is already in use by another customer.",
                    "Duplicate Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Create new customer
            string selectedStatus = cboMember.SelectedItem.ToString();
            Customer aCustomer = new Customer(txtName.Text, age, txtEmail.Text, txtPhoneNo.Text, selectedStatus);
            library.Customers.AddLast(aCustomer);

            // At this point, the constructor already adds it to AllCustomers.

            // Clear form
            txtName.Clear();
            txtAge.Clear();
            txtEmail.Clear();
            txtPhoneNo.Clear();
            cboMember.SelectedItem = null;

            // Show confirmation
            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //returns to main menu
            this.Hide();
            mainMenu.Show();
        }

        private void cboMember_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
