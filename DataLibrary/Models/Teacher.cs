using DataLibrary.Validators;
using System.Windows.Forms;
using static DataLibrary.Helper;
using static DataLibrary.DataAccess.SqlDataAccess;
using static DataLibrary.DataAccess.CRUDOperations;


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
        public string Teaches { get; private set; }

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

        public void SaveTeacherToDatabase(Teacher teacher)
        {
            var validator = new TeacherValidator();
            bool isValid = validator.TeacherValidation(teacher);

            if(isValid)
            {
                if (teacher.ID==0)
                {
                    var result = CheckForDuplicates(@"SELECT ID FROM Teachers WHERE FirstName=@FirstName AND LastName=@LastName
                                                     AND (Email=@Email OR Phone=@Phone)",teacher);

                    Insert(result, teacher);
                }
                else
                {
                   Update(@"UPDATE Teachers SET FirstName=@FirstName,LastName=@LastName,Email=@Email,
                          Phone=@Phone,CourseID=@CourseID WHERE ID=@ID", teacher,true);
                }
            }
        }

        public void Insert(int result,Teacher teacher)
        {
            if (result == 0)
            {
                Create(@"INSERT INTO Teachers(FirstName,LastName,Email,Phone,CourseID)
                                VALUES(@FirstName,@LastName,@Email,@Phone,@CourseID)", teacher,true);
            }
            else if (result > 0)
            {
                MessageBox.Show("Teacher already exists");
            }
            else
            {
                return;
            }
        }
    }
}
