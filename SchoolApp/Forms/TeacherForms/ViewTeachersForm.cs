using System;
using System.Windows.Forms;
using static DataLibrary.Helper;
using static DataLibrary.DataAccess.SqlDataAccess;
using DataLibrary.Models;

namespace SchoolApp.Forms.TeacherForms
{
    public partial class ViewTeachersForm : Form
    {
        public ViewTeachersForm()
        {
            InitializeComponent();
            TeachersTable.DataSource = Read<Teacher>("SELECT ID,FirstName,LastName,Email,Phone FROM Teachers");
        }

        private void ExitProgram_Click(object sender, EventArgs e) => Application.Exit();

        private void MainFormBtn_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            LoadForm(mainForm, this);
        }

        private void TeachersTable_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
