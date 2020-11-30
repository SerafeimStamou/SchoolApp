using DataLibrary.DataAccess;
using SchoolApp.Models;
using System;
using System.Collections.Generic;


namespace DataLibrary
{
    public static class StudentProcessor
    {
      public static int AddStudent(string firstName,string lastName,string email,
             string phone,DateTime birthDate,bool isSubscribed)
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

            string sql = @"INSERT INTO Students(FirstName,LastName,Email,Phone,BirthDate,IsSubscribed)
                          VALUES(@FirstName,@LastName,@Email,@Phone,@BirthDate,@IsSubscribed)";

            return SqlDataAccess.SaveData(sql, student);
      }

        public static List<Student> LoadStudents() => SqlDataAccess.LoadData<Student>("SELECT * FROM Students");
    }
}
