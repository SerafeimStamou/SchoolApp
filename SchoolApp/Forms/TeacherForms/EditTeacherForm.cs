using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static DataLibrary.Helper;
using static DataLibrary.DataAccess.CRUDOperations;

namespace SchoolApp.Forms.TeacherForms
{
    public partial class EditTeacherForm : Form
    {
        List<Course> courses = new List<Course>();
        Teacher teacher = new Teacher();
        int ID;
        int courseId;

        public EditTeacherForm(int Id, string firstName, string lastName, string email, string phone,string title)
        {
            InitializeComponent();

            LoadCourses();

            ID = Id;
            FirstNameTxtBox.Text = firstName;
            LastNameTxtBox.Text = lastName;
            EmailTxtBox.Text = email;
            PhoneTxtBox.Text = phone;
            CoursesListBox.SelectedItem = title;
        }

        private void FirstNameTxtBox_TextChanged(object sender, EventArgs e) { }
        private void LastNameTxtBox_TextChanged(object sender, EventArgs e) { }
        private void EmailTxtBox_TextChanged(object sender, EventArgs e) { }
        private void PhoneTxtBox_TextChanged(object sender, EventArgs e) { }
        private void CoursesListBox_SelectedIndexChanged(object sender, EventArgs e) { }

        private void ExitProgram_Click(object sender, EventArgs e) => Application.Exit();

        private void MainFormBtn_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            LoadForm(mainForm, this);
        }

        private void ClearValuesBtn_Click(object sender, EventArgs e)
        {
            FirstNameTxtBox.Clear();
            LastNameTxtBox.Clear();
            EmailTxtBox.Clear();
            PhoneTxtBox.Clear();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            courseId = courses.Where(c => c.Title.Equals(CoursesListBox.SelectedValue)).Select(c => c.ID).Single();

            teacher.CreateTeacher(ID, FirstNameTxtBox.Text, LastNameTxtBox.Text, EmailTxtBox.Text, PhoneTxtBox.Text, courseId);
        }

        private void LoadCourses()
        {
            courses = Read<Course>("SELECT ID,Title FROM Courses");
            CoursesListBox.DataSource = courses.Select(c => c.Title).ToList();
        }
    }
}
