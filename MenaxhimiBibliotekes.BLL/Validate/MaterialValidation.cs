using FluentValidation;
using MenaxhimiBibliotekes.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiBibliotekes.BLL.Validate
{
    public class MaterialValidation : AbstractValidator<Material>
    {
        
        public MaterialValidation()
        {
            ValidatorOptions.CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(m => m.Title)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!");

            RuleFor(m => m._Author)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!")

                .Must(BeAValidAuthorName).WithMessage("{PropertyName} not entered properly!");

            RuleFor(m => m._Genre)
                .NotEmpty().WithMessage("PropertyName} is empty! Please fill it!");

            RuleFor(m => m._Language)
                .NotEmpty().WithMessage("PropertyName} is empty! Please fill it!");

            RuleFor(m => m._Shelf)
                .NotEmpty().WithMessage("PropertyName} is empty! Please fill it!");

            RuleFor(m => m._MaterialType)
                .NotEmpty().WithMessage("PropertyName} is empty! Please fill it!");

            RuleFor(m => m._PublishHouse)
                .NotEmpty().WithMessage("PropertyName} is empty! Please fill it!")
                .Must(m => m._PublishHouse.Length >= 2 && m._PublishHouse.Length < 50)
                .WithMessage("(TotalLength) is not acceptable. Lower than 50 characters!");

            RuleFor(m => m.PublishYear)
                .NotEmpty().WithMessage("PropertyName} is empty! Please fill it!")
                .Must(BeAValidYear).WithMessage("Invalid Date!");

            RuleFor(m => m.PublishPlace)
                .NotEmpty().WithMessage("PropertyName} is empty! Please fill it!")
                .Must(AcceptablePublishPlaceLength).WithMessage("Character Length should be lower than 50!");

            RuleFor(m => m.Quantity)
                .NotEmpty().WithMessage("PropertyName} is empty! Please fill it!")
                .LessThan(9999).WithMessage("Amount unacceptable. Lower quantity!")
                .GreaterThan(0).WithMessage("Amount unacceptable. Greater quantity!");

            RuleFor(m => m.NumberOfPages)
                .NotEmpty().WithMessage("PropertyName} is empty! Please fill it!")
                .LessThan(15000).WithMessage("Amount unacceptable. Lower Number of Pages!")
                .GreaterThan(0).WithMessage("Amount unacceptable. Greater Number of Pages!");

        }

        protected bool BeAValidAuthorName (Author name)
        {
            return name.AuthorName.All(Char.IsLetter);
        }

        protected bool BeAValidYear (DateTime year)
        {
            DateTime d = DateTime.Now;
            DateTime min = new DateTime(1, 1, 1);

            return year <= d && year >= min;
        }

        protected bool AcceptablePublishPlaceLength(string place)
        {
            return place.Length >= 3 && place.Length < 50; 
        }
    }
}
