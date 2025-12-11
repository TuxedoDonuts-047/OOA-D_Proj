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

namespace LibrarySystem
{
    public partial class frmNewCustomer : Form
    {
        frmMainMenu mainMenu;
        public frmNewCustomer()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //when clicked, adds the customer to the db/list. All fields must have an entry,
            //and telephone and email must not match another customers, uless the customer has the same address and last name of the current customer.

            //validation and confirmation here^^^
            if(string.IsNullOrWhiteSpace(txtName.Text))
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
            if(cboMember.SelectedItem == null)
            {
                MessageBox.Show("Please select a membership status of the customer", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                    MessageBoxIcon.Warning);
        
                return;
            }

            string selectedStatus = cboMember.SelectedItem.ToString();

            Customer aCustomer = new Customer(Customer.getNextAccountID(), txtName.Text, age, txtEmail.Text, txtPhoneNo.Text, selectedStatus);
            Customer.AllCustomers.AddLast(aCustomer);
            txtName.Clear();
            txtAge.Clear();
            txtEmail.Clear();
            txtPhoneNo.Clear();
            cboMember.SelectedItem = "";

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
