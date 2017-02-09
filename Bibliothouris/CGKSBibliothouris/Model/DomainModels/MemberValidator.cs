using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGKSBibliothouris.Model.DomainModels
{
    class MemberValidator
    {
        
        internal void ValidateByValidateObject(Member member)
        {
            ValidationContext validationContext = new ValidationContext(member);

            try { Validator.ValidateObject(member, validationContext, validateAllProperties: false);
                    Console.WriteLine("This object is valid (using ValidateObject)"); }
            catch (ValidationException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
