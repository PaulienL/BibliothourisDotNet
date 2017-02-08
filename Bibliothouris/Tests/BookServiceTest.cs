using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CGKSBibliothouris;
using NSubstitute;

namespace Tests
{
    [TestClass]
    public class BookServiceTest
    {
        private BookRepositoryHC repo;
        private BookService service;

        [TestInitialize]
        public void SetUp() {
            repo = Substitute.For <BookRepositoryHC> ();
            service = new BookService();
        }
        [TestMethod]
        public void GetAllBooksTest()
        {

        }
    }
}
