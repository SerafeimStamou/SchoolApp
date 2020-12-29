using DataLibrary.Validators;
using System;
using FluentValidation.Results;
using System.Windows.Forms;
using static DataLibrary.DataAccess.SqlDataAccess;
using static DataLibrary.Helper;
using static DataLibrary.DataAccess.CRUDOperations;


namespace SchoolApp.Models
{
    public class Student
    {
        public int ID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public DateTime BirthDate { get; private set; }
        public bool IsSubscribed { get; private set; }

        public  void CreateStudent(int Id, string firstName, string lastName, string email,
              string phone, DateTime birthDate, bool isSubscribed)
        {
            var student = new Student
            {
                ID = Id,
                FirstName = InputFormat(firstName),
                LastName = InputFormat(lastName),
                Email = email,
                Phone = phone,
                BirthDate = birthDate,
                IsSubscribed = isSubscribed
            };

            SaveStudentToDatabase(student);
        }

        public bool StudentValidation(Student student)
        {
            var validator = new StudentValidator();

            ValidationResult results = validator.Validate(student);

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

        public void SaveStudentToDatabase(Student student)
        {
            bool isValid = StudentValidation(student);

            if(isValid)
            {
                if (student.ID == 0)
                {
                    var result = CheckForDuplicates(@"SELECT ID FROM Students WHERE FirstName=@FirstName AND LastName=@LastName
                                                     AND (Email=@Email OR Phone=@Phone)",student);

                    if (result == 0)
                    {
                        Create(@"INSERT INTO Students(FirstName,LastName,Email,Phone,BirthDate,IsSubscribed)
                               VALUES(@FirstName,@LastName,@Email,@Phone,@BirthDate,@IsSubscribed)", student);
                    }
                    else if(result >0)
                    {
                        MessageBox.Show("Student already exists");
                    }
                    else
                    {
                       return;
                    }
                }
                else
                {
                   Update(@"UPDATE Students SET FirstName=@FirstName,LastName=@LastName,Email=@Email,
                           Phone=@Phone,BirthDate=@BirthDate,IsSubscribed=@IsSubscribed WHERE ID=@ID", student);
                }
            }
        }
    }
}
