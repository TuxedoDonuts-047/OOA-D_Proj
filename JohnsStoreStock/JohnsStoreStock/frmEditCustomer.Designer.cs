namespace LibrarySystem
{
    partial class frmEditCustomer
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtGridResults = new System.Windows.Forms.DataGridView();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboMembership = new System.Windows.Forms.ComboBox();
            this.lblMembership = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridResults)).BeginInit();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(153, 55);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "search by name/phone/email/age...";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(467, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(9, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtGridResults
            // 
            this.dtGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridResults.Location = new System.Drawing.Point(63, 102);
            this.dtGridResults.Name = "dtGridResults";
            this.dtGridResults.Size = new System.Drawing.Size(616, 191);
            this.dtGridResults.TabIndex = 3;
            this.dtGridResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridResults_CellContentClick);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.txtTelephone);
            this.grpResults.Controls.Add(this.txtEmail);
            this.grpResults.Controls.Add(this.txtAge);
            this.grpResults.Controls.Add(this.txtName);
            this.grpResults.Controls.Add(this.cboMembership);
            this.grpResults.Controls.Add(this.lblMembership);
            this.grpResults.Controls.Add(this.lblTelephone);
            this.grpResults.Controls.Add(this.lblEmail);
            this.grpResults.Controls.Add(this.lblAge);
            this.grpResults.Controls.Add(this.lblName);
            this.grpResults.Location = new System.Drawing.Point(78, 344);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(582, 243);
            this.grpResults.TabIndex = 4;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(428, 37);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(100, 20);
            this.txtTelephone.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(98, 198);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(98, 124);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // cboMembership
            // 
            this.cboMembership.FormattingEnabled = true;
            this.cboMembership.Items.AddRange(new object[] {
            "Junior Membership",
            "Adult Membership",
            "Senior Membership"});
            this.cboMembership.Location = new System.Drawing.Point(428, 123);
            this.cboMembership.Name = "cboMembership";
            this.cboMembership.Size = new System.Drawing.Size(121, 21);
            this.cboMembership.TabIndex = 5;
            // 
            // lblMembership
            // 
            this.lblMembership.AutoSize = true;
            this.lblMembership.Location = new System.Drawing.Point(346, 131);
            this.lblMembership.Name = "lblMembership";
            this.lblMembership.Size = new System.Drawing.Size(64, 13);
            this.lblMembership.TabIndex = 4;
            this.lblMembership.Text = "Membership";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(346, 44);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(38, 13);
            this.lblTelephone.TabIndex = 3;
            this.lblTelephone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(33, 205);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(33, 131);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // frmEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 615);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.dtGridResults);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmEditCustomer";
            this.Text = "frmEditCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridResults)).EndInit();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dtGridResults;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label lblMembership;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cboMembership;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
    }
}