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
        public frmNewCustomer()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //when clicked, adds the customer to the db/list. All fields must have an entry,
            //and telephone and email must not match another customers, uless the customer has the same address and last name of the current customer.

            //validation and confirmation here^^^
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //returns to main menu
        }
    }
}
