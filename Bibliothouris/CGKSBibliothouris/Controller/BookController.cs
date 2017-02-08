using System;
using System.Collections.Generic;
using CGKSBibliothouris.Model.DomainModels;
using CGKSBibliothouris.Controller; 

namespace CGKSBibliothouris.Controller
{
    internal class BookController : Controller
    {
        private BookView bookView;
        private BookService bookService;

      

        public BookController(BookView bookView)
        {
            bookService = new BookService();
            this.bookView = bookView; 
        }
        
        internal List<Book> GetAllBooks()
        {
            return bookService.GetAllBooks();
        }

        public void ShowView()
        {
            LoadAllBooks();
            bookView.ShowDialog();
        }

        private void LoadAllBooks()
        {
            bookView.UpdateDataInLstBook(bookService.GetAllBooks());
        }
    }
}