using DataLibrary.DataAccess;
using DataLibrary.Validators;
using FluentValidation.Results;
using SchoolApp.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataLibrary
{
    public static class StudentProcessor
    {
        public static void StudentValidation(Student student)
        {

            var validator = new StudentValidator();

            ValidationResult results = validator.Validate(student);

            if (results.IsValid == true)
            {
                if (student.ID == 0)
                    AddStudent(student);
                else
                    EditStudent(student);
            }
            else
            {
                foreach (ValidationFailure failure in results.Errors)
                {
                    MessageBox.Show($"{failure.PropertyName}: {failure.ErrorMessage}");
                }
            }
        }

        public static void AddStudent(Student student)
        {
            string sql = @"INSERT INTO Students(FirstName,LastName,Email,Phone,BirthDate,IsSubscribed)
                          VALUES(@FirstName,@LastName,@Email,@Phone,@BirthDate,@IsSubscribed)";

             SqlDataAccess.ManipulateData(sql, student);

             MessageBox.Show("Student added successfully");
        }

        public static void DeleteStudent(int Id)
        {
            var student = new Student();

            SqlDataAccess.ManipulateData($"DELETE FROM Students WHERE ID={Id}", student);

            MessageBox.Show("Student deleted successfully");
        }

        public static List<Student> ViewStudents() => SqlDataAccess.LoadData<Student>("SELECT * FROM Students ORDER BY LastName");

        public static void EditStudent(Student student)
        {
            string sql = (@"UPDATE Students SET FirstName=@FirstName,LastName=@LastName,Email=@Email,
                            Phone=@Phone,BirthDate=@BirthDate,IsSubscribed=@IsSubscribed WHERE ID=@ID");

            SqlDataAccess.ManipulateData<Student>(sql, student);

            MessageBox.Show("Student updated successfully");
        }
    }
}
