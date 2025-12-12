using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{

    public partial class frmAddBook : Form
    {
        private Library library;
        private frmMainMenu mainMenu;

        public frmAddBook(Library libraryInstance, frmMainMenu mainMenu)
        {
            InitializeComponent();
            library = libraryInstance;
            this.mainMenu = mainMenu;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //return to main menu form
            this.Hide();
            mainMenu.Show();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            // reset all fields in the form to blank
            ResetForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String title = txtTitle.Text;
            String author = txtAuthor.Text;
            String description = txtDescription.Text;
            bool checkedOut = (cboStatus.SelectedItem.ToString() == "Y");
            double mb;

            if (cbSpecifyWhetherEBookOrBook.SelectedItem.ToString() == "Y")
            {   
                // NumberStyles.Any and CultureInfo.InvariantCulture are there so it doesn't reject the decimal point "." as being a String
                if (!double.TryParse(txtSpecifyFileSize.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out mb))
                {
                    MessageBox.Show("Enter a valid number for file size.");
                    return;
                }
                Library.addBook(title, author, description, mb, this.library, checkedOut);
            }

            else
            {
                //If it's mb == -1, that's basically saying it's not an EBook
                Library.addBook(title, author, description, -1, this.library, checkedOut);
            }

            ResetForm();
        }

        private void ResetForm()
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtDescription.Text = "";
            cboStatus.SelectedIndex = 0;
            cbSpecifyWhetherEBookOrBook.SelectedIndex = 0;
            txtSpecifyFileSize.Text = "";
            lblSpecifyFileSizeInMBs.Visible = false;
            txtSpecifyFileSize.Visible = false;
        }
        private void frmAddBook_Load(object sender, EventArgs e)
        {
            
        }

        private void cbSpecifyWhetherEBookOrBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSpecifyWhetherEBookOrBook.SelectedItem.ToString() == "Y")
            {
                lblSpecifyFileSizeInMBs.Visible = true;
                txtSpecifyFileSize.Visible = true;
            }
            else
            {
                lblSpecifyFileSizeInMBs.Visible = false;
                txtSpecifyFileSize.Visible = false;
                txtSpecifyFileSize.Text = "";
            }
        }
    }
}
