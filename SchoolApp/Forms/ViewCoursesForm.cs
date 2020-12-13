using System;
using System.Windows.Forms;
using static DataLibrary.Helper;
using static DataLibrary.CourseProcessor;

namespace SchoolApp.Forms
{
    public partial class ViewCoursesForm : Form
    {
        public ViewCoursesForm()
        {
            InitializeComponent();

            LoadCourses();
        }

        private void ExitProgram_Click(object sender, EventArgs e) => Application.Exit();

        private void MainFormBtn_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            LoadForm(mainForm, this);
        }

        private void CoursesTable_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void LoadCourses()
        {
           CoursesTable.DataSource = ViewCourses();
        }
    }
}
