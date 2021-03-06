﻿using System;
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
    internal partial class SearchBookView : Form
    {
        private BookController controller;
        public SearchBookView(BookController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void SearchBookView_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            controller.SearchBook(txtSearch.Text);
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton) sender).Checked)
            {
                RadioButton rb = (RadioButton) sender;
                controller.SetSearchStrategy(rb.Text);
            }
        }
    }
}
