using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGKSBibliothouris.Model.DomainModels
{
    class Rental
    {
        public Member Member { get; set; }
        public Book Book { get; set; }
        public DateTime DueDate { get; set; }

        public Rental(Member member, Book book)
        {
            this.Member = member;
            this.Book = book;
            DueDate = DateTime.Today.AddDays(21); 
        }

        public void SetDueDate(DateTime dateTime)
        {
            DueDate = dateTime; 
        }
    }
}
