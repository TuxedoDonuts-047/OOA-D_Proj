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
        public frmEditCustomer(Customer customerInstance)
        {
            InitializeComponent();
            customer = customerInstance;
        }

        private void dtGridResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //when an item is clicked, the group box fills with relevant infomration according to search string.
            if(e.RowIndex < 0)
            {
                return;
            }
            int selectedID = Convert.ToInt32(dtGridResults.Rows[e.RowIndex].Cells["AccountID"].Value);
            Customer selectedCustomer = Customer.getCustomer(selectedID);

            if(selectedCustomer != null)
            {
                displayCustomerDetails(selectedCustomer);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //searches db/list for strings matching the given string, then fills the data grid box with results for selecton..
            string searchText = txtSearch.Text.Trim().ToLower();

            // Clear previous results
            dtGridResults.DataSource = null;

            // Search through customers
            var results = library.Customers
                .Where(b => b.getName().ToLower().Contains(searchText) ||
                            b.getEmail().ToLower().Contains(searchText))
                .ToList();

            // Display results
            foreach (var customer in results)
            {
                //lstResults.Items.Add(customer); // ToString() will control how it looks
                dtGridResults.DataSource = null;
                dtGridResults.DataSource = results;
            }

            // Optional: show message if no results
            if (results.Count == 0)
            {
                //lstResults.Items.Add("No results found.");
                dtGridResults.DataSource = null;
                dtGridResults.DataSource = "No results found";
            }
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
