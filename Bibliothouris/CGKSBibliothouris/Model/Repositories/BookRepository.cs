﻿using CGKSBibliothouris.Model.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGKSBibliothouris.Model.Repositories
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        Book ReadBook(int id);
        void UpdateBook(Book bookToUpdate);
        void DeleteBook(int id);

        List<Book> ReadAllBooks();
        List<Book> SearchByTitle(string searchFor);
        List<Book> SearchByAuthor(string searchFor);
        List<Book> SearchByISBN(string searchFor);
    }
}
