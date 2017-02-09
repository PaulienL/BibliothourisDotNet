using CGKSBibliothouris.Model.DomainModels;
using CGKSBibliothouris.Model.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CGKSBibliothouris
{
    public class BookService
    {
        private IBookRepository bookrepository;
        private IBookSearchStrategy strategy;

        public BookService()
        {
            bookrepository = new BookRepositoryHC();
            strategy = new TitleSearch();
        }

        public BookService(IBookRepository bookrepository)
        {
            this.bookrepository = bookrepository;
        }

        public List<Book> GetAllBooks()
        {
            return bookrepository.ReadAllBooks(); 
        }

        public Book GetBook(int id)
        {
            return bookrepository.ReadBook(id);
        }

        public void CreateAndAddBook(string firstName, string lastName, string title, string isbn)
        {
            var book = new Book(title, new Author(firstName, lastName), isbn);
            List<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(book, new ValidationContext(book), errors))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (var validationResult in errors)
                {
                    errorMsg.AppendLine(validationResult.ErrorMessage);
                }
                throw new ValidationException(errorMsg.ToString());
            }
            bookrepository.AddBook(book); 
        }

        public List<Book> SearchBooks(string searchFor) {
            return strategy.SearchBooks(searchFor, bookrepository);
        }

        public void SetSearchStrategy(SearchStrategy strategy)
        {
            if (strategy.Equals(SearchStrategy.TITLE))
            {
                this.strategy = new TitleSearch();
            }
            else if (strategy.Equals(SearchStrategy.AUTHOR))
            {
                this.strategy = new AuthorSearch();
            }
            else
            {
                this.strategy = new IsbnSearch();
            }
        }

        

        private interface IBookSearchStrategy {
            List<Book> SearchBooks(string searchFor, IBookRepository repo);
        }

        private class TitleSearch : IBookSearchStrategy {
            public List<Book> SearchBooks(string searchFor, IBookRepository repo)
            {
                return repo.SearchByTitle(searchFor);
            }
        }

        private class AuthorSearch : IBookSearchStrategy {
            public List<Book> SearchBooks(string searchFor, IBookRepository repo)
            {
                return repo.SearchByAuthor(searchFor);
            }
        }

        private class IsbnSearch : IBookSearchStrategy {
            public List<Book> SearchBooks(string searchFor, IBookRepository repo)
            {
                return repo.SearchByISBN(searchFor);
            }
        }

        
    }

    public enum SearchStrategy {
        TITLE,
        ISBN,
        AUTHOR
    }
}