using System;
using System.Windows.Forms;
using static DataLibrary.Helper;
using DataLibrary.Models;
using static DataLibrary.DataAccess.CRUDOperations;

namespace SchoolApp.Forms
{
   
    public partial class Enrollments : Form
    {
        public Enrollments()
        {
            InitializeComponent();
            EnrollmentsTable.DataSource = Read<Enrollment>(@"select Title,FirstName,LastName,Enrollments.StudentID from Students inner Join Enrollments 
                     on Students.ID=Enrollments.StudentID inner join Courses ON Enrollments.CourseID = Courses.ID ORDER BY Title,LastName");
        }

        private void MainFormBtn_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            LoadForm(mainForm, this);
        }

        private void ExitProgram_Click(object sender, EventArgs e) => Application.Exit();

        private void EnrollmentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void Enrollments_Load(object sender, EventArgs e)
        {

        }
    }
}
