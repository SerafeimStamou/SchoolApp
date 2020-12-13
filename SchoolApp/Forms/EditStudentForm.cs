using SchoolApp.Models;
using System;
using System.Windows.Forms;
using static DataLibrary.Helper;
using static DataLibrary.StudentProcessor;

namespace SchoolApp.Forms
{
    public partial class EditStudentForm : Form
    {
        int ID;
        Student student = new Student();
        public EditStudentForm(int Id,string firstName,string lastName,string email,string phone,DateTime birthDate,bool isSubscribed)
        {
            InitializeComponent();

            FirstNameTxtBox.Text = firstName;
            LastNameTxtBox.Text = lastName;
            EmailTxtBox.Text = email;
            PhoneTxtBox.Text = phone;
            BirthDateDTPicker.Value = birthDate;
            SubscribeCheckBox.Checked = isSubscribed;
            ID = Id;
        }
        #region
        private void FirstNameTxtBox_TextChanged(object sender, EventArgs e) {}
        private void LastNameTxtBox_TextChanged(object sender, EventArgs e) {}
        private void EmailTxtBox_TextChanged(object sender, EventArgs e){}
        private void PhoneTxtBox_TextChanged(object sender, EventArgs e){}
        private void BirthDateDTPicker_ValueChanged(object sender, EventArgs e){}
        private void SubscribeCheckBox_CheckedChanged(object sender, EventArgs e) {}
        #endregion
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            student.CreateStudent(ID,FirstNameTxtBox.Text, LastNameTxtBox.Text, EmailTxtBox.Text,
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

        private void ExitProgram_Click(object sender, EventArgs e) => Application.Exit();
        
        private void MainFormBtn_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            LoadForm(mainForm,this);
        }

        private void ViewStudentsBtn_Click(object sender, EventArgs e)
        {
            var viewStudentsForm = new ViewStudentsForm();
            LoadForm(viewStudentsForm, this);
        }
    }
}
