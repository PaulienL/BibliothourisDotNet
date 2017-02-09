using System;
using System.Collections.Generic;
using System.Linq;
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
            AddBook(new Book("harrypotter", new Author("JK", "Rowling"), "123456"));
            AddBook(new Book("50 Shades of Grey", new Author("I", "Don'r know"),"123" ));
            AddBook(new Book("50 Shades Darker", new Author("I", "Don't know"), "234"));
        }

        public void AddBook(Book book)
        {
            book.Id = books.Count + 1;
            books.Add(book); 
        }

        public void DeleteBook(int id)
        {
            throw new NotImplementedException();
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

        private string ConvertToRegex(string searchFor)
        {
            return searchFor.Replace("*", ".*");
        }
    }
}