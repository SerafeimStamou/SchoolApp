using System;
using System.Windows.Forms;
using static DataLibrary.Helper;
using static DataLibrary.EnrollmentProcessor;

namespace SchoolApp.Forms
{
    public partial class Enrollments : Form
    {
        public Enrollments()
        {
            InitializeComponent();
            EnrollmentsTable.DataSource = ViewEnrollments();
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
