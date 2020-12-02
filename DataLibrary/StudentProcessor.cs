using DataLibrary.DataAccess;
using DataLibrary.Validators;
using FluentValidation.Results;
using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataLibrary
{
    public static class StudentProcessor
    {
        public static void CreateStudent(string firstName, string lastName, string email,
               string phone, DateTime birthDate, bool isSubscribed)
        {
            var student = new Student
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Phone = phone,
                BirthDate = birthDate,
                IsSubscribed = isSubscribed
            };

            ModelValidation(student);
        }

        public static void ModelValidation(Student student)
        {
            var validator = new StudentValidator();

            ValidationResult results = validator.Validate(student);

            if (results.IsValid == true)
            {
                CheckForDuplicates(student);
            }
            else
            {
                foreach (ValidationFailure failure in results.Errors)
                {
                  MessageBox.Show($"{failure.PropertyName}: {failure.ErrorMessage}");
                }
            }
        }

        public static void CheckForDuplicates(Student student)
        {
           var students = SqlDataAccess.Search("SELECT FirstName,LastName FROM Students WHERE FirstName=@FirstName AND LastName=@LastName", student);

            if(students.Count ==0)
            {
                AddStudent(student);
            }
            else
            {
                MessageBox.Show($"There are {students.Count} students with name {student.FirstName} {student.LastName}");
            }
        }
        public static int AddStudent(Student student)
        {
            string sql = @"INSERT INTO Students(FirstName,LastName,Email,Phone,BirthDate,IsSubscribed)
                          VALUES(@FirstName,@LastName,@Email,@Phone,@BirthDate,@IsSubscribed)";

            MessageBox.Show("Student added successfully");

            return SqlDataAccess.SaveData(sql, student);
        }

        public static List<Student> LoadStudents() => SqlDataAccess.LoadData<Student>("SELECT * FROM Students");
    }
}
