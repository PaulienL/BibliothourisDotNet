using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGKSBibliothouris.Controller;
using CGKSBibliothouris.Model.DomainModels;

namespace CGKSBibliothouris.View
{
    public partial class BookSearchResults : Form
    {
        private BookController controller;

        public BookSearchResults()
        {
            InitializeComponent();
        }

        public void AddController(BookController controller)
        {
            this.controller = controller;
        }

        public void UpdateDataInLstBook(List<Book> listOfBooks) {
            BookOverview.DataSource = typeof(List<Book>);
            BookOverview.DataSource = listOfBooks;
            BookOverview.Refresh();
            BookOverview.AutoSize = true;
        }

        private void BookOverview_DoubleClick(object sender, EventArgs e) {
            int selectedId = int.Parse(BookOverview.CurrentRow.Cells[0].Value.ToString());
            controller.ShowDetailsBook(selectedId);
        }

    }
}
