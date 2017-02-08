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
            bookService = new BookService();
            this.bookView = bookView; 
        }
        
        internal List<Book> GetAllBooks()
        {
            return bookService.GetAllBooks();
        }

        public void ShowView()
        {
            LoadAllBooks();
            bookView.ShowDialog();
        }

        private void LoadAllBooks()
        {
            bookView.UpdateDataInLstBook(bookService.GetAllBooks());
        }

        public void ShowMembers()
        {
            memberController.ShowView();
        }
    }
}