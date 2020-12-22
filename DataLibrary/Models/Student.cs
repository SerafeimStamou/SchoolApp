using DataLibrary.Validators;
using System;
using static DataLibrary.DataAccess.SqlDataAccess;
using static DataLibrary.Helper;
using FluentValidation.Results;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

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

        public List<Student> CheckIfStudentExists(Student student)
        {
            var dbStudents = Read<Student>("SELECT FirstName,LastName,Email,Phone FROM Students");

            return dbStudents.Where(s => s.FirstName.Equals(student.FirstName) && s.LastName.Equals(student.LastName)
                           && (s.Email.Equals(student.Email) || s.Phone.Equals(student.Phone))).ToList();
                              
        }

        public void SaveStudentToDatabase(Student student)
        {
            bool isValid = StudentValidation(student);

            if(isValid)
            {
                if (student.ID == 0)
                {
                    var result = CheckIfStudentExists(student);

                    if (result.Count == 0)
                    {
                        Create(@"INSERT INTO Students(FirstName,LastName,Email,Phone,BirthDate,IsSubscribed)
                           VALUES(@FirstName,@LastName,@Email,@Phone,@BirthDate,@IsSubscribed)", student);
                    }
                    else
                    {
                        MessageBox.Show("Student already exists");
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
