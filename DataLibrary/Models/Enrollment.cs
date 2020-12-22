using DataLibrary.DataAccess;
using System.Collections.Generic;


namespace DataLibrary.Models
{
    public class Enrollment
    {
        public int StudentID { get; private set; }

        public int CourseID { get; private set; }

        public string Title { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }


        public List<Enrollment> ViewEnrollments()
        {
            var enrollment = new Enrollment();
            string sql = @"select Title,FirstName,LastName,Enrollments.StudentID from Students inner Join Enrollments 
                     on Students.ID=Enrollments.StudentID inner join Courses ON Enrollments.CourseID = Courses.ID ORDER BY Title,LastName";

            return SqlDataAccess.Read<Enrollment>(sql);
        }

        public void RemoveCourse(int studentId, int courseId)
        {
            var enrollment = new Enrollment();

            SqlDataAccess.ManipulateData($"DELETE FROM Enrollments WHERE StudentID={studentId} AND CourseID={courseId}", enrollment);
        }

        public void AddCourse(int studentID, int courseID)
        {
            var enrollment = new Enrollment();

            string sql = $"INSERT INTO Enrollments(StudentID,CourseID) VALUES ({studentID},{courseID})";

            SqlDataAccess.ManipulateData(sql, enrollment);
        }
    }
}
