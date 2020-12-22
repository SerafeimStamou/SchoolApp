
namespace SchoolApp.Forms.TeacherForms
{
    partial class AddTeacherForm
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PhoneTxtBox = new System.Windows.Forms.TextBox();
            this.CoursesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainFormBtn = new System.Windows.Forms.Button();
            this.ExitProgram = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ClearValuesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FirstNameLabel.Location = new System.Drawing.Point(1, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(106, 25);
            this.FirstNameLabel.TabIndex = 4;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Location = new System.Drawing.Point(113, 3);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(206, 22);
            this.FirstNameTxtBox.TabIndex = 6;
            this.FirstNameTxtBox.TextChanged += new System.EventHandler(this.FirstNameTxtBox_TextChanged);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LastNameLabel.Location = new System.Drawing.Point(462, 3);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(106, 25);
            this.LastNameLabel.TabIndex = 7;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.Location = new System.Drawing.Point(574, 4);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(206, 22);
            this.LastNameTxtBox.TabIndex = 8;
            this.LastNameTxtBox.TextChanged += new System.EventHandler(this.LastNameTxtBox_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.EmailLabel.Location = new System.Drawing.Point(12, 52);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(60, 25);
            this.EmailLabel.TabIndex = 9;
            this.EmailLabel.Text = "Email";
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Location = new System.Drawing.Point(113, 52);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(206, 22);
            this.EmailTxtBox.TabIndex = 10;
            this.EmailTxtBox.TextChanged += new System.EventHandler(this.EmailTxtBox_TextChanged);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PhoneLabel.Location = new System.Drawing.Point(471, 49);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(69, 25);
            this.PhoneLabel.TabIndex = 11;
            this.PhoneLabel.Text = "Phone";
            // 
            // PhoneTxtBox
            // 
            this.PhoneTxtBox.Location = new System.Drawing.Point(574, 55);
            this.PhoneTxtBox.Name = "PhoneTxtBox";
            this.PhoneTxtBox.Size = new System.Drawing.Size(206, 22);
            this.PhoneTxtBox.TabIndex = 12;
            this.PhoneTxtBox.TextChanged += new System.EventHandler(this.PhoneTxtBox_TextChanged);
            // 
            // CoursesListBox
            // 
            this.CoursesListBox.FormattingEnabled = true;
            this.CoursesListBox.ItemHeight = 16;
            this.CoursesListBox.Location = new System.Drawing.Point(113, 128);
            this.CoursesListBox.Name = "CoursesListBox";
            this.CoursesListBox.Size = new System.Drawing.Size(185, 212);
            this.CoursesListBox.TabIndex = 13;
            this.CoursesListBox.SelectedIndexChanged += new System.EventHandler(this.CoursesListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Courses";
            // 
            // MainFormBtn
            // 
            this.MainFormBtn.Location = new System.Drawing.Point(-2, 390);
            this.MainFormBtn.Name = "MainFormBtn";
            this.MainFormBtn.Size = new System.Drawing.Size(109, 60);
            this.MainFormBtn.TabIndex = 15;
            this.MainFormBtn.Text = "Main Form";
            this.MainFormBtn.UseVisualStyleBackColor = true;
            this.MainFormBtn.Click += new System.EventHandler(this.MainFormBtn_Click);
            // 
            // ExitProgram
            // 
            this.ExitProgram.Location = new System.Drawing.Point(691, 390);
            this.ExitProgram.Name = "ExitProgram";
            this.ExitProgram.Size = new System.Drawing.Size(109, 60);
            this.ExitProgram.TabIndex = 16;
            this.ExitProgram.Text = "Exit Program";
            this.ExitProgram.UseVisualStyleBackColor = true;
            this.ExitProgram.Click += new System.EventHandler(this.ExitProgram_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(330, 342);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(109, 60);
            this.SaveBtn.TabIndex = 17;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ClearValuesBtn
            // 
            this.ClearValuesBtn.Location = new System.Drawing.Point(505, 342);
            this.ClearValuesBtn.Name = "ClearValuesBtn";
            this.ClearValuesBtn.Size = new System.Drawing.Size(109, 60);
            this.ClearValuesBtn.TabIndex = 18;
            this.ClearValuesBtn.Text = "Clear";
            this.ClearValuesBtn.UseVisualStyleBackColor = true;
            this.ClearValuesBtn.Click += new System.EventHandler(this.ClearValuesBtn_Click);
            // 
            // AddTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearValuesBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ExitProgram);
            this.Controls.Add(this.MainFormBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CoursesListBox);
            this.Controls.Add(this.PhoneTxtBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LastNameTxtBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameTxtBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "AddTeacherForm";
            this.Text = "AddTeacherForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTxtBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox PhoneTxtBox;
        private System.Windows.Forms.ListBox CoursesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MainFormBtn;
        private System.Windows.Forms.Button ExitProgram;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ClearValuesBtn;
    }
}