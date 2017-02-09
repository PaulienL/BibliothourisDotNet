using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CGKSBibliothouris;
using CGKSBibliothouris.Model.DomainModels;
using CGKSBibliothouris.Model.Repositories;
using NSubstitute;

namespace Tests
{
    [TestClass]
    public class BookServiceTest
    {
        private IBookRepository repo;
        private BookService service;

        [TestInitialize]
        public void SetUp() {
            repo = Substitute.For <IBookRepository> ();
            service = new BookService(repo);
        }

        [TestMethod]
        public void GetAllBooksTest()
        {
            List<Book> list = new List<Book>{new Book("test", new Author("Wouter", "Bauweraerts"), "1234")};
            repo.ReadAllBooks().Returns(list);
            service.GetAllBooks();
            Assert.AreEqual(list, service.GetAllBooks());
        }

        [TestMethod]
        public void AddBookShouldCallCreateAndAddBookWithBookAsParameter()
        {
            service.CreateAndAddBook("ik", "test", "test", "9789024548002");
            repo.Received().AddBook(Arg.Is<Book>(x=> x.Isbn.Equals("9789024548002") && x.Title.Equals("test") && x.FirstName.Equals("ik") && x.LastName.Equals("test")));
        }

        [TestMethod]
        public void GetBookShouldCallRepoReadBook()
        {
            service.GetBook(1);
            repo.Received().ReadBook(Arg.Is(1));
        }

        [TestMethod]
        public void InvalidIsbnShouldReturnValidationException() {
            Book book = new Book("a", new Author("b", "c"), "140909155");
            List<ValidationResult> errors = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(book, new ValidationContext(book), errors, true);
            CollectionAssert.AreNotEqual(new List<ValidationResult>(), errors);
        }

        [TestMethod]
        public void ValidIsbnnShouldNotReturnValidationResults()
        {
            Book book = new Book("a", new Author("b","c"), "9789024548002");
            List<ValidationResult> errors = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(book, new ValidationContext(book), errors);
            Assert.IsTrue(valid);
        }
    }
}
