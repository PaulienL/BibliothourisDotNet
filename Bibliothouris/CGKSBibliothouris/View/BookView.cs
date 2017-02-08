﻿using CGKSBibliothouris.Controller;
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
        }

        private void MembersShow_Click(object sender, EventArgs e)
        {
            bookcontroller.ShowMembers();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            bookcontroller.AddBookView(); 
        }
    }
}
