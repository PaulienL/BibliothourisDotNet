using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using CGKSBibliothouris.Model.DomainModels;
using CGKSBibliothouris.Model.Repositories;

namespace CGKSBibliothouris
{
    public class BookRepositoryHC : IBookRepository
    {
        private List<Book> books;

        public BookRepositoryHC()
        {
            books = new List<Book>();
            InitRepo();
        }

        private void InitRepo()
        {
            AddBook(new Book("harrypotter", new Author("JK", "Rowling"), "1409091155"));
            AddBook(new Book("50 Shades of Grey", new Author("I", "Don'r know"), "1409091155"));
            AddBook(new Book("50 Shades Darker", new Author("I", "Don't know"), "1409091155"));
        }

        public void AddBook(Book book)
        {
            book.Id = books.Count + 1;
            books.Add(book); 
        }

        public void DeleteBook(int id)
        {
            
        }

        public List<Book> ReadAllBooks()
        {
            return books;
        }

        public Book ReadBook(int id)
        {
            return books.FirstOrDefault(book => book.Id == id);
        }

        public void UpdateBook(Book bookToUpdate)
        {
            throw new NotImplementedException();
        }

        public List<Book> SearchByTitle(string searchFor)
        {
            if (searchFor == null || searchFor.Length == 0)
            {
                return new List<Book>();
            }
            var strRegex = ConvertToRegex(searchFor);
            return books.Where<Book>(book =>
            {
                Match match = Regex.Match(book.Title, strRegex);
                return match.Success;
            }).ToList();
        }

        public List<Book> SearchByAuthor(string searchFor)
        {
            if (searchFor == null || searchFor.Length == 0) {
                return new List<Book>();
            }
            var strRegex = ConvertToRegex(searchFor);
            return books.Where<Book>(book =>
            {
                string firstNameLastName = string.Format("{0} {1}", book.FirstName, book.LastName);
                string lastNameFirstName = string.Format("{0} {1}", book.LastName, book.FirstName);
                return Regex.IsMatch(firstNameLastName, strRegex) || Regex.IsMatch(lastNameFirstName, strRegex);
            }).ToList();
        }

        public List<Book> SearchByISBN(string searchFor)
        {
            if (searchFor == null || searchFor.Length == 0) {
                return new List<Book>();
            }
            var strRegex = ConvertToRegex(searchFor);
            return books.Where<Book>(book => Regex.IsMatch(book.Isbn, strRegex)).ToList();
        }

        private string ConvertToRegex(string searchFor)
        {
            return searchFor.Replace("*", ".*");
        }

      
    }
}