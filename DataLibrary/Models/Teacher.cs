﻿using DataLibrary.Validators;
using FluentValidation.Results;
using System.Windows.Forms;
using static DataLibrary.Helper;
using static DataLibrary.DataAccess.SqlDataAccess;

namespace DataLibrary.Models
{
    public class Teacher
    {
        public int ID { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Email { get; private set; }

        public string  Phone { get; private set; }

        public int CourseID { get; private set; }

        public void CreateTeacher(int Id, string firstName, string lastName, string email,
              string phone, int courseId)
        {
            var teacher= new Teacher
            {
                ID = Id,
                FirstName = InputFormat(firstName),
                LastName = InputFormat(lastName),
                Email = email,
                Phone = phone,
                CourseID=courseId
            };

            SaveTeacherToDatabase(teacher);
        }

        public bool TeacherValidation(Teacher teacher)
        {
            var validator = new TeacherValidator();

            ValidationResult results = validator.Validate(teacher);

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

        public void SaveTeacherToDatabase(Teacher teacher)
        {
            string sql;
            bool isValid = TeacherValidation(teacher);

            if(isValid)
            {
                if(teacher.ID==0)
                {
                     sql = @"INSERT INTO Teachers(FirstName,LastName,Email,Phone,CourseID)
                          VALUES(@FirstName,@LastName,@Email,@Phone,@CourseID)";
                    Create(sql, teacher);
                }
                else
                {
                      sql = @"UPDATE Teachers SET FirstName=@FirstName,LastName=@LastName,Email=@Email,
                            Phone=@Phone,CourseID=@CourseID WHERE ID=@ID";
                    Update(sql, teacher);
                }
            }
        }
    }
}
