using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using CGKSBibliothouris.Model.DomainModels;
using CGKSBibliothouris.View;

namespace CGKSBibliothouris.Controller {
    public class BookController : Controller
    {
        private MainController mainController;

        private readonly BookService bookservice;
        private readonly BookView bookView;
        private readonly BookDetails bookDetails; 

        public BookController()
        {
            bookservice = new BookService();
            this.bookView = new BookView();
            bookView.AddController(this);
            this.bookDetails = new BookDetails();
            bookDetails.AddController(this); 
        }
        
        public List<Book> GetAllBooks()
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
            mainController.ShowMemberView();
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

        public void SetAccesRights(Person person)
        {
            bookView.SetRights(person.Role);
        }

        public void ShowMainView()
        {
            bookView.ShowDialog();
        }



        public void AddMainController()
        {
            mainController = MainController.GetInstance();
        }
    }
}