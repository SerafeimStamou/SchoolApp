using System;
using System.Windows.Forms;
using static DataLibrary.Helper;
using DataLibrary.Models;
using static DataLibrary.DataAccess.CRUDOperations;


namespace SchoolApp.Forms
{
    public partial class ViewCoursesForm : Form
    {
        
        public ViewCoursesForm()
        {
            InitializeComponent();

            CoursesTable.DataSource = Read<Course>("SELECT * FROM Courses");
        }

        private void ExitProgram_Click(object sender, EventArgs e) => Application.Exit();

        private void MainFormBtn_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            LoadForm(mainForm, this);
        }

        private void CoursesTable_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
