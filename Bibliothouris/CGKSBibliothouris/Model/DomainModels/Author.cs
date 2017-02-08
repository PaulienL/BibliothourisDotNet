using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGKSBibliothouris.Model.DomainModels
{
    class Author
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }

        public Author(string firstName, string secondName)
        {
            this.firstName = firstName;
            this.secondName = secondName; 
        }
    }
}
