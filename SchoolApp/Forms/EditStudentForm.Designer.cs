
namespace SchoolApp.Forms
{
    partial class EditStudentForm
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
            this.PhoneTxtBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.SubscribeCheckBox = new System.Windows.Forms.CheckBox();
            this.BirthDateDTPicker = new System.Windows.Forms.DateTimePicker();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ClearValuesBtn = new System.Windows.Forms.Button();
            this.ExitProgram = new System.Windows.Forms.Button();
            this.MainFormBtn = new System.Windows.Forms.Button();
            this.ViewStudentsBtn = new System.Windows.Forms.Button();
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
            this.FirstNameTxtBox.Location = new System.Drawing.Point(126, 3);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(206, 22);
            this.FirstNameTxtBox.TabIndex = 6;
            this.FirstNameTxtBox.TextChanged += new System.EventHandler(this.FirstNameTxtBox_TextChanged);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LastNameLabel.Location = new System.Drawing.Point(436, 3);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(106, 25);
            this.LastNameLabel.TabIndex = 7;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.Location = new System.Drawing.Point(548, 4);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(206, 22);
            this.LastNameTxtBox.TabIndex = 8;
            this.LastNameTxtBox.TextChanged += new System.EventHandler(this.LastNameTxtBox_TextChanged);
            // 
            // PhoneTxtBox
            // 
            this.PhoneTxtBox.Location = new System.Drawing.Point(548, 58);
            this.PhoneTxtBox.Name = "PhoneTxtBox";
            this.PhoneTxtBox.Size = new System.Drawing.Size(206, 22);
            this.PhoneTxtBox.TabIndex = 14;
            this.PhoneTxtBox.TextChanged += new System.EventHandler(this.PhoneTxtBox_TextChanged);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PhoneLabel.Location = new System.Drawing.Point(436, 58);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(69, 25);
            this.PhoneLabel.TabIndex = 13;
            this.PhoneLabel.Text = "Phone";
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Location = new System.Drawing.Point(126, 54);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(206, 22);
            this.EmailTxtBox.TabIndex = 12;
            this.EmailTxtBox.TextChanged += new System.EventHandler(this.EmailTxtBox_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.EmailLabel.Location = new System.Drawing.Point(26, 51);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(60, 25);
            this.EmailLabel.TabIndex = 11;
            this.EmailLabel.Text = "Email";
            // 
            // SubscribeCheckBox
            // 
            this.SubscribeCheckBox.AutoSize = true;
            this.SubscribeCheckBox.Location = new System.Drawing.Point(126, 193);
            this.SubscribeCheckBox.Name = "SubscribeCheckBox";
            this.SubscribeCheckBox.Size = new System.Drawing.Size(184, 21);
            this.SubscribeCheckBox.TabIndex = 17;
            this.SubscribeCheckBox.Text = "Subscribe To Newsletter";
            this.SubscribeCheckBox.UseVisualStyleBackColor = true;
            this.SubscribeCheckBox.CheckedChanged += new System.EventHandler(this.SubscribeCheckBox_CheckedChanged);
            // 
            // BirthDateDTPicker
            // 
            this.BirthDateDTPicker.Location = new System.Drawing.Point(126, 121);
            this.BirthDateDTPicker.Name = "BirthDateDTPicker";
            this.BirthDateDTPicker.Size = new System.Drawing.Size(206, 22);
            this.BirthDateDTPicker.TabIndex = 16;
            this.BirthDateDTPicker.ValueChanged += new System.EventHandler(this.BirthDateDTPicker_ValueChanged);
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BirthDateLabel.Location = new System.Drawing.Point(14, 118);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(97, 25);
            this.BirthDateLabel.TabIndex = 15;
            this.BirthDateLabel.Text = "Birth Date";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(223, 268);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(109, 60);
            this.UpdateBtn.TabIndex = 18;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ClearValuesBtn
            // 
            this.ClearValuesBtn.Location = new System.Drawing.Point(441, 268);
            this.ClearValuesBtn.Name = "ClearValuesBtn";
            this.ClearValuesBtn.Size = new System.Drawing.Size(109, 60);
            this.ClearValuesBtn.TabIndex = 19;
            this.ClearValuesBtn.Text = "Clear";
            this.ClearValuesBtn.UseVisualStyleBackColor = true;
            this.ClearValuesBtn.Click += new System.EventHandler(this.ClearValuesBtn_Click);
            // 
            // ExitProgram
            // 
            this.ExitProgram.Location = new System.Drawing.Point(691, 389);
            this.ExitProgram.Name = "ExitProgram";
            this.ExitProgram.Size = new System.Drawing.Size(109, 60);
            this.ExitProgram.TabIndex = 20;
            this.ExitProgram.Text = "Exit Program";
            this.ExitProgram.UseVisualStyleBackColor = true;
            this.ExitProgram.Click += new System.EventHandler(this.ExitProgram_Click);
            // 
            // MainFormBtn
            // 
            this.MainFormBtn.Location = new System.Drawing.Point(335, 389);
            this.MainFormBtn.Name = "MainFormBtn";
            this.MainFormBtn.Size = new System.Drawing.Size(109, 60);
            this.MainFormBtn.TabIndex = 21;
            this.MainFormBtn.Text = "Main Form";
            this.MainFormBtn.UseVisualStyleBackColor = true;
            this.MainFormBtn.Click += new System.EventHandler(this.MainFormBtn_Click);
            // 
            // ViewStudentsBtn
            // 
            this.ViewStudentsBtn.Location = new System.Drawing.Point(-2, 389);
            this.ViewStudentsBtn.Name = "ViewStudentsBtn";
            this.ViewStudentsBtn.Size = new System.Drawing.Size(109, 60);
            this.ViewStudentsBtn.TabIndex = 22;
            this.ViewStudentsBtn.Text = "View Students";
            this.ViewStudentsBtn.UseVisualStyleBackColor = true;
            this.ViewStudentsBtn.Click += new System.EventHandler(this.ViewStudentsBtn_Click);
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewStudentsBtn);
            this.Controls.Add(this.MainFormBtn);
            this.Controls.Add(this.ExitProgram);
            this.Controls.Add(this.ClearValuesBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.SubscribeCheckBox);
            this.Controls.Add(this.BirthDateDTPicker);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.PhoneTxtBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LastNameTxtBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameTxtBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "EditStudentForm";
            this.Text = "EditStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTxtBox;
        private System.Windows.Forms.TextBox PhoneTxtBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.CheckBox SubscribeCheckBox;
        private System.Windows.Forms.DateTimePicker BirthDateDTPicker;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ClearValuesBtn;
        private System.Windows.Forms.Button ExitProgram;
        private System.Windows.Forms.Button MainFormBtn;
        private System.Windows.Forms.Button ViewStudentsBtn;
    }
}