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
    public partial class BookDetails : Form
    {
        private BookController bookController;

        public BookDetails()
        {
            InitializeComponent();
        }

        public void SetFieldReadOnly()
        {
            btnSave.Visible = false;
            txtIsbn.Enabled = false;
            txtTitle.Enabled = false;
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
        }

        public void SetFieldsEditable()
        {
            btnSave.Visible = true;
            txtIsbn.Enabled = true;
            txtTitle.Enabled = true;
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
        }

        internal void AddController(BookController bookController)
        {
            this.bookController = bookController;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bookController.CreateBook(txtFirstName.Text, txtLastName.Text, txtTitle.Text, txtIsbn.Text);
        }

        internal void Clear()
        {
            txtIsbn.Clear();
            txtTitle.Clear();
            txtFirstName.Clear();
            txtLastName.Clear(); 
        }

        internal void ShowBookDetails(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
