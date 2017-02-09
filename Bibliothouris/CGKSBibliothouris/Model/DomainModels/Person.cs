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

        [Required]
        [Key]
        public string Inss { get; set; }

        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Password { get; private set; }

        [Required]
        public Address Address { get; set; }

        [Required]
        public string Role { get; set; }

        public Person(string inss, string firstName, string lastName, string password, string role, Address address)
        {
            this.Inss = inss;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Role = role;
            this.Address = address;
        }

    }

    public class Address
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
