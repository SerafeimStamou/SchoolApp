using DataLibrary.DataAccess;
using DataLibrary.Models;
using System.Collections.Generic;

namespace DataLibrary
{
    public static class EnrollmentProcessor
    {
        public static List<Enrollment> ViewEnrollments()
        {
            string sql = @"select Title,FirstName,LastName,Enrollments.StudentID from Students inner Join Enrollments 
                     on Students.ID=Enrollments.StudentID inner join Courses ON Enrollments.CourseID = Courses.ID ORDER BY Title,LastName";

            return SqlDataAccess.LoadData<Enrollment>(sql);
        }

        public static void RemoveCourse(int studentId,int courseId)
        {
            var enrollment = new Enrollment { StudentID = studentId, CourseID = courseId };

            SqlDataAccess.ManipulateData("DELETE FROM Enrollments WHERE StudentID=@StudentID AND CourseID=@CourseID", enrollment);
        }

        public static void AddCourse(Enrollment enrollment)
        {
            string sql = "INSERT INTO Enrollments(StudentID,CourseID) VALUES (@StudentID,@CourseID)";

            SqlDataAccess.ManipulateData(sql, enrollment);
        }
    }
}
