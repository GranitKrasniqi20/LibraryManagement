using FluentValidation;
using MenaxhimiBibliotekes.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BLL.Validate
{
    class BillTypeValidation : AbstractValidator<BillType>
    {
        public BillTypeValidation()
        {
            ValidatorOptions.CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(m => m._BillType)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!");
        }
    }
}
