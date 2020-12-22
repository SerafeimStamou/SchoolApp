using DataLibrary.Models;
using FluentValidation;
using System.Linq;

namespace DataLibrary.Validators
{
     public class TeacherValidator:AbstractValidator<Teacher>
    {
        public TeacherValidator()
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
        }

        private bool HasOnlyLetters(string name) => name.All(char.IsLetter);

        private bool HasOnlyDigits(string phone) => phone.All(char.IsDigit);
    }
}
