using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using static DataLibrary.Helper;
using static DataLibrary.DataAccess.CRUDOperations;


namespace SchoolApp.Forms.TeacherForms
{
    public partial class AddTeacherForm : Form
    {
        List<Course> courses = new List<Course>();
        Teacher teacher = new Teacher();
        int courseId;
        int ID = 0;
        
        public AddTeacherForm()
        {
            InitializeComponent();

            LoadCourses();
        }

        private void MainFormBtn_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            LoadForm(mainForm, this);
        }

        private void ExitProgram_Click(object sender, EventArgs e) => Application.Exit();

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            courseId = courses.Where(c => c.Title.Equals(CoursesListBox.SelectedValue)).Select(c => c.ID).Single();

            teacher.CreateTeacher(ID,FirstNameTxtBox.Text, LastNameTxtBox.Text, EmailTxtBox.Text, PhoneTxtBox.Text, courseId);
        }

        private void ClearValuesBtn_Click(object sender, EventArgs e)
        {
            FirstNameTxtBox.Clear();
            LastNameTxtBox.Clear();
            EmailTxtBox.Clear();
            PhoneTxtBox.Clear();
        }

        private void LoadCourses()
        {
            courses = Read<Course>("SELECT ID,Title FROM Courses");
            CoursesListBox.DataSource = courses.Select(c => c.Title).ToList();
        }

        #region
        private void FirstNameTxtBox_TextChanged(object sender, EventArgs e) { }
        private void LastNameTxtBox_TextChanged(object sender, EventArgs e) { }
        private void EmailTxtBox_TextChanged(object sender, EventArgs e) { }
        private void PhoneTxtBox_TextChanged(object sender, EventArgs e) { }
        private void CoursesListBox_SelectedIndexChanged(object sender, EventArgs e) { }
        #endregion
    }
}
