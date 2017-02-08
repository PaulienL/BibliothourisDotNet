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

namespace CGKSBibliothouris.View
{
    internal partial class BookDetails : Form
    {
        private BookController controller;

        public BookDetails(BookController bookController)
        {
            InitializeComponent();
            this.controller = bookController;
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

        public TextBox getId()
        {
            return txtId;
        }

        public TextBox getTitle()
        {
            return txtTitle;
        }

        public TextBox getIsbn()
        {
            return txtIsbn;
        }

        public TextBox getFirstName()
        {
            return txtFirstName;
        }

        public TextBox getLastName()
        {
            return txtLastName;
        }
    }
}
