using FluentValidation;
using MenaxhimiBibliotekes.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BLL.Validate
{
    public class UsersValidation : AbstractValidator<User>
    {


        public UsersValidation()
        {



        }
        public void validateCreateUser()
        {
            
            RuleFor(p => p.Name).NotEmpty().WithMessage("{PropertyName} is Empty")
                .Length(2, 30).WithMessage("{PropertyName} must be more than 2 and less than 30 charactes")
                .Must(ValidateName).WithMessage("{PropertyName} can contain only letters");

            RuleFor(p => p.LastName).NotEmpty().WithMessage("{PropertyName} is Empty")
    .Length(2, 30).WithMessage("{PropertyName} must be more than 2 and less than 30 charactes")
    .Must(ValidateLastName).WithMessage("{PropertyName} can contain only letters");

            RuleFor(p => p.Username).NotEmpty().WithMessage("{PropertyName} is Empty")
         .Length(4, 30).WithMessage("{PropertyName} must be more than 4 and less than 14 charactes")
      .Must(ValidateUsername).WithMessage("{PropertyName} can contain only letters and numbers");

            RuleFor(p => p.Email).NotEmpty().WithMessage("{PropertyName} is Empty")
.Length(6, 30).WithMessage("{PropertyName} must be more than 6 and less than 30 charactes")
         .EmailAddress().WithMessage("{PropertyName} is not valid");

            RuleFor(p => p.Password).NotEmpty().WithMessage("{PropertyName} is Empty")
.Length(7, 30).WithMessage("{PropertyName} must be more than 7 and less than 20 charactes");

        }

        public void validateUpdateUser()
        {
            
            RuleFor(p => p.Name).NotEmpty().WithMessage("{PropertyName} is Empty")
                .Length(2, 30).WithMessage("{PropertyName} must be more than 2 and less than 30 charactes")
                .Must(ValidateName).WithMessage("{PropertyName} can contain only letters");

            RuleFor(p => p.LastName).NotEmpty().WithMessage("{PropertyName} is Empty")
    .Length(2, 30).WithMessage("{PropertyName} must be more than 2 and less than 30 charactes")
    .Must(ValidateLastName).WithMessage("{PropertyName} can contain only letters");

            RuleFor(p => p.Username).NotEmpty().WithMessage("{PropertyName} is Empty")
         .Length(4, 30).WithMessage("{PropertyName} must be more than 4 and less than 14 charactes")
      .Must(ValidateUsername).WithMessage("{PropertyName} can contain only letters and numbers");

        }



        public bool ValidateUsername(string username)
        {

            Regex re = new Regex("^[a-zA-Z0-9]*$");


            if (re.IsMatch(username))
            {
                return true;

            }



            return false;

        }

        private bool ValidateName(string name)
        {

            return name.All(Char.IsLetter);
        }



        private bool ValidateLastName(string Lastname)
        {
            return Lastname.All(Char.IsLetter);
        }



        //public bool ValidateEmail(string Email)
        //{

        //    Regex re = new Regex("^[a-z\\d\\.-]{3,12})@([a-z\\d]{2,12})\\.([a-z]{2,12})\\.([a-z]{2,12})?$");
        //    return re.IsMatch(Email);
           
        //}

        

    }
}
