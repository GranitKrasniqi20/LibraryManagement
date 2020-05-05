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
    class ShelfValidation : AbstractValidator<Shelf>
    {
        

        public void ValidateShelf()
        {
            RuleFor(p => p.Location).NotEmpty().WithMessage("{PropertyName} is Empty")
.Length(2, 30).WithMessage("{PropertyName} must be more than 2 and less than 14 charactes")
.Must(ValidateLocation).WithMessage("{PropertyName} can contain only letters and numbers");


            RuleFor(p => p.Quantity).NotEmpty().WithMessage("{PropertyName} is Empty")
                .GreaterThan(0).WithMessage("Amount unacceptable. Greater quantity!")
                .LessThan(0).WithMessage("Amount unacceptable. Greater quantity!");


            RuleFor(p => p.Description).NotEmpty().WithMessage("{PropertyName} is Empty")
                .Length(0, 250).WithMessage("{PropertyName} should not have more than 250 characters ");

        }


        public bool ValidateLocation(string username)
        {

            Regex re = new Regex("^[a-zA-Z\\d\\.-]*$");


            if (re.IsMatch(username))
            {
                return true;

            }



            return false;

        }




    }
}
