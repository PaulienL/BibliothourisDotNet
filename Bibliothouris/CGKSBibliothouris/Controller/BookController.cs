using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using CGKSBibliothouris.Controller;
using CGKSBibliothouris.Model.DomainModels;
using CGKSBibliothouris.View;

namespace CGKSBibliothouris.Controller
{
    public class BookController : Controller
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
            try
            {
                bookservice.CreateAndAddBook(firstName, lastName, title, isbn);
                bookDetails.Close();
                bookDetails.Clear();
                LoadAllBooks();
            }
            catch (ValidationException valEx)
            {
                MessageBox.Show(valEx.Message, "Error!",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowDetailsBook(int id)
        {
            bookDetails.SetFieldReadOnly();
            bookDetails.ShowBookDetails(bookservice.GetBook(id));
            bookDetails.ShowDialog();
        }

        internal void AddBookView()
        {
            bookDetails.SetFieldsEditable(); 
            bookDetails.ShowDialog(); 
        }

        public void SetSearchStrategy(string stratString)
        {
            SearchStrategy strategy;
            if (SearchStrategy.TryParse(stratString, true, out strategy))
            {
                bookservice.SetSearchStrategy(strategy);
            }
        }

        public void SearchBook(string searchFor)
        {
            List<Book> searchResult = bookservice.SearchBooks(searchFor);
            if (searchResult.Count == 1)
            {
                BookDetails result = new BookDetails();
                result.SetFieldReadOnly();
                result.AddController(this);
                result.ShowBookDetails(searchResult.ElementAt(0));
                result.ShowDialog();
            }
            else
            {
                BookSearchResults result = new BookSearchResults();
                result.AddController(this);
                result.UpdateDataInLstBook(searchResult);
                result.ShowDialog();
            }
        }
    }
}