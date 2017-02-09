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
            List<Book> result = repo.SearchByTitle("*ypo*");
            Assert.AreEqual(1, result.Count);
        }
    }
}