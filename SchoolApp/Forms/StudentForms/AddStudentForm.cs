﻿using System;
using System.Windows.Forms;
using static DataLibrary.Helper;
using SchoolApp.Models;

namespace SchoolApp.Forms
{
    public partial class AddStudentForm : Form
    {
        int Id=0;
        Student student = new Student();
        public AddStudentForm()
        {
          InitializeComponent();
        }

        #region
        private void FirstNameTxtBox_TextChanged(object sender, EventArgs e) { }
        private void LastNameTxtBox_TextChanged(object sender, EventArgs e) { }
        private void EmailTxtBox_TextChanged(object sender, EventArgs e) { }
        private void PhoneTxtBox_TextChanged(object sender, EventArgs e) { }
        private void BirthDateDTPicker_ValueChanged(object sender, EventArgs e) { }
        private void SubscribeCheckBox_CheckedChanged(object sender, EventArgs e) { }
        #endregion

        private void ExitProgram_Click(object sender, EventArgs e) => Application.Exit();

        private void MainFormBtn_Click(object sender, EventArgs e)
        {
          var mainForm = new MainForm();
          LoadForm(mainForm, this);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            student.CreateStudent(Id,FirstNameTxtBox.Text, LastNameTxtBox.Text, EmailTxtBox.Text,
            PhoneTxtBox.Text, BirthDateDTPicker.Value, SubscribeCheckBox.Checked);
        }

        private void ClearValuesBtn_Click(object sender, EventArgs e)
        {
            FirstNameTxtBox.Clear();
            LastNameTxtBox.Clear();
            EmailTxtBox.Clear();
            PhoneTxtBox.Clear();
            BirthDateDTPicker.ResetText();
            SubscribeCheckBox.Checked = false;
        }
    }
}
