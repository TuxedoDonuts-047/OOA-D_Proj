namespace LibrarySystem
{
    partial class frmAddBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCheckedOut = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSpecifyWhetherEBookOrBook = new System.Windows.Forms.ComboBox();
            this.txtSpecifyFileSize = new System.Windows.Forms.TextBox();
            this.lblSpecifyFileSizeInMBs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(2, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 32);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(107, 69);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(107, 96);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Author";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(107, 118);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // lblCheckedOut
            // 
            this.lblCheckedOut.AutoSize = true;
            this.lblCheckedOut.Location = new System.Drawing.Point(107, 188);
            this.lblCheckedOut.Name = "lblCheckedOut";
            this.lblCheckedOut.Size = new System.Drawing.Size(76, 13);
            this.lblCheckedOut.TabIndex = 6;
            this.lblCheckedOut.Text = "Checked Out?";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(201, 62);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(182, 20);
            this.txtTitle.TabIndex = 7;
            this.txtTitle.Text = "Title Here...";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(201, 89);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(182, 20);
            this.txtAuthor.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(201, 115);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(182, 60);
            this.txtDescription.TabIndex = 9;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "N",
            "Y"});
            this.cboStatus.Location = new System.Drawing.Point(201, 185);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 21);
            this.cboStatus.TabIndex = 11;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(237, 8);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 12;
            this.btnreset.Text = "Reset Form";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "EBook?";
            // 
            // cbSpecifyWhetherEBookOrBook
            // 
            this.cbSpecifyWhetherEBookOrBook.FormattingEnabled = true;
            this.cbSpecifyWhetherEBookOrBook.Items.AddRange(new object[] {
            "N",
            "Y"});
            this.cbSpecifyWhetherEBookOrBook.Location = new System.Drawing.Point(201, 211);
            this.cbSpecifyWhetherEBookOrBook.Name = "cbSpecifyWhetherEBookOrBook";
            this.cbSpecifyWhetherEBookOrBook.Size = new System.Drawing.Size(121, 21);
            this.cbSpecifyWhetherEBookOrBook.TabIndex = 14;
            this.cbSpecifyWhetherEBookOrBook.SelectedIndexChanged += new System.EventHandler(this.cbSpecifyWhetherEBookOrBook_SelectedIndexChanged);
            // 
            // txtSpecifyFileSize
            // 
            this.txtSpecifyFileSize.Location = new System.Drawing.Point(201, 238);
            this.txtSpecifyFileSize.Name = "txtSpecifyFileSize";
            this.txtSpecifyFileSize.Size = new System.Drawing.Size(121, 20);
            this.txtSpecifyFileSize.TabIndex = 15;
            this.txtSpecifyFileSize.Visible = false;
            // 
            // lblSpecifyFileSizeInMBs
            // 
            this.lblSpecifyFileSizeInMBs.AutoSize = true;
            this.lblSpecifyFileSizeInMBs.Location = new System.Drawing.Point(69, 241);
            this.lblSpecifyFileSizeInMBs.Name = "lblSpecifyFileSizeInMBs";
            this.lblSpecifyFileSizeInMBs.Size = new System.Drawing.Size(126, 13);
            this.lblSpecifyFileSizeInMBs.TabIndex = 16;
            this.lblSpecifyFileSizeInMBs.Text = "Specify File Size [In MBs]";
            this.lblSpecifyFileSizeInMBs.Visible = false;
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.lblSpecifyFileSizeInMBs);
            this.Controls.Add(this.txtSpecifyFileSize);
            this.Controls.Add(this.cbSpecifyWhetherEBookOrBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblCheckedOut);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Name = "frmAddBook";
            this.Text = "frmAddBook";
            this.Load += new System.EventHandler(this.frmAddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCheckedOut;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSpecifyWhetherEBookOrBook;
        private System.Windows.Forms.TextBox txtSpecifyFileSize;
        private System.Windows.Forms.Label lblSpecifyFileSizeInMBs;
    }
}