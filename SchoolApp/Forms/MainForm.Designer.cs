
namespace SchoolApp
{
    partial class MainForm
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
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.ViewStudentsBtn = new System.Windows.Forms.Button();
            this.ViewCoursesBtn = new System.Windows.Forms.Button();
            this.ViewEnrollmentsBtn = new System.Windows.Forms.Button();
            this.AddTeacherBtn = new System.Windows.Forms.Button();
            this.ViewTeachersBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitProgram
            // 
            this.ExitProgram.Location = new System.Drawing.Point(690, 389);
            this.ExitProgram.Name = "ExitProgram";
            this.ExitProgram.Size = new System.Drawing.Size(109, 60);
            this.ExitProgram.TabIndex = 0;
            this.ExitProgram.Text = "Exit Program";
            this.ExitProgram.UseVisualStyleBackColor = true;
            this.ExitProgram.Click += new System.EventHandler(this.ExitProgram_Click);
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.Location = new System.Drawing.Point(61, 23);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(109, 60);
            this.AddStudentBtn.TabIndex = 1;
            this.AddStudentBtn.Text = "Add Student";
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // ViewStudentsBtn
            // 
            this.ViewStudentsBtn.Location = new System.Drawing.Point(61, 141);
            this.ViewStudentsBtn.Name = "ViewStudentsBtn";
            this.ViewStudentsBtn.Size = new System.Drawing.Size(109, 60);
            this.ViewStudentsBtn.TabIndex = 2;
            this.ViewStudentsBtn.Text = "View Students";
            this.ViewStudentsBtn.UseVisualStyleBackColor = true;
            this.ViewStudentsBtn.Click += new System.EventHandler(this.ViewStudentsBtn_Click);
            // 
            // ViewCoursesBtn
            // 
            this.ViewCoursesBtn.Location = new System.Drawing.Point(284, 141);
            this.ViewCoursesBtn.Name = "ViewCoursesBtn";
            this.ViewCoursesBtn.Size = new System.Drawing.Size(109, 60);
            this.ViewCoursesBtn.TabIndex = 3;
            this.ViewCoursesBtn.Text = "View Courses";
            this.ViewCoursesBtn.UseVisualStyleBackColor = true;
            this.ViewCoursesBtn.Click += new System.EventHandler(this.ViewCoursesBtn_Click);
            // 
            // ViewEnrollmentsBtn
            // 
            this.ViewEnrollmentsBtn.Location = new System.Drawing.Point(284, 23);
            this.ViewEnrollmentsBtn.Name = "ViewEnrollmentsBtn";
            this.ViewEnrollmentsBtn.Size = new System.Drawing.Size(109, 60);
            this.ViewEnrollmentsBtn.TabIndex = 4;
            this.ViewEnrollmentsBtn.Text = "View Enrollments";
            this.ViewEnrollmentsBtn.UseVisualStyleBackColor = true;
            this.ViewEnrollmentsBtn.Click += new System.EventHandler(this.ViewEnrollmentsBtn_Click);
            // 
            // AddTeacherBtn
            // 
            this.AddTeacherBtn.Location = new System.Drawing.Point(482, 23);
            this.AddTeacherBtn.Name = "AddTeacherBtn";
            this.AddTeacherBtn.Size = new System.Drawing.Size(109, 60);
            this.AddTeacherBtn.TabIndex = 5;
            this.AddTeacherBtn.Text = "Add Teacher";
            this.AddTeacherBtn.UseVisualStyleBackColor = true;
            this.AddTeacherBtn.Click += new System.EventHandler(this.AddTeacherBtn_Click);
            // 
            // ViewTeachersBtn
            // 
            this.ViewTeachersBtn.Location = new System.Drawing.Point(482, 141);
            this.ViewTeachersBtn.Name = "ViewTeachersBtn";
            this.ViewTeachersBtn.Size = new System.Drawing.Size(109, 60);
            this.ViewTeachersBtn.TabIndex = 6;
            this.ViewTeachersBtn.Text = "View Teachers";
            this.ViewTeachersBtn.UseVisualStyleBackColor = true;
            this.ViewTeachersBtn.Click += new System.EventHandler(this.ViewTeachersBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewTeachersBtn);
            this.Controls.Add(this.AddTeacherBtn);
            this.Controls.Add(this.ViewEnrollmentsBtn);
            this.Controls.Add(this.ViewCoursesBtn);
            this.Controls.Add(this.ViewStudentsBtn);
            this.Controls.Add(this.AddStudentBtn);
            this.Controls.Add(this.ExitProgram);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitProgram;
        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.Button ViewStudentsBtn;
        private System.Windows.Forms.Button ViewCoursesBtn;
        private System.Windows.Forms.Button ViewEnrollmentsBtn;
        private System.Windows.Forms.Button AddTeacherBtn;
        private System.Windows.Forms.Button ViewTeachersBtn;
    }
}

