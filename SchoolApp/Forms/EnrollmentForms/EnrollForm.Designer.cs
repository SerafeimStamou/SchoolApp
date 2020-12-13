
namespace SchoolApp.Forms
{
    partial class EnrollForm
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
            this.ExitProgram = new System.Windows.Forms.Button();
            this.CourseList = new System.Windows.Forms.ListBox();
            this.CoursesThatAlreadyFollowsList = new System.Windows.Forms.ListBox();
            this.MainFormBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoadStudentsTable = new System.Windows.Forms.Button();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.RemoveCourseBtn = new System.Windows.Forms.Button();
            this.AddCourseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitProgram
            // 
            this.ExitProgram.Location = new System.Drawing.Point(690, 390);
            this.ExitProgram.Name = "ExitProgram";
            this.ExitProgram.Size = new System.Drawing.Size(109, 60);
            this.ExitProgram.TabIndex = 2;
            this.ExitProgram.Text = "Exit Program";
            this.ExitProgram.UseVisualStyleBackColor = true;
            this.ExitProgram.Click += new System.EventHandler(this.ExitProgram_Click);
            // 
            // CourseList
            // 
            this.CourseList.FormattingEnabled = true;
            this.CourseList.ItemHeight = 16;
            this.CourseList.Location = new System.Drawing.Point(46, 98);
            this.CourseList.Name = "CourseList";
            this.CourseList.Size = new System.Drawing.Size(216, 276);
            this.CourseList.TabIndex = 3;
            this.CourseList.SelectedIndexChanged += new System.EventHandler(this.CourseList_SelectedIndexChanged);
            // 
            // CoursesThatAlreadyFollowsList
            // 
            this.CoursesThatAlreadyFollowsList.FormattingEnabled = true;
            this.CoursesThatAlreadyFollowsList.ItemHeight = 16;
            this.CoursesThatAlreadyFollowsList.Location = new System.Drawing.Point(572, 98);
            this.CoursesThatAlreadyFollowsList.Name = "CoursesThatAlreadyFollowsList";
            this.CoursesThatAlreadyFollowsList.Size = new System.Drawing.Size(216, 276);
            this.CoursesThatAlreadyFollowsList.TabIndex = 4;
            this.CoursesThatAlreadyFollowsList.SelectedIndexChanged += new System.EventHandler(this.CoursesThatAlreadyFollowsList_SelectedIndexChanged);
            // 
            // MainFormBtn
            // 
            this.MainFormBtn.Location = new System.Drawing.Point(364, 390);
            this.MainFormBtn.Name = "MainFormBtn";
            this.MainFormBtn.Size = new System.Drawing.Size(109, 60);
            this.MainFormBtn.TabIndex = 5;
            this.MainFormBtn.Text = "Main Form";
            this.MainFormBtn.UseVisualStyleBackColor = true;
            this.MainFormBtn.Click += new System.EventHandler(this.MainFormBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Courses that already follows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "List of courses";
            // 
            // LoadStudentsTable
            // 
            this.LoadStudentsTable.Location = new System.Drawing.Point(1, 390);
            this.LoadStudentsTable.Name = "LoadStudentsTable";
            this.LoadStudentsTable.Size = new System.Drawing.Size(109, 60);
            this.LoadStudentsTable.TabIndex = 8;
            this.LoadStudentsTable.Text = "Back";
            this.LoadStudentsTable.UseVisualStyleBackColor = true;
            this.LoadStudentsTable.Click += new System.EventHandler(this.LoadStudentsTable_Click);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FullNameLabel.Location = new System.Drawing.Point(359, 9);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(64, 25);
            this.FullNameLabel.TabIndex = 9;
            this.FullNameLabel.Text = "label3";
            this.FullNameLabel.Click += new System.EventHandler(this.FullNameLabel_Click);
            // 
            // RemoveCourseBtn
            // 
            this.RemoveCourseBtn.Location = new System.Drawing.Point(441, 98);
            this.RemoveCourseBtn.Name = "RemoveCourseBtn";
            this.RemoveCourseBtn.Size = new System.Drawing.Size(109, 49);
            this.RemoveCourseBtn.TabIndex = 10;
            this.RemoveCourseBtn.Text = "Remove Course";
            this.RemoveCourseBtn.UseVisualStyleBackColor = true;
            this.RemoveCourseBtn.Click += new System.EventHandler(this.RemoveCourseBtn_Click);
            // 
            // AddCourseBtn
            // 
            this.AddCourseBtn.Location = new System.Drawing.Point(279, 98);
            this.AddCourseBtn.Name = "AddCourseBtn";
            this.AddCourseBtn.Size = new System.Drawing.Size(109, 49);
            this.AddCourseBtn.TabIndex = 11;
            this.AddCourseBtn.Text = "Add Course";
            this.AddCourseBtn.UseVisualStyleBackColor = true;
            this.AddCourseBtn.Click += new System.EventHandler(this.AddCourseBtn_Click);
            // 
            // EnrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddCourseBtn);
            this.Controls.Add(this.RemoveCourseBtn);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.LoadStudentsTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainFormBtn);
            this.Controls.Add(this.CoursesThatAlreadyFollowsList);
            this.Controls.Add(this.CourseList);
            this.Controls.Add(this.ExitProgram);
            this.Name = "EnrollForm";
            this.Text = "EnrollForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitProgram;
        private System.Windows.Forms.ListBox CourseList;
        private System.Windows.Forms.ListBox CoursesThatAlreadyFollowsList;
        private System.Windows.Forms.Button MainFormBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoadStudentsTable;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Button RemoveCourseBtn;
        private System.Windows.Forms.Button AddCourseBtn;
    }
}