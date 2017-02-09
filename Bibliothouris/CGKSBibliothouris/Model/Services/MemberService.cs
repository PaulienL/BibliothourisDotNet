using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CGKSBibliothouris.Model.DomainModels;
using CGKSBibliothouris.Model.Repositories;
using System.ComponentModel.DataAnnotations;

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


        public List<Member> GetAllMembers()
        {
            return memberRepository.GetAllMembers();
        }

        internal void CreateAndAddMember(string firstName, string lastName, string street, int number, int zipcode, string city, string inss)
        {
            Address address = new Address(street, city, number, zipcode);
            ValidationContext validationContextAddress = new ValidationContext(address);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            Member member = new Member(firstName, lastName, inss, new Address(street, city, number, zipcode));
            ValidationContext validationContextMember = new ValidationContext(member);
            
            bool isValid = Validator.TryValidateObject(address, validationContextAddress, validationResults, true);
            isValid = Validator.TryValidateObject(member, validationContextMember, validationResults, true);

            if (isValid)
            {

               // Validator.ValidateObject(member, validationContext, validateAllProperties: false);
                memberRepository.AddMember(firstName, lastName, inss, new Address(street, city, number, zipcode));
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
    }
}
