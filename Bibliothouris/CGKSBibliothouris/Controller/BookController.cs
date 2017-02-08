using System;
using System.Collections.Generic;
using CGKSBibliothouris.Controller;
using CGKSBibliothouris.Model.DomainModels;

namespace CGKSBibliothouris
{
    internal class BookController
    {
        public MemberController memberController;
        private BookService bookservice;

        public BookController(MemberController memberController)
        {
            this.memberController = memberController;
            bookservice = new BookService();
        }

        internal List<Book> GetAllBooks()
        {
            return bookservice.GetAllBooks();
        }

        public void ShowMembers()
        {
            memberController.ShowView();
        }
    }
}