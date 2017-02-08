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
        [Required]
        [Key]
        public string Inss { get; set; }
        public Address Address { get; set; }

        public Member(string firstName, string lastName, string inss, Address address) 
            : base(firstName, lastName)
        {
            Inss = inss;
            Address = address;
        }
    }

    internal class Address
    {
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        public int Number { get; set; }
        public int Zipcode { get; set; }

        public Address(string street, string city, int number, int zipcode)
        {
            Street = street;
            City = city;
            Number = number;
            Zipcode = zipcode;
        }
    }
}
