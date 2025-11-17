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
        public frmEditCustomer()
        {
            InitializeComponent();
        }

        private void dtGridResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //when an item is clicked, the group box fills with relevant infomration according to search string.
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //searches db/list for strings matching the given string, then fills the data grid box with results for selecton..
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //returns to main menu
        }
    }
}
