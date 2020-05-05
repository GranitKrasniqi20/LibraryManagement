using FluentValidation;
using MenaxhimiBibliotekes.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BLL.Validate
{
    class SubscriberValidation : AbstractValidator<Subscriber>
    {
        public SubscriberValidation()
        {
            ValidatorOptions.CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(m => m.Name)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!")
                .Length(2, 20).WithMessage("Not shorter than 2 and not longer than 20");

            RuleFor(m => m.LastName)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!")
                .Length(2, 20).WithMessage("Not shorter than 10 and not longer than 20");

            RuleFor(m => m.Address)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!")
                .Length(2, 20).WithMessage("Not shorter than 10 and not longer than 20");

            //RuleFor(m => m.Birthday)
            //    .Must(BeAValidDate).WithMessage("{PropertyName} not entered properly!");

            //RuleFor(m => m.PersonalNo)
            //   .Matches($"[0 - 9]").WithMessage("Enter only numbers")
            //   .Length(10, 10).WithMessage("No longer and not shorter than 10 charachters");

            RuleFor(m => m.PhoneNo)
               .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!")
               .Matches($"[0 - 9]").WithMessage("Enter only numbers")
               .Length(2, 20).WithMessage("Not shorter than 6 and not longer than 20");

            RuleFor(m => m.Email)
               .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!")
               .Length(10, 20).WithMessage("Not shorter than 10 and not longer than 20")
               .EmailAddress().WithMessage("{PropertyName} is not correct!");




        }

        //protected bool BeAValidDate(DateTime date)
        //{
        //    DateTime d = DateTime.Now;
        //    DateTime min = new DateTime(1, 1, 1);

        //    return date <= d && date >= min;
        //}
    }
}
