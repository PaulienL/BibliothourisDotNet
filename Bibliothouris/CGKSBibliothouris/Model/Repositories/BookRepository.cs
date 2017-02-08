using CGKSBibliothouris.Model.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGKSBibliothouris.Model.Repositories
{
    interface IBookRepository
    {
        Book CreateBook(Book book);
        Book ReadBook(int id);
        void UpdateBook(Book bookToUpdate);
        void DeleteBook(int id);

        IEnumerable<Book> ReadAllBooks();
    }
}
