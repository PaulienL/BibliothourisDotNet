﻿using System;
using System.Collections.Generic;
using System.Linq;
using CGKSBibliothouris.Model.DomainModels;
using CGKSBibliothouris.Model.Repositories;

namespace CGKSBibliothouris
{
    internal class BookRepositoryHC : IBookRepository
    {
        private List<Book> books;

        public BookRepositoryHC()
        {
            books = new List<Book>();
            InitRepo();
        }

        private void InitRepo()
        {
            books.Add(new Book("harrypotter", new Author("JK", "Rowling"), "123456")); 
        }

        public Book CreateBook(Book book)
        {
            throw new NotImplementedException();
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
    }
}