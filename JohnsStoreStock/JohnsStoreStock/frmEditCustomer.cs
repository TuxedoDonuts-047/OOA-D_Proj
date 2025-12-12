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
    public partial class frmEditCustomer : Form
    {
        private frmMainMenu mainMenu;
        private Customer customer;
        private Library library;
        public frmEditCustomer(Library lib, frmMainMenu menu, Customer customerInstance = null)
        {
            InitializeComponent();
            library = lib; 
            mainMenu = menu;
            customer = customerInstance;
        }
        public frmEditCustomer(Library lib)
        {
            InitializeComponent();
            library = lib; // now library is initialized
        }

        public frmEditCustomer()
        {
            InitializeComponent();
        }

        private void dtGridResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int selectedID = Convert.ToInt32(dtGridResults.Rows[e.RowIndex].Cells["AccountID"].Value);
            Customer selectedCustomer = Customer.getCustomer(selectedID);

            if (selectedCustomer != null)
            {
                displayCustomerDetails(selectedCustomer);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            // Clear previous results
            dtGridResults.DataSource = null;

            if (library?.Customers == null || library.Customers.Count == 0)
            {
                MessageBox.Show("No customers available.");
                return;
            }

            // Convert LinkedList to List and create objects for DataGridView
            var results = library.Customers
                .Where(c => c.getName().ToLower().Contains(searchText) || c.getEmail().ToLower().Contains(searchText))
                .Select(c => new
                {
                    AccountID = c.getAccountID(),
                    Name = c.getName(),
                    Age = c.getAge(),
                    Email = c.getEmail(),
                    PhoneNo = c.getPhoneNo(),
                    Membership = c.getMembershipStatus()
                })
                .ToList();

            if (results.Count == 0)
            {
                MessageBox.Show("No results found.");
                dtGridResults.DataSource = null;
                return;
            }

            dtGridResults.DataSource = results;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //returns to main menu
            this.Hide();
            mainMenu.Show();
        }

        private void displayCustomerDetails(Customer c)
        {
            txtName.Text = c.getName();
            txtAge.Text = c.getAge().ToString();
            txtEmail.Text = c.getEmail();
            txtTelephone.Text = c.getPhoneNo();
            cboMembership.Text = c.getMembershipStatus();
        }
    }
}
