using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
     public static class CourseProcessor
    {
        public static List<Course> ViewCourses() => SqlDataAccess.LoadData<Course>("SELECT * FROM Courses");
    }
}
