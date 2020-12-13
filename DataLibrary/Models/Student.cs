using System;
using static DataLibrary.Helper;
using static DataLibrary.StudentProcessor;

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

            StudentValidation(student);
        }
    }
}
