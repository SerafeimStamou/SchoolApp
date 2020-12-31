using DataLibrary.Models;
using FluentValidation;
using FluentValidation.Results;
using System.Linq;
using System.Windows.Forms;

namespace DataLibrary.Validators
{
     public class TeacherValidator:AbstractValidator<Teacher>
    {
        public TeacherValidator()
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
        }

        private bool HasOnlyDigits(string phone) => phone.All(char.IsDigit);

        public bool TeacherValidation(Teacher teacher)
        {
            ValidationResult results = Validate(teacher);

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
