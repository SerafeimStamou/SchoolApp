using SchoolApp.Forms;
using SchoolApp.Forms.TeacherForms;
using System;
using System.Windows.Forms;
using static DataLibrary.Helper;

namespace SchoolApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitProgram_Click(object sender, EventArgs e) => Application.Exit();

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
          var addStudentForm = new AddStudentForm();
          LoadForm(addStudentForm, this);
        }

        private void ViewStudentsBtn_Click(object sender, EventArgs e)
        {
            var viewStudentsForm = new ViewStudentsForm();
            LoadForm(viewStudentsForm, this);
        }

        private void ViewCoursesBtn_Click(object sender, EventArgs e)
        {
            var viewCoursesForm = new ViewCoursesForm();
            LoadForm(viewCoursesForm, this);
        }

        private void ViewEnrollmentsBtn_Click(object sender, EventArgs e)
        {
            var enrollments = new Enrollments();
            LoadForm(enrollments, this);
        }

        private void AddTeacherBtn_Click(object sender, EventArgs e)
        {
            var addTeacherForm = new AddTeacherForm();
            LoadForm(addTeacherForm, this);
        }

        private void ViewTeachersBtn_Click(object sender, EventArgs e)
        {
            var viewTeachersForm = new ViewTeachersForm();
            LoadForm(viewTeachersForm, this);
        }
    }
}
