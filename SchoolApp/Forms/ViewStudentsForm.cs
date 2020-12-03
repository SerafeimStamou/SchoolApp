using System;
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
          StudentsTable.DataSource = LoadStudents();
        }

        private void MainFormBtn_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            LoadForm(mainForm, this);
        }

        private void ExitProgram_Click(object sender, EventArgs e) => Application.Exit();

        private void StudentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
