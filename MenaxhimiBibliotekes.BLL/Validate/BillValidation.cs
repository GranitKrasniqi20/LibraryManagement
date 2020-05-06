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
    class BillValidation : AbstractValidator<Bill>
    {
        public Bill bill { get; set; }

        public BillValidation()
        {
            bill = new Bill();
        }
        
        public void ValidateBill()
        {
            ValidatorOptions.CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(m => m.SubscriberId)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!")
                .GreaterThan(1).WithMessage("Id unacceptable. Greater Id!");
                //.Matches("^[0 - 9]").WithMessage("Enter only numbers");

            if (bill.MaterialId != 0)
            {
                RuleFor(m => m.MaterialId)
                    .GreaterThan(1).WithMessage("Id unacceptable. Greater Id!");
                    //.Matches("^[0 - 9]").WithMessage("Enter only numbers");
            }

            RuleFor(m => m.BillTypeId)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!")
                .GreaterThan(1).WithMessage("Id unacceptable. Greater Id!");
                //.Matches("^[0 - 9]").WithMessage("Enter only numbers");


            RuleFor(m => m.Price)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!")
                .LessThan(999).WithMessage("Amount unacceptable. Lower price!")
                .GreaterThan(0).WithMessage("Amount unacceptable. Greater price!");
                //.Matches("^[0 - 9]").WithMessage("Enter only numbers"); 

            if (bill.Description != null)
            {
                RuleFor(m => m.Description)
                   .Length(2, 50).WithMessage("Not shorter than 2 and not longer than 50");
            }

        }
    }
}
