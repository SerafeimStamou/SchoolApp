using System;
using System.Windows.Forms;
using DataLibrary.Models;
using static DataLibrary.Helper;
using static DataLibrary.DataAccess.CRUDOperations;

namespace SchoolApp.Forms.TeacherForms
{
    public partial class ViewTeachersForm : Form
    {
        public ViewTeachersForm()
        {
            InitializeComponent();

            ViewTeachersTable.DataSource = Read<Teacher>(@"SELECT Teachers.ID,FirstName,LastName,Email,Phone,Courses.Title AS Teaches FROM Teachers
                                               INNER JOIN Courses ON Teachers.CourseID=Courses.ID");
        }

        private void ExitProgram_Click(object sender, EventArgs e) => Application.Exit();

        private void MainFormBtn_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            LoadForm(mainForm, this);
        }

        private void ViewTeachersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ViewTeachersTable.Columns[e.ColumnIndex].Name.Equals("EditBtn"))
            {
                LoadEditForm(sender, e);
            }
            else
            {
                DeleteRecord(sender, e);
            }
        }

        private void LoadEditForm(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Convert.ToInt32(ViewTeachersTable.Rows[e.RowIndex].Cells[0].Value);
            string firstName = ViewTeachersTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            string lastName = ViewTeachersTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            string email = ViewTeachersTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            string phone = ViewTeachersTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            string title = ViewTeachersTable.Rows[e.RowIndex].Cells[5].Value.ToString();

            var editTeacherForm = new EditTeacherForm(Id, firstName, lastName, email, phone, title);

            LoadForm(editTeacherForm, this);
        }

        private void DeleteRecord(object sender, DataGridViewCellEventArgs e)
        {
            Teacher teacher = new Teacher();

            if (MessageBox.Show("Do you want to delete this teacher?", "Message",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int Id = Convert.ToInt32(ViewTeachersTable.Rows[e.RowIndex].Cells[0].Value);

                Delete($"DELETE FROM Teachers WHERE ID={Id}",teacher,true);

                ViewTeachersTable.DataSource = Read<Teacher>(@"SELECT Teachers.ID,FirstName,LastName,Email,Phone,Courses.Title AS Teaches FROM Teachers
                                               INNER JOIN Courses ON Teachers.CourseID=Courses.ID");
            }
        }
    }
}
