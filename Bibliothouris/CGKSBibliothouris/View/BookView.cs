using CGKSBibliothouris.Controller;
using CGKSBibliothouris.Model.DomainModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGKSBibliothouris.View;

namespace CGKSBibliothouris
{
    public partial class BookView : Form
    {
        private BookController bookcontroller;

        public BookView()
        {
            InitializeComponent();
            this.AutoSize = true;
        }

        internal void AddController(BookController bookController)
        {
            this.bookcontroller = bookController;
        }

        private void frmBookView_Load(object sender, EventArgs e)
        {
            UpdateDataInLstBook(bookcontroller.GetAllBooks());
        }

        public void UpdateDataInLstBook(List<Book> listOfBooks)
        {
            BookOverview.DataSource = typeof(List<Book>);
            BookOverview.DataSource = listOfBooks;
            BookOverview.Refresh();
            BookOverview.AutoSize = true;
        }

        private void MembersShow_Click(object sender, EventArgs e)
        {
            bookcontroller.ShowMembers();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            bookcontroller.AddBookView();
        }

        private void BookOverview_DoubleClick(object sender, EventArgs e)
        {
            int selectedId = int.Parse(BookOverview.CurrentRow.Cells[0].Value.ToString());
            bookcontroller.ShowDetailsBook(selectedId);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e) {
            SearchBookView search = new SearchBookView(bookcontroller);
            search.ShowDialog();
        }

        public void SetRights(string personRole)
        {
            if (personRole.ToUpper().Equals("MEMBER"))
            {
                mnMembers.Enabled = false;
                miBooksAdd.Enabled = false;
                AddBook.Enabled = false;
                mnRentals.Enabled = false;
            }
            else
            {
                mnMembers.Enabled = true;
                miBooksAdd.Enabled = true;
                AddBook.Enabled = true;
                mnRentals.Enabled = true;
            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            bookcontroller.Exit();
        }
    }
}
