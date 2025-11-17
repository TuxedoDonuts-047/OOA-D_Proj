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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //adds book to DB/ArrayList as long as all fields have been filled and it does not clash with another stock
        }

        private void frmAddBook_Load(object sender, EventArgs e)
        {

        }
    }
}
