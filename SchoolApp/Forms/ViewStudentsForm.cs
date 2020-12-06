using System;
using System.Windows.Forms;
using static DataLibrary.Helper;
using static DataLibrary.StudentProcessor;
using static DataLibrary.DataAccess.SqlDataAccess;
using SchoolApp.Models;

namespace SchoolApp.Forms
{
    public partial class ViewStudentsForm : Form
    {
        public ViewStudentsForm()
        {
          InitializeComponent();
          StudentsTable.DataSource = ViewStudents();
        }

        private void MainFormBtn_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            LoadForm(mainForm, this);
        }

        private void ExitProgram_Click(object sender, EventArgs e) => Application.Exit();

        private void StudentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (StudentsTable.Columns[e.ColumnIndex].Name.Equals("EditBtn"))
            {
                int Id = Convert.ToInt32(StudentsTable.Rows[e.RowIndex].Cells[0].Value);
                string firstName = StudentsTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                string lastName = StudentsTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                string email = StudentsTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                string phone = StudentsTable.Rows[e.RowIndex].Cells[4].Value.ToString();
                DateTime birthDate = Convert.ToDateTime(StudentsTable.Rows[e.RowIndex].Cells[5].Value);
                bool isSubscribed = Convert.ToBoolean(StudentsTable.Rows[e.RowIndex].Cells[6].Value);

                var editStudentForm = new EditStudentForm(Id,firstName,lastName,email,phone,birthDate,isSubscribed);

                LoadForm(editStudentForm, this);
            }

            if (StudentsTable.Columns[e.ColumnIndex].Name.Equals("DeleteBtn"))
            {
                if (MessageBox.Show("Do you want to delete this student?", "Message",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int Id = Convert.ToInt32(StudentsTable.Rows[e.RowIndex].Cells[0].Value);

                    DeleteStudent(Id);

                    StudentsTable.DataSource = ViewStudents();
                }
            }
        }
    }
}
