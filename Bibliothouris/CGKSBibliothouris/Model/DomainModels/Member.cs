using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGKSBibliothouris.Model.DomainModels
{
   
    public class Member : Person
    {
        

        public Member(string firstName, string lastName, string inss, Address address, string password) 
            : base(inss, firstName, lastName, password, "Member", address)
        {
            Address = address;
        }
    }
}
