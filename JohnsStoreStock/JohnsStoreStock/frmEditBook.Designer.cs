namespace JohnsStoreStock
{
    partial class frmEditBook
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
            this.dataGridResults = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtSizeInMBs = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblSizeInMBs = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).BeginInit();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridResults
            // 
            this.dataGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResults.Location = new System.Drawing.Point(98, 65);
            this.dataGridResults.Name = "dataGridResults";
            this.dataGridResults.Size = new System.Drawing.Size(597, 218);
            this.dataGridResults.TabIndex = 1;
            this.dataGridResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridResults_CellContentClick);
            this.dataGridResults.SelectionChanged += new System.EventHandler(this.dataGridResults_SelectionChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(98, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(597, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "search by title....";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.btnConfirm);
            this.grpDetails.Controls.Add(this.txtSizeInMBs);
            this.grpDetails.Controls.Add(this.txtDescription);
            this.grpDetails.Controls.Add(this.txtAuthor);
            this.grpDetails.Controls.Add(this.txtTitle);
            this.grpDetails.Controls.Add(this.lblSizeInMBs);
            this.grpDetails.Controls.Add(this.lblDescription);
            this.grpDetails.Controls.Add(this.lblAuthor);
            this.grpDetails.Controls.Add(this.lblTitle);
            this.grpDetails.Location = new System.Drawing.Point(74, 334);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(666, 250);
            this.grpDetails.TabIndex = 4;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Book Details";
            this.grpDetails.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(254, 181);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(124, 49);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtSizeInMBs
            // 
            this.txtSizeInMBs.Location = new System.Drawing.Point(450, 126);
            this.txtSizeInMBs.Name = "txtSizeInMBs";
            this.txtSizeInMBs.Size = new System.Drawing.Size(100, 20);
            this.txtSizeInMBs.TabIndex = 7;
            this.txtSizeInMBs.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(448, 41);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(212, 62);
            this.txtDescription.TabIndex = 6;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(89, 126);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(218, 20);
            this.txtAuthor.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(89, 41);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(218, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // lblSizeInMBs
            // 
            this.lblSizeInMBs.AutoSize = true;
            this.lblSizeInMBs.Location = new System.Drawing.Point(382, 129);
            this.lblSizeInMBs.Name = "lblSizeInMBs";
            this.lblSizeInMBs.Size = new System.Drawing.Size(62, 13);
            this.lblSizeInMBs.TabIndex = 3;
            this.lblSizeInMBs.Text = "Size in MBs";
            this.lblSizeInMBs.Visible = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(382, 44);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(45, 129);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(56, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // frmEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 629);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridResults);
            this.Controls.Add(this.btnBack);
            this.Name = "frmEditBook";
            this.Text = "frmEditBook";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).EndInit();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridResults;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Label lblSizeInMBs;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSizeInMBs;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnConfirm;
    }
}