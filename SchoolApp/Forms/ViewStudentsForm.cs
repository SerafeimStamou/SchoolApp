using System;
using System.Linq;
using System.Windows.Forms;
using static DataLibrary.Helper;
using static DataLibrary.StudentProcessor;


namespace SchoolApp.Forms
{
    public partial class ViewStudentsForm : Form
    {
        public ViewStudentsForm()
        {
          InitializeComponent();
          StudentsTable.DataSource =ViewStudents();
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

        private void SearchBtn_Click(object sender, EventArgs e) => Search();
        
        private void SearchTxtBox_TextChanged(object sender, EventArgs e) {}
        
        private void Search()
        {
            if(!String.IsNullOrEmpty(SearchTxtBox.Text))
            {
                if(ByLastName.Checked==true)
              StudentsTable.DataSource = ViewStudents().Where(s=>s.LastName.Equals(SearchTxtBox.Text)).ToList();

                if(ByEmail.Checked==true)
              StudentsTable.DataSource = ViewStudents().Where(s => s.Email.Equals(SearchTxtBox.Text)).ToList();

                if(ByPhone.Checked==true)
              StudentsTable.DataSource = ViewStudents().Where(s => s.Phone.Equals(SearchTxtBox.Text)).ToList();
            }
        }

        private void ViewAllBtn_Click(object sender, EventArgs e)
        {
            StudentsTable.DataSource = ViewStudents();
            SearchTxtBox.Clear();
            ByLastName.Checked = false;
            ByEmail.Checked = false;
            ByPhone.Checked = false;
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
    }
}
