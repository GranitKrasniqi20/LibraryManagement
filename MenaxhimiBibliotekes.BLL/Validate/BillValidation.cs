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

    public class BillValidation : AbstractValidator<Bill>
    {
        public Bill bill { get; set; }

        public BillValidation()
        {
            bill = new Bill();
        }

        public void ValidateBill()
        {
            ValidatorOptions.CascadeMode = CascadeMode.StopOnFirstFailure;

            if (bill.MaterialId != 0)
            {
                RuleFor(m => m.MaterialId)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!")
                .GreaterThan(1).WithMessage("Id unacceptable. Greater Id!");
            }

            RuleFor(m => m.BillingDate)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!")
                .Must(BeAValidDate).WithMessage("{PropertyName} not entered properly!");

            RuleFor(m => m.Price)
                .LessThan(999).WithMessage("Amount unacceptable. Lower price!")
                .GreaterThan(0).WithMessage("Amount unacceptable. Greater price!");

            if (bill.Description != null)
            {
                RuleFor(m => m.Description)
                   .Length(1, 50).WithMessage("Not shorter than 1 and not longer than 50");
            }
        }

        protected bool BeAValidDate(DateTime date)
        {
            DateTime d = DateTime.Now;
            DateTime min = new DateTime(1, 1, 1);

            return date <= d && date >= min;
        }
    }
}
