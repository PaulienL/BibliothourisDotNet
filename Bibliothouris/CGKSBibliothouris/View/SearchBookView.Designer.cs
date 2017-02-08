namespace CGKSBibliothouris.View
{
    partial class SearchBookView
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdbTitle = new System.Windows.Forms.RadioButton();
            this.rdbAuthor = new System.Windows.Forms.RadioButton();
            this.rdnIsbn = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(86, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(165, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // rdbTitle
            // 
            this.rdbTitle.AutoSize = true;
            this.rdbTitle.Location = new System.Drawing.Point(15, 18);
            this.rdbTitle.Name = "rdbTitle";
            this.rdbTitle.Size = new System.Drawing.Size(45, 17);
            this.rdbTitle.TabIndex = 2;
            this.rdbTitle.Text = "Title";
            this.rdbTitle.UseVisualStyleBackColor = true;
            // 
            // rdbAuthor
            // 
            this.rdbAuthor.AutoCheck = false;
            this.rdbAuthor.AutoSize = true;
            this.rdbAuthor.Location = new System.Drawing.Point(66, 18);
            this.rdbAuthor.Name = "rdbAuthor";
            this.rdbAuthor.Size = new System.Drawing.Size(56, 17);
            this.rdbAuthor.TabIndex = 3;
            this.rdbAuthor.Text = "Author";
            this.rdbAuthor.UseVisualStyleBackColor = true;
            // 
            // rdnIsbn
            // 
            this.rdnIsbn.AutoSize = true;
            this.rdnIsbn.Location = new System.Drawing.Point(128, 18);
            this.rdnIsbn.Name = "rdnIsbn";
            this.rdnIsbn.Size = new System.Drawing.Size(50, 17);
            this.rdnIsbn.TabIndex = 5;
            this.rdnIsbn.Text = "ISBN";
            this.rdnIsbn.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(33, 127);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdnIsbn);
            this.panel1.Controls.Add(this.rdbTitle);
            this.panel1.Controls.Add(this.rdbAuthor);
            this.panel1.Location = new System.Drawing.Point(64, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 48);
            this.panel1.TabIndex = 8;
            // 
            // SearchBookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 187);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "SearchBookView";
            this.Text = "SearchBookView";
            this.Load += new System.EventHandler(this.SearchBookView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdbTitle;
        private System.Windows.Forms.RadioButton rdbAuthor;
        private System.Windows.Forms.RadioButton rdnIsbn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
    }
}