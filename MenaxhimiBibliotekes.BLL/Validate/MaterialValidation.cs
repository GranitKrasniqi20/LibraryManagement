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
    public class MaterialValidation : AbstractValidator<Material>
    {
        public Material material { get; set; }

        public MaterialValidation()
        {
            material = new Material();
        }

        public void ValidateMaterial()
        {
            ////material = new Material();

            ValidatorOptions.CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(m => m.Title)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!");

            RuleFor(m => m._Author)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!")
                .Must(BeAValidAuthorName).WithMessage("{PropertyName} not entered properly!");

            RuleFor(m => m._Genre)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!");

            RuleFor(m => m._Language)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!");

            if (material.ISBN.Length != 0)
            {
                RuleFor(m => m.ISBN)
                .Length(13, 13).WithMessage("Length of {PropertyName} should be exact 13!")
                .Matches("^\\d{13}$").WithMessage("Please enter only digit numbers!");
            }


            RuleFor(m => m._Shelf)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!");

            RuleFor(m => m._MaterialType)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!");

            RuleFor(m => m._PublishHouse)
                .Must(m => m._PublishHouse.Length >= 2 && m._PublishHouse.Length < 50)
                .WithMessage("(PropertyName) is not acceptable. Lower than 50 characters!");

            RuleFor(m => m.PublishYear)
                .Must(BeAValidYear).WithMessage("Invalid Date!");

            RuleFor(m => m.PublishPlace)
                .Must(AcceptablePublishPlaceLength).WithMessage("{PropertyName} character length should be lower than 50!");

            RuleFor(m => m.Quantity)
                .NotEmpty().WithMessage("{PropertyName} is empty! Please fill it!")
                .LessThan(10000).WithMessage("Amount unacceptable. Lower quantity!")
                .GreaterThan(0).WithMessage("Amount unacceptable. Greater quantity!");

            RuleFor(m => m.NumberOfPages)
                .LessThan(15000).WithMessage("Amount unacceptable. Lower Number of Pages!")
                .GreaterThan(0).WithMessage("Amount unacceptable. Greater Number of Pages!");

        }
        protected bool BeAValidAuthorName (Author name)
        {
            Regex r = new Regex("^[a-zA-Z]+( [a-zA-Z]+)*$");

            return r.IsMatch(name.AuthorName);
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
