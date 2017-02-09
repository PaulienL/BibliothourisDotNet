using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGKSBibliothouris.Model.DomainModels;
using CGKSBibliothouris.Model.Repositories;
using System.ComponentModel.DataAnnotations;
using System.Security.Authentication;

namespace CGKSBibliothouris.Model.Services
{
    public class MemberService
    {
        private MemberRepository memberRepository;
        //private MemberValidator memberValidator;

        public MemberService(MemberRepository memberRepository)
        {
            this.memberRepository = memberRepository;
        }


        public List<Person> GetAllMembers()
        {
            return memberRepository.GetAllMembers();
        }

        internal void CreateAndAddMember(string firstName, string lastName, string street, int number, int zipcode, string city, string inss, string password)
        {
            Address address = new Address(street, city, number, zipcode);
            ValidationContext validationContextAddress = new ValidationContext(address);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            Person member = new Member(firstName, lastName, inss, address, password);
            ValidationContext validationContextMember = new ValidationContext(member);
            
            bool isValid = Validator.TryValidateObject(address, validationContextAddress, validationResults, true);
            isValid = Validator.TryValidateObject(member, validationContextMember, validationResults, true);

            if (isValid)
            {

               // Validator.ValidateObject(member, validationContext, validateAllProperties: false);
                memberRepository.AddMember(firstName, lastName, inss, new Address(street, city, number, zipcode), password);
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach (var result in validationResults)
                {
                    sb.Append(result.ErrorMessage);
                    sb.Append("\n");
                }
                string errors = sb.ToString();
                throw new ValidationException(errors); 

            }
        }

        public bool Login(string inss, string password)
        {
            Person p = memberRepository.GetUser(inss);
            if (p == null)
            {
                throw new AuthenticationException("Member not found");
            }
            if (p.Password.Equals(password))
            {
                return true;
            }
            throw new AuthenticationException("Incorrect password");
        }

        public Person GetMember(string inss)
        {
            return memberRepository.GetUser(inss);
        }
    }
}
