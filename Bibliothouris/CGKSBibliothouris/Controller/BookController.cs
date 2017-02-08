using System;
using System.Collections.Generic;
using CGKSBibliothouris.Model.DomainModels;

namespace CGKSBibliothouris
{
    internal class BookController
    {
        private BookService bookservice;

        public BookController()
        {
            bookservice = new BookService(); 
        }

        internal List<Book> GetAllBooks()
        {
            return bookservice.GetAllBooks();
        }
    }
}