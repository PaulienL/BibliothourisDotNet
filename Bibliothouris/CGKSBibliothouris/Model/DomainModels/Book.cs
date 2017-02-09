using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGKSBibliothouris.Model.DomainModels
{
    public class Book : IValidatableObject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        private Author Author { get; set; }
        public string FirstName
        {
            get
            {
                return Author.FirstName;
            }
        }
        public string LastName
        {
            get
            {
                return Author.LastName;
            }
        }
        public string Isbn { get; set; }

        public Book(string title, Author author, string isbn)
        {
            this.Title = title;
            this.Author = author;
            this.Isbn = isbn;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();
            if (!DoValidateISBN())
            {
                string msg = "Invalid ISBN!";
                errors.Add(new ValidationResult(msg, new string[] {"ISBN"}));
            }
            return errors;
        }

        private bool DoValidateISBN()
        {
            if (Isbn == null)
            {
                return false;
            }
            string isbnStr = Isbn.Replace("-", "");
            if (Isbn.Length != 13)
            {
                return false;
            }
            long isbn;
            if (!long.TryParse(isbnStr, out isbn))
            {
                return false;
            }
                
            long sum = 0;
            for (int i = 0; i < 12; i++)
            {
                int digit=int.Parse(Isbn.ElementAt(i).ToString());
                sum += (i % 2 == 0) ? digit * 1 : digit * 3;
            }
            int checksum = 10 - (int) (sum % 10);

            Console.WriteLine(checksum);
            return checksum == int.Parse(Isbn.ElementAt(12).ToString());
        }
    }
}
