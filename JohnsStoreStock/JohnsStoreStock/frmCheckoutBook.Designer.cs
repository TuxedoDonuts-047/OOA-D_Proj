namespace LibrarySystem
{
    partial class frmCheckoutBook
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
            this.dataGridResults = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(164, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(443, 20);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.Text = "search by title....";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridResults
            // 
            this.dataGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResults.Location = new System.Drawing.Point(83, 55);
            this.dataGridResults.Name = "dataGridResults";
            this.dataGridResults.Size = new System.Drawing.Size(597, 218);
            this.dataGridResults.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(69, 26);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(328, 279);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(124, 49);
            this.btnCheckout.TabIndex = 13;
            this.btnCheckout.Text = "Checkout Book";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // frmCheckoutBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridResults);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCheckout);
            this.Name = "frmCheckoutBook";
            this.Text = "frmCheckoutBook";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridResults;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCheckout;
    }
}