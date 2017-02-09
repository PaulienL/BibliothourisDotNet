using Microsoft.VisualStudio.TestTools.UnitTesting;
using CGKSBibliothouris;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGKSBibliothouris.Model.DomainModels;
using CGKSBibliothouris.Model.Repositories;

namespace CGKSBibliothouris.Tests {
    [TestClass]
    public class BookRepositoryTest
    {
        private IBookRepository repo;

        [TestInitialize]
        public void SetUp()
        {
            repo = new BookRepositoryHC();
        }

        [TestMethod]
        public void SearchByTitleSearchFor_ypo_returnsListWithOneBook()
        {
            List<Book> books = repo.ReadAllBooks();
            List<Book> result = repo.SearchByTitle("*ypo*");

            CollectionAssert.AreEqual(books, result);
            CollectionAssert.AreEqual(new List<Book>(), repo.SearchByTitle("50 sh*"));
            CollectionAssert.AreEqual(new List<Book>(), repo.SearchByTitle(""));
        }
    }
}