using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGKSBibliothouris.Model.DomainModels
{
    public class Librarian : Member
    {
        public Librarian(string firstName, string secondName) : base(firstName, secondName)
        {
        }
    }
}
