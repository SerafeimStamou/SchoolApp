using System;
using System.Windows.Forms;
using static DataLibrary.Helper;
using DataLibrary.Models;

namespace SchoolApp.Forms
{
   
    public partial class Enrollments : Form
    {
        Enrollment enrollment = new Enrollment();
        public Enrollments()
        {
            InitializeComponent();
            EnrollmentsTable.DataSource = enrollment.ViewEnrollments();
        }

        private void MainFormBtn_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            LoadForm(mainForm, this);
        }

        private void ExitProgram_Click(object sender, EventArgs e) => Application.Exit();

        private void EnrollmentsTable_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
