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
        private Book book;
        public frmMainMenu mainMenu;
        private frmMainMenu frmMainMenu;

        public frmReturnBook(Library library, frmMainMenu frmMainMenu)
        {
            InitializeComponent();
            this.library = library;
            this.frmMainMenu = frmMainMenu;
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (cboName.Text != ("") && txtTitle.Text != ("")) // If both are selected.
            {
               // Book.ReturnBook();
            }
            else
            {
                MessageBox.Show("There is nothing selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //Will default to this
                //Library.Return();
            }

            ResetForm();
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
            /*  cboName.DataSource = library.Books.Select(b => b.getAuthor).ToList();
           cboName.SelectedIndex = -1;
           cboTitle.DataSource = library.Books.Select(b => b.getTitle).ToList();
           cboTitle.SelectedIndex = -1*/   

        }

        private void cboName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
