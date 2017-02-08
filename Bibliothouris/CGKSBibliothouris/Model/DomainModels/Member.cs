using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGKSBibliothouris.Model.DomainModels
{
    class Member : Person
    {
        public Member(string firstName, string secondName) : base(firstName, secondName)
        {
        }
    }
}
