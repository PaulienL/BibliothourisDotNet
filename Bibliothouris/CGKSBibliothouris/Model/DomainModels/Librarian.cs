﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGKSBibliothouris.Model.DomainModels
{
    class Librarian : Person
    {
        public Librarian(string firstName, string secondName, string inss, string password, Address address) 
            : base(inss, firstName, secondName, password, "Librarian", address)
        {
        }
    }
}
