using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGKSBibliothouris.Model.DomainModels
{
    class Rental
    {
        public Member member { get; set; }
        public Book book { get; set; }
        public DateTime duedate { get; set; }

        
    }
}
