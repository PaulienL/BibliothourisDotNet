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
            BookOverview.DataSource = listOfBooks;
            BookOverview.AutoSize = true;
        }

        private void MembersShow_Click(object sender, EventArgs e)
        {
            bookcontroller.ShowMembers();
        }

        private void BookOverview_DoubleClick(object sender, EventArgs e)
        {
            int selectedId = int.Parse(BookOverview.CurrentRow.Cells[0].Value.ToString());
            bookcontroller.ShowDetailsBook(selectedId);
        }
    }
}
