
namespace SchoolApp.Forms
{
    partial class ViewCoursesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ExitProgram = new System.Windows.Forms.Button();
            this.MainFormBtn = new System.Windows.Forms.Button();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CoursesTable = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursPerWeekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitProgram
            // 
            this.ExitProgram.Location = new System.Drawing.Point(689, 389);
            this.ExitProgram.Name = "ExitProgram";
            this.ExitProgram.Size = new System.Drawing.Size(109, 60);
            this.ExitProgram.TabIndex = 1;
            this.ExitProgram.Text = "Exit Program";
            this.ExitProgram.UseVisualStyleBackColor = true;
            this.ExitProgram.Click += new System.EventHandler(this.ExitProgram_Click);
            // 
            // MainFormBtn
            // 
            this.MainFormBtn.Location = new System.Drawing.Point(-2, 389);
            this.MainFormBtn.Name = "MainFormBtn";
            this.MainFormBtn.Size = new System.Drawing.Size(109, 60);
            this.MainFormBtn.TabIndex = 3;
            this.MainFormBtn.Text = "Main Form";
            this.MainFormBtn.UseVisualStyleBackColor = true;
            this.MainFormBtn.Click += new System.EventHandler(this.MainFormBtn_Click);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(DataLibrary.Models.Course);
            // 
            // CoursesTable
            // 
            this.CoursesTable.AutoGenerateColumns = false;
            this.CoursesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.hoursPerWeekDataGridViewTextBoxColumn});
            this.CoursesTable.DataSource = this.courseBindingSource;
            this.CoursesTable.Location = new System.Drawing.Point(0, 0);
            this.CoursesTable.Name = "CoursesTable";
            this.CoursesTable.RowHeadersWidth = 51;
            this.CoursesTable.RowTemplate.Height = 24;
            this.CoursesTable.Size = new System.Drawing.Size(431, 281);
            this.CoursesTable.TabIndex = 4;
            this.CoursesTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CoursesTable_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoursPerWeekDataGridViewTextBoxColumn
            // 
            this.hoursPerWeekDataGridViewTextBoxColumn.DataPropertyName = "HoursPerWeek";
            this.hoursPerWeekDataGridViewTextBoxColumn.HeaderText = "HoursPerWeek";
            this.hoursPerWeekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoursPerWeekDataGridViewTextBoxColumn.Name = "hoursPerWeekDataGridViewTextBoxColumn";
            this.hoursPerWeekDataGridViewTextBoxColumn.Width = 125;
            // 
            // ViewCoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CoursesTable);
            this.Controls.Add(this.MainFormBtn);
            this.Controls.Add(this.ExitProgram);
            this.Name = "ViewCoursesForm";
            this.Text = "ViewCourses";
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitProgram;
        private System.Windows.Forms.Button MainFormBtn;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.DataGridView CoursesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursPerWeekDataGridViewTextBoxColumn;
    }
}