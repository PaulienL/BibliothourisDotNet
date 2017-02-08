using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGKSBibliothouris.Model.DomainModels
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public string Isbn { get; set; }

        public Book(string title, Author author, string isbn)
        {
            this.Title = title;
            this.Author = author;
            this.Isbn = isbn;
        }
    }
}
