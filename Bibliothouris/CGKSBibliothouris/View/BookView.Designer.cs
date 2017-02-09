namespace CGKSBibliothouris
{
    partial class BookView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.miMembersShowAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.miBooksSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.miBooksAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRentals = new System.Windows.Forms.ToolStripMenuItem();
            this.miRentalsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miRentalsFindBook = new System.Windows.Forms.ToolStripMenuItem();
            this.miRentalsFindUser = new System.Windows.Forms.ToolStripMenuItem();
            this.miRentalsFindOverdue = new System.Windows.Forms.ToolStripMenuItem();
            this.BookOverview = new System.Windows.Forms.DataGridView();
            this.AddBook = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnProgram,
            this.mnMembers,
            this.mnBooks,
            this.mnRentals});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnProgram
            // 
            this.mnProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExit,
            this.miLogout});
            this.mnProgram.Name = "mnProgram";
            this.mnProgram.Size = new System.Drawing.Size(65, 20);
            this.mnProgram.Text = "Program";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(112, 22);
            this.miExit.Text = "Exit";
            // 
            // miLogout
            // 
            this.miLogout.Name = "miLogout";
            this.miLogout.Size = new System.Drawing.Size(112, 22);
            this.miLogout.Text = "Logout";
            // 
            // mnMembers
            // 
            this.mnMembers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMembersShowAll});
            this.mnMembers.Name = "mnMembers";
            this.mnMembers.Size = new System.Drawing.Size(69, 20);
            this.mnMembers.Text = "Members";
            // 
            // miMembersShowAll
            // 
            this.miMembersShowAll.Name = "miMembersShowAll";
            this.miMembersShowAll.Size = new System.Drawing.Size(120, 22);
            this.miMembersShowAll.Text = "Show All";
            this.miMembersShowAll.Click += new System.EventHandler(this.MembersShow_Click);
            // 
            // mnBooks
            // 
            this.mnBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miBooksSearch,
            this.miBooksAdd});
            this.mnBooks.Name = "mnBooks";
            this.mnBooks.Size = new System.Drawing.Size(51, 20);
            this.mnBooks.Text = "Books";
            // 
            // miBooksSearch
            // 
            this.miBooksSearch.Name = "miBooksSearch";
            this.miBooksSearch.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.miBooksSearch.Size = new System.Drawing.Size(181, 22);
            this.miBooksSearch.Text = "Search...";
            this.miBooksSearch.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // miBooksAdd
            // 
            this.miBooksAdd.Name = "miBooksAdd";
            this.miBooksAdd.Size = new System.Drawing.Size(181, 22);
            this.miBooksAdd.Text = "Add Book...";
            // 
            // mnRentals
            // 
            this.mnRentals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRentalsNew,
            this.miRentalsFindBook,
            this.miRentalsFindUser,
            this.miRentalsFindOverdue});
            this.mnRentals.Name = "mnRentals";
            this.mnRentals.Size = new System.Drawing.Size(57, 20);
            this.mnRentals.Text = "Rentals";
            // 
            // miRentalsNew
            // 
            this.miRentalsNew.Name = "miRentalsNew";
            this.miRentalsNew.Size = new System.Drawing.Size(154, 22);
            this.miRentalsNew.Text = "New Rental...";
            // 
            // miRentalsFindBook
            // 
            this.miRentalsFindBook.Name = "miRentalsFindBook";
            this.miRentalsFindBook.Size = new System.Drawing.Size(154, 22);
            this.miRentalsFindBook.Text = "Find Book...";
            // 
            // miRentalsFindUser
            // 
            this.miRentalsFindUser.Name = "miRentalsFindUser";
            this.miRentalsFindUser.Size = new System.Drawing.Size(154, 22);
            this.miRentalsFindUser.Text = "Find User...";
            // 
            // miRentalsFindOverdue
            // 
            this.miRentalsFindOverdue.Name = "miRentalsFindOverdue";
            this.miRentalsFindOverdue.Size = new System.Drawing.Size(154, 22);
            this.miRentalsFindOverdue.Text = "Find Overdue...";
            // 
            // BookOverview
            // 
            this.BookOverview.AllowUserToAddRows = false;
            this.BookOverview.AllowUserToDeleteRows = false;
            this.BookOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookOverview.Location = new System.Drawing.Point(12, 27);
            this.BookOverview.MultiSelect = false;
            this.BookOverview.Name = "BookOverview";
            this.BookOverview.ReadOnly = true;
            this.BookOverview.Size = new System.Drawing.Size(410, 248);
            this.BookOverview.TabIndex = 2;
            this.BookOverview.DoubleClick += new System.EventHandler(this.BookOverview_DoubleClick);
            // 
            // AddBook
            // 
            this.AddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBook.Location = new System.Drawing.Point(347, 281);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(75, 23);
            this.AddBook.TabIndex = 3;
            this.AddBook.Text = "Add Book";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            this.AddBook.Enabled = false;
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.BookOverview);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookView";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.frmBookView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnProgram;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem mnMembers;
        private System.Windows.Forms.ToolStripMenuItem miMembersShowAll;
        private System.Windows.Forms.DataGridView BookOverview;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.ToolStripMenuItem mnBooks;
        private System.Windows.Forms.ToolStripMenuItem miBooksSearch;
        private System.Windows.Forms.ToolStripMenuItem miBooksAdd;
        private System.Windows.Forms.ToolStripMenuItem mnRentals;
        private System.Windows.Forms.ToolStripMenuItem miRentalsNew;
        private System.Windows.Forms.ToolStripMenuItem miRentalsFindBook;
        private System.Windows.Forms.ToolStripMenuItem miRentalsFindUser;
        private System.Windows.Forms.ToolStripMenuItem miRentalsFindOverdue;
        private System.Windows.Forms.ToolStripMenuItem miLogout;
    }
}

