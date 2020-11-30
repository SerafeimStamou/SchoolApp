using System;


namespace SchoolApp.Models
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime BirthDate { get; set; }

        public bool IsSubscribed { get; set; }
    }
}
