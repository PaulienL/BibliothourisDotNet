using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGKSBibliothouris.Model.DomainModels {
    public class Administrator : Person{
        public Administrator(string inss, string firstName, string lastName, string password, Address address) 
            : base(inss, firstName, lastName, password, "Administrator", address)
        {
        }
    }
}
