using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static DataLibrary.Helper;
using static DataLibrary.DataAccess.SqlDataAccess;

namespace SchoolApp.Forms
{
    public partial class ViewStudentsForm : Form
    {
        List<Student> students = new List<Student>();
        Student student = new Student();
        public ViewStudentsForm()
        {
          InitializeComponent();

           LoadStudents();
        }

        private void LoadStudents()
        {
            students = Read<Student>("SELECT * FROM Students");
            StudentsTable.DataSource = students;
            NumberOfStudentsLabel.Text = "Total number of students:" + " " + students.Count.ToString();
        }

        private void MainFormBtn_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            LoadForm(mainForm, this);
        }

        private void ExitProgram_Click(object sender, EventArgs e) => Application.Exit();

        private void StudentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (StudentsTable.Columns[e.ColumnIndex].Name.Equals("EnrollBtn"))
            {
                LoadEnrollForm(sender,e);
            }

            if (StudentsTable.Columns[e.ColumnIndex].Name.Equals("EditBtn"))
            {
                LoadEditForm(sender, e);
            }

            if (StudentsTable.Columns[e.ColumnIndex].Name.Equals("DeleteBtn"))
            {
                DeleteRecord(sender, e);
            }
        }

        private void LoadEnrollForm(object sender, DataGridViewCellEventArgs e)
        {
            #region
            int Id = Convert.ToInt32(StudentsTable.Rows[e.RowIndex].Cells[0].Value);
            string firstName = StudentsTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            string lastName = StudentsTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            #endregion
            var enrollForm = new EnrollForm(Id,firstName,lastName);
            LoadForm(enrollForm, this);
        }
        private void LoadEditForm(object sender, DataGridViewCellEventArgs e)
        {
            #region 
            int Id = Convert.ToInt32(StudentsTable.Rows[e.RowIndex].Cells[0].Value);
            string firstName = StudentsTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            string lastName = StudentsTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            string email = StudentsTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            string phone = StudentsTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            DateTime birthDate = Convert.ToDateTime(StudentsTable.Rows[e.RowIndex].Cells[5].Value);
            bool isSubscribed = Convert.ToBoolean(StudentsTable.Rows[e.RowIndex].Cells[6].Value);
            #endregion  
            var editStudentForm = new EditStudentForm(Id, firstName, lastName, email, phone, birthDate, isSubscribed);

            LoadForm(editStudentForm, this);
        }

        private void DeleteRecord(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this student?", "Message",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int Id = Convert.ToInt32(StudentsTable.Rows[e.RowIndex].Cells[0].Value);

                Delete(Id,student);

                LoadStudents();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e) => Search();

        private void Search()
        {
            if(!String.IsNullOrEmpty(SearchTxtBox.Text))
            {
                if(ByLastName.Checked==true)
              StudentsTable.DataSource = students.Where(s=>s.LastName.Equals(SearchTxtBox.Text)).ToList();

                if(ByEmail.Checked==true)
              StudentsTable.DataSource = students.Where(s => s.Email.Equals(SearchTxtBox.Text)).ToList();

                if(ByPhone.Checked==true)
              StudentsTable.DataSource = students.Where(s => s.Phone.Equals(SearchTxtBox.Text)).ToList();
            }
        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            SearchTxtBox.Clear();
            ByLastName.Checked = false;
            ByEmail.Checked = false;
            ByPhone.Checked = false;

            LoadStudents();
        }

        private void ByLastName_CheckedChanged(object sender, EventArgs e)
        {
            if(ByLastName.Checked==true)
            {
                ByEmail.Checked = false;
                ByPhone.Checked = false;
            }
        }

        private void ByEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (ByEmail.Checked == true)
            {
                ByLastName.Checked = false;
                ByPhone.Checked = false;
            }
        }

        private void ByPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (ByPhone.Checked == true)
            {
                ByLastName.Checked = false;
                ByEmail.Checked = false;
            }
        }

        private void SearchTxtBox_TextChanged(object sender, EventArgs e) { }
        private void NumberOfStudentsLabel_Click(object sender, EventArgs e) { }
    }
}
