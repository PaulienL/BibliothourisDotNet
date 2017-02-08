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
    public partial class frmBookView : Form
    {
        private BookController bookcontroller;

        public frmBookView()
        {
            InitializeComponent();
            bookcontroller = new BookController();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmBookView_Load(object sender, EventArgs e)
        {
            UpdateDataInLstBook(bookcontroller.GetAllBooks());
        }

        private void UpdateDataInLstBook(List<Book> listOfBooks)
        {
            BookOverview.DataSource = listOfBooks;            
        }

        private void MembersShow_Click(object sender, EventArgs e)
        {
            bookcontroller.ShowMembers();
        }
    }
}
