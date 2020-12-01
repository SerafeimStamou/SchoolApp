using FluentValidation;
using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Validators
{
    public class StudentValidator:AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(s => s.FirstName).Cascade(CascadeMode.Stop)
                                     .NotEmpty()
                                     .Length(2, 50)
                                     .Must(HasOnlyLetters).WithMessage("First name must have only letters");

            RuleFor(s => s.LastName).Cascade(CascadeMode.Stop)
                                    .NotEmpty()
                                    .Length(3, 50)
                                    .Must(HasOnlyLetters).WithMessage("Last name must have only letters");

            RuleFor(s => s.Email).EmailAddress();

            RuleFor(s => s.Phone).Cascade(CascadeMode.Stop)
                                 .NotEmpty()
                                 .Must(HasOnlyDigits).WithMessage("Phone must have only digits");

            RuleFor(s => s.BirthDate).Must(ValidYear).WithMessage("Please enter a valid date");
        }

        private bool HasOnlyLetters(string name) => name.All(Char.IsLetter);

        private bool ValidYear(DateTime date)
        {
            int currentYear = DateTime.Now.Year;
            int dateOfBirth = date.Year;

            return dateOfBirth < currentYear && dateOfBirth > (currentYear - 120);
        }

        private bool HasOnlyDigits(string phone) => phone.All(Char.IsDigit);
    }
}
