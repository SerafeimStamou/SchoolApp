﻿using System;
using System.Windows.Forms;
using static DataLibrary.Helper;
using static DataLibrary.DataAccess.SqlDataAccess;
using DataLibrary.Models;

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
            var course = new Course();
           CoursesTable.DataSource = Read<Course>("SELECT * FROM Courses");
        }
    }
}
