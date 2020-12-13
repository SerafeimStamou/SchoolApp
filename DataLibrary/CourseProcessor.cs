using DataLibrary.DataAccess;
using DataLibrary.Models;
using System.Collections.Generic;

namespace DataLibrary
{
     public static class CourseProcessor
    {
        public static List<Course> ViewCourses() => SqlDataAccess.LoadData<Course>("SELECT * FROM Courses");
    }
}
