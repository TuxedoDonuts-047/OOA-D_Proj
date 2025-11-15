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
        public frmEditBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //return to main manu
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //when pressed, updated the edited books details with new details, title and author must be filled as well as stock amount.

            //validation here, and confirmation to the confirmation
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //when clicked, searches the db/array for given string, and pulls all matches into the data grid view box

            //note, once an item is selected in data grid view box, that selections details will fill into the group box for editing.
        }
    }
}
