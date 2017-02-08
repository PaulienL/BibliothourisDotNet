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
        private BookDetails bookDetails; 

        public BookController(BookView bookView, MemberController memberController, BookDetails bookDetails)
        {
            this.memberController = memberController;
            bookservice = new BookService();
            this.bookView = bookView;
            bookView.AddController(this);
            this.bookDetails = bookDetails;
            bookDetails.AddController(this); 
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

        internal void CreateBook(string firstName, string lastName, string title, string isbn)
        {
            bookservice.CreateAndAddBook(firstName, lastName, title, isbn);
            bookDetails.Close();
            bookDetails.Clear(); 
            LoadAllBooks();
        }

        public void ShowDetailsBook(int id)
        {
            BookDetails details = new BookDetails(this);
            details.SetFieldReadOnly();
            SetTextFields(details, bookservice.GetBook(bookId));
            details.ShowDialog();
        }

        private void SetTextFields(BookDetails details, Book book)
        {
            details.getId().Text = book.Id.ToString();
            details.getIsbn().Text = book.Isbn;
            details.getTitle().Text = book.Title;
            details.getFirstName().Text = book.FirstName;
            details.getLastName().Text = book.LastName;
            
        }

        internal void AddBookView()
        {
            bookDetails.SetFieldsEditable(); 
            bookDetails.ShowDialog(); 
        }
 
    }
}