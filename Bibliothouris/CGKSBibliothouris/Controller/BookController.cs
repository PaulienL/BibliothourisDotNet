using System;
using System.Collections.Generic;
using CGKSBibliothouris.Controller;
using CGKSBibliothouris.Model.DomainModels;
using CGKSBibliothouris.View;

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

        public void ShowDetailsBook(int id)
        {
            BookDetails details = new BookDetails(this);
            details.SetFieldReadOnly();
            Book book = bookservice.GetBook(id);
            SetTextFields(details, book);
        }

        private void SetTextFields(BookDetails details, Book book)
        {
            details.getId().Text = book.Id.ToString();
            details.getIsbn().Text = book.Isbn;
            details.getTitle().Text = book.Title;
            details.getFirstName().Text = book.FirstName;
            details.getLastName().Text = book.LastName;
        }
    }
}