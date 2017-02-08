using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGKSBibliothouris.Model.DomainModels;

namespace CGKSBibliothouris.View
{
    public partial class BookSearchResults : Form
    {
        public BookSearchResults()
        {
            InitializeComponent();
        }

        private void lstSearchResult_DoubleClick(object sender, EventArgs e)
        {
            //(Book) lstSearchResult.SelectedItem;
        }
    }
}
