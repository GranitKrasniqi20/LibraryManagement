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


            RuleFor(m => m.Price)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!");

        }
    }
}
