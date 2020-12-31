using FluentValidation;
using FluentValidation.Results;
using SchoolApp.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DataLibrary.Validators
{
    public class StudentValidator:AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(s => s.FirstName).Cascade(CascadeMode.Stop)
                                     .NotEmpty()
                                     .Length(2, 50);
         
            RuleFor(s => s.LastName).Cascade(CascadeMode.Stop)
                                    .NotEmpty()
                                    .Length(3, 50);

            RuleFor(s => s.Email).EmailAddress();

            RuleFor(s => s.Phone).Cascade(CascadeMode.Stop)
                                 .NotEmpty()
                                 .Must(HasOnlyDigits).WithMessage("Phone must have only digits");

            RuleFor(s => s.BirthDate).Must(ValidYear).WithMessage("Please enter a valid date");
        }

        private bool ValidYear(DateTime date)
        {
            int currentYear = DateTime.Now.Year;
            int dateOfBirth = date.Year;

            return dateOfBirth < currentYear && dateOfBirth > (currentYear - 120);
        }

        private bool HasOnlyDigits(string phone) => phone.All(char.IsDigit);

        public bool StudentValidation(Student student)
        {
            ValidationResult results = Validate(student);

            if (results.IsValid == true)
            {
                return true;
            }
            else
            {
                foreach (ValidationFailure failure in results.Errors)
                {
                    MessageBox.Show($"{failure.PropertyName}: {failure.ErrorMessage}");
                }

                return false;
            }
        }
    }
}
