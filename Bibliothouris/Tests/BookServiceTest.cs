using System;
using System.Collections.Generic;
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
        public void GetBookShouldReturnCorrectBook()
        {
            service.CreateAndAddBook("ik", "test", "test", "123");
            repo.Received().AddBook(Arg.Is<Book>(x=> x.Isbn.Equals("123") && x.Title.Equals("test") && x.FirstName.Equals("ik") && x.LastName.Equals("test")));
        }
    }
}
