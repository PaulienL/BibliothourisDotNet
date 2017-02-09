using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGKSBibliothouris.Model.DomainModels
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public Person(string firstName,string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName; 
        }

    }
}
