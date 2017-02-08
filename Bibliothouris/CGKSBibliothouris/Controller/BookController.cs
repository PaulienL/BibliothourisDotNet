using System;
using System.Collections.Generic;
using CGKSBibliothouris.Controller;
using CGKSBibliothouris.Model.DomainModels;
using CGKSBibliothouris.Controller; 

namespace CGKSBibliothouris.Controller
{
    internal class BookController : Controller
    {
        public MemberController memberController;
        private BookService bookservice;
        private BookView bookView;

        public BookController(BookView bookView, MemberController memberController)
        {
            this.memberController = memberController;
            bookservice = new BookService();
            this.bookView = bookView;
            bookView.AddController(this);
        }
        
        internal List<Book> GetAllBooks()
        {
            return bookservice.GetAllBooks();
        }

        public void ShowView()
        {
            LoadAllBooks();
            bookView.ShowDialog();
        }

        private void LoadAllBooks()
        {
            bookView.UpdateDataInLstBook(bookservice.GetAllBooks());
        }

        public void ShowMembers()
        {
            memberController.ShowView();
        }
    }
}