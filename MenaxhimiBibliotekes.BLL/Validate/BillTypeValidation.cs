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
    public class BillTypeValidation : AbstractValidator<BillType>
    {
        public BillType billType { get; set; }

        public BillTypeValidation()
        {
           billType = new BillType();
        }

        public void ValidateBillType()
        {
            ValidatorOptions.CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(m => m._BillType)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!");
        }
    }
}
