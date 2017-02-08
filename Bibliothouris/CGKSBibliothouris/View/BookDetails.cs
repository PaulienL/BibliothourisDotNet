using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGKSBibliothouris.View
{
    public partial class BookDetails : Form
    {
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
    }
}
