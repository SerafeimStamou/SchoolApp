﻿using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static DataLibrary.DataAccess.SqlDataAccess;
using static DataLibrary.Helper;

namespace SchoolApp.Forms
{
    public partial class EnrollForm : Form
    {
        List<Course> courses = new List<Course>();
        List<Enrollment> enrollments = new List<Enrollment>();
        int studentID;
        Course course = new Course();
        Enrollment enrollment = new Enrollment();

        public EnrollForm(int Id,string firstName,string lastName)
        {
            InitializeComponent();

            FullNameLabel.Text = firstName + " " + lastName;

            studentID = Id;

            LoadCourses();

            LoadEnrollments(studentID);
        }

        private void ExitProgram_Click(object sender, EventArgs e) => Application.Exit();

        private void MainFormBtn_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            LoadForm(mainForm, this);
        }

        private void LoadStudentsTable_Click(object sender, EventArgs e)
        {
            var viewStudentsForm = new ViewStudentsForm();
            LoadForm(viewStudentsForm, this);
        }

        private void LoadCourses()
        {
            courses = Read<Course>("SELECT ID,Title FROM Courses");
            CourseList.DataSource = courses.Select(c => c.Title).ToList();
        }

        private void LoadEnrollments(int Id)
        {
            enrollments = enrollment.ViewEnrollments();
            CoursesThatAlreadyFollowsList.DataSource = enrollments
                                                .Where(e => e.StudentID == Id).Select(c => c.Title).ToList();
        }

        private void RemoveCourseBtn_Click(object sender, EventArgs e)
        {
            string title = CoursesThatAlreadyFollowsList.SelectedItem.ToString();
            int courseID = courses.Where(c => c.Title.Equals(title)).Select(c => c.ID).SingleOrDefault();

            enrollment.RemoveCourse(studentID, courseID);

            LoadEnrollments(studentID);
        }

        private void AddCourseBtn_Click(object sender, EventArgs e)
        {
            string title = CourseList.SelectedItem.ToString();
            int courseID = courses.Where(c => c.Title.Equals(title)).Select(c => c.ID).SingleOrDefault();

            enrollment.AddCourse(studentID,courseID);

            LoadEnrollments(studentID);
        }

        #region
        private void CourseList_SelectedIndexChanged(object sender, EventArgs e) {}
        private void CoursesThatAlreadyFollowsList_SelectedIndexChanged(object sender, EventArgs e) {}
        private void FullNameLabel_Click(object sender, EventArgs e) { }
        #endregion
    }
}
