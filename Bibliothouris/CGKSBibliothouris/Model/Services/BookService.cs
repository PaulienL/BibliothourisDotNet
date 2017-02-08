using CGKSBibliothouris.Model.DomainModels;
using CGKSBibliothouris.Model.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CGKSBibliothouris
{
    internal class BookService
    {
        private IBookRepository bookrepository;

        public BookService()
        {
            bookrepository = new BookRepositoryHC();
        }
        internal List<Book> GetAllBooks()
        {
            return bookrepository.ReadAllBooks(); 
        }

        public Book GetBook(int id)
        {
            return bookrepository.ReadBook(id);
        }
    }
}