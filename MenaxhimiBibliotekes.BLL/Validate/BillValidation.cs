using FluentValidation;
using MenaxhimiBibliotekes.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BLL.Validate
{
    class BillValidation : AbstractValidator<Bill>
    {
        public BillValidation()
        {
            ValidatorOptions.CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(m => m.SubscriberId)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!");

            RuleFor(m => m.MaterialId)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!");

            RuleFor(m => m.BillTypeId)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!");



            RuleFor(m => m.Price)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!")
                .LessThan(999).WithMessage("Amount unacceptable. Lower price!")
                .GreaterThan(0).WithMessage("Amount unacceptable. Greater price!");

            RuleFor(m => m.Description)
               .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!");

            RuleFor(m => m.Description)
                .Length(2, 50).WithMessage("Not shorter than 2 and not longer than 50");

        }
    }
}
