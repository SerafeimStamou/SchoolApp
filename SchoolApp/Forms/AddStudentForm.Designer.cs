
namespace SchoolApp.Forms
{
    partial class AddStudentForm
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
            this.MainFormBtn = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PhoneTxtBox = new System.Windows.Forms.TextBox();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.BirthDateDTPicker = new System.Windows.Forms.DateTimePicker();
            this.SubscribeCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitProgram
            // 
            this.ExitProgram.Location = new System.Drawing.Point(692, 389);
            this.ExitProgram.Name = "ExitProgram";
            this.ExitProgram.Size = new System.Drawing.Size(109, 60);
            this.ExitProgram.TabIndex = 1;
            this.ExitProgram.Text = "Exit Program";
            this.ExitProgram.UseVisualStyleBackColor = true;
            this.ExitProgram.Click += new System.EventHandler(this.ExitProgram_Click);
            // 
            // MainFormBtn
            // 
            this.MainFormBtn.Location = new System.Drawing.Point(1, 389);
            this.MainFormBtn.Name = "MainFormBtn";
            this.MainFormBtn.Size = new System.Drawing.Size(109, 60);
            this.MainFormBtn.TabIndex = 2;
            this.MainFormBtn.Text = "Main Form";
            this.MainFormBtn.UseVisualStyleBackColor = true;
            this.MainFormBtn.Click += new System.EventHandler(this.MainFormBtn_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FirstNameLabel.Location = new System.Drawing.Point(0, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(106, 25);
            this.FirstNameLabel.TabIndex = 3;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LastNameLabel.Location = new System.Drawing.Point(397, 3);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(106, 25);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Location = new System.Drawing.Point(112, 3);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(206, 22);
            this.FirstNameTxtBox.TabIndex = 5;
            this.FirstNameTxtBox.TextChanged += new System.EventHandler(this.FirstNameTxtBox_TextChanged);
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.Location = new System.Drawing.Point(509, 4);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(206, 22);
            this.LastNameTxtBox.TabIndex = 6;
            this.LastNameTxtBox.TextChanged += new System.EventHandler(this.LastNameTxtBox_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.EmailLabel.Location = new System.Drawing.Point(12, 59);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(60, 25);
            this.EmailLabel.TabIndex = 7;
            this.EmailLabel.Text = "Email";
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Location = new System.Drawing.Point(112, 62);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(206, 22);
            this.EmailTxtBox.TabIndex = 8;
            this.EmailTxtBox.TextChanged += new System.EventHandler(this.EmailTxtBox_TextChanged);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PhoneLabel.Location = new System.Drawing.Point(397, 62);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(69, 25);
            this.PhoneLabel.TabIndex = 9;
            this.PhoneLabel.Text = "Phone";
            // 
            // PhoneTxtBox
            // 
            this.PhoneTxtBox.Location = new System.Drawing.Point(509, 66);
            this.PhoneTxtBox.Name = "PhoneTxtBox";
            this.PhoneTxtBox.Size = new System.Drawing.Size(206, 22);
            this.PhoneTxtBox.TabIndex = 10;
            this.PhoneTxtBox.TextChanged += new System.EventHandler(this.PhoneTxtBox_TextChanged);
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BirthDateLabel.Location = new System.Drawing.Point(0, 133);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(97, 25);
            this.BirthDateLabel.TabIndex = 11;
            this.BirthDateLabel.Text = "Birth Date";
            // 
            // BirthDateDTPicker
            // 
            this.BirthDateDTPicker.Location = new System.Drawing.Point(102, 136);
            this.BirthDateDTPicker.Name = "BirthDateDTPicker";
            this.BirthDateDTPicker.Size = new System.Drawing.Size(206, 22);
            this.BirthDateDTPicker.TabIndex = 12;
            this.BirthDateDTPicker.ValueChanged += new System.EventHandler(this.BirthDateDTPicker_ValueChanged);
            // 
            // SubscribeCheckBox
            // 
            this.SubscribeCheckBox.AutoSize = true;
            this.SubscribeCheckBox.Location = new System.Drawing.Point(102, 207);
            this.SubscribeCheckBox.Name = "SubscribeCheckBox";
            this.SubscribeCheckBox.Size = new System.Drawing.Size(184, 21);
            this.SubscribeCheckBox.TabIndex = 13;
            this.SubscribeCheckBox.Text = "Subscribe To Newsletter";
            this.SubscribeCheckBox.UseVisualStyleBackColor = true;
            this.SubscribeCheckBox.CheckedChanged += new System.EventHandler(this.SubscribeCheckBox_CheckedChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(345, 283);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(109, 60);
            this.SaveBtn.TabIndex = 14;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.SubscribeCheckBox);
            this.Controls.Add(this.BirthDateDTPicker);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.PhoneTxtBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LastNameTxtBox);
            this.Controls.Add(this.FirstNameTxtBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.MainFormBtn);
            this.Controls.Add(this.ExitProgram);
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitProgram;
        private System.Windows.Forms.Button MainFormBtn;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.TextBox LastNameTxtBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox PhoneTxtBox;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.DateTimePicker BirthDateDTPicker;
        private System.Windows.Forms.CheckBox SubscribeCheckBox;
        private System.Windows.Forms.Button SaveBtn;
    }
}