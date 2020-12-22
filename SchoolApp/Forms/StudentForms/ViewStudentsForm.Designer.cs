
namespace SchoolApp.Forms
{
    partial class ViewStudentsForm
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
            this.MainFormBtn = new System.Windows.Forms.Button();
            this.ExitProgram = new System.Windows.Forms.Button();
            this.StudentsTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isSubscribedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EnrollBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.ViewAllBtn = new System.Windows.Forms.Button();
            this.ByLastName = new System.Windows.Forms.CheckBox();
            this.ByEmail = new System.Windows.Forms.CheckBox();
            this.ByPhone = new System.Windows.Forms.CheckBox();
            this.NumberOfStudentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainFormBtn
            // 
            this.MainFormBtn.Location = new System.Drawing.Point(2, 427);
            this.MainFormBtn.Name = "MainFormBtn";
            this.MainFormBtn.Size = new System.Drawing.Size(109, 60);
            this.MainFormBtn.TabIndex = 3;
            this.MainFormBtn.Text = "Main Form";
            this.MainFormBtn.UseVisualStyleBackColor = true;
            this.MainFormBtn.Click += new System.EventHandler(this.MainFormBtn_Click);
            // 
            // ExitProgram
            // 
            this.ExitProgram.Location = new System.Drawing.Point(1371, 427);
            this.ExitProgram.Name = "ExitProgram";
            this.ExitProgram.Size = new System.Drawing.Size(109, 60);
            this.ExitProgram.TabIndex = 4;
            this.ExitProgram.Text = "Exit Program";
            this.ExitProgram.UseVisualStyleBackColor = true;
            this.ExitProgram.Click += new System.EventHandler(this.ExitProgram_Click);
            // 
            // StudentsTable
            // 
            this.StudentsTable.AutoGenerateColumns = false;
            this.StudentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.isSubscribedDataGridViewCheckBoxColumn,
            this.EnrollBtn,
            this.EditBtn,
            this.DeleteBtn});
            this.StudentsTable.DataSource = this.studentBindingSource;
            this.StudentsTable.Location = new System.Drawing.Point(2, 38);
            this.StudentsTable.Name = "StudentsTable";
            this.StudentsTable.RowHeadersWidth = 51;
            this.StudentsTable.RowTemplate.Height = 24;
            this.StudentsTable.Size = new System.Drawing.Size(1478, 383);
            this.StudentsTable.TabIndex = 5;
            this.StudentsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsTable_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // isSubscribedDataGridViewCheckBoxColumn
            // 
            this.isSubscribedDataGridViewCheckBoxColumn.DataPropertyName = "IsSubscribed";
            this.isSubscribedDataGridViewCheckBoxColumn.HeaderText = "IsSubscribed";
            this.isSubscribedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isSubscribedDataGridViewCheckBoxColumn.Name = "isSubscribedDataGridViewCheckBoxColumn";
            this.isSubscribedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isSubscribedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // EnrollBtn
            // 
            this.EnrollBtn.HeaderText = "";
            this.EnrollBtn.MinimumWidth = 6;
            this.EnrollBtn.Name = "EnrollBtn";
            this.EnrollBtn.Text = "Enroll";
            this.EnrollBtn.UseColumnTextForButtonValue = true;
            this.EnrollBtn.Width = 125;
            // 
            // EditBtn
            // 
            this.EditBtn.HeaderText = "";
            this.EditBtn.MinimumWidth = 6;
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseColumnTextForButtonValue = true;
            this.EditBtn.Width = 125;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.DataPropertyName = "ID";
            this.DeleteBtn.HeaderText = "";
            this.DeleteBtn.MinimumWidth = 6;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.ReadOnly = true;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseColumnTextForButtonValue = true;
            this.DeleteBtn.Width = 125;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(SchoolApp.Models.Student);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(2, 4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 28);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(96, 7);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(147, 22);
            this.SearchTxtBox.TabIndex = 7;
            this.SearchTxtBox.TextChanged += new System.EventHandler(this.SearchTxtBox_TextChanged);
            // 
            // ViewAllBtn
            // 
            this.ViewAllBtn.Location = new System.Drawing.Point(673, 427);
            this.ViewAllBtn.Name = "ViewAllBtn";
            this.ViewAllBtn.Size = new System.Drawing.Size(109, 60);
            this.ViewAllBtn.TabIndex = 8;
            this.ViewAllBtn.Text = "View All Students";
            this.ViewAllBtn.UseVisualStyleBackColor = true;
            this.ViewAllBtn.Click += new System.EventHandler(this.ViewAllBtn_Click);
            // 
            // ByLastName
            // 
            this.ByLastName.AutoSize = true;
            this.ByLastName.Location = new System.Drawing.Point(282, 8);
            this.ByLastName.Name = "ByLastName";
            this.ByLastName.Size = new System.Drawing.Size(167, 21);
            this.ByLastName.TabIndex = 12;
            this.ByLastName.Text = "Search By Last Name";
            this.ByLastName.UseVisualStyleBackColor = true;
            this.ByLastName.CheckedChanged += new System.EventHandler(this.ByLastName_CheckedChanged);
            // 
            // ByEmail
            // 
            this.ByEmail.AutoSize = true;
            this.ByEmail.Location = new System.Drawing.Point(490, 8);
            this.ByEmail.Name = "ByEmail";
            this.ByEmail.Size = new System.Drawing.Size(133, 21);
            this.ByEmail.TabIndex = 13;
            this.ByEmail.Text = "Search By Email";
            this.ByEmail.UseVisualStyleBackColor = true;
            this.ByEmail.CheckedChanged += new System.EventHandler(this.ByEmail_CheckedChanged);
            // 
            // ByPhone
            // 
            this.ByPhone.AutoSize = true;
            this.ByPhone.Location = new System.Drawing.Point(662, 9);
            this.ByPhone.Name = "ByPhone";
            this.ByPhone.Size = new System.Drawing.Size(140, 21);
            this.ByPhone.TabIndex = 14;
            this.ByPhone.Text = "Search By Phone";
            this.ByPhone.UseVisualStyleBackColor = true;
            this.ByPhone.CheckedChanged += new System.EventHandler(this.ByPhone_CheckedChanged);
            // 
            // NumberOfStudentsLabel
            // 
            this.NumberOfStudentsLabel.AutoSize = true;
            this.NumberOfStudentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NumberOfStudentsLabel.Location = new System.Drawing.Point(819, 7);
            this.NumberOfStudentsLabel.Name = "NumberOfStudentsLabel";
            this.NumberOfStudentsLabel.Size = new System.Drawing.Size(53, 20);
            this.NumberOfStudentsLabel.TabIndex = 16;
            this.NumberOfStudentsLabel.Text = "label2";
            this.NumberOfStudentsLabel.Click += new System.EventHandler(this.NumberOfStudentsLabel_Click);
            // 
            // ViewStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 499);
            this.Controls.Add(this.NumberOfStudentsLabel);
            this.Controls.Add(this.ByPhone);
            this.Controls.Add(this.ByEmail);
            this.Controls.Add(this.ByLastName);
            this.Controls.Add(this.ViewAllBtn);
            this.Controls.Add(this.SearchTxtBox);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.StudentsTable);
            this.Controls.Add(this.ExitProgram);
            this.Controls.Add(this.MainFormBtn);
            this.Name = "ViewStudentsForm";
            this.Text = "ViewStudentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainFormBtn;
        private System.Windows.Forms.Button ExitProgram;
        private System.Windows.Forms.DataGridView StudentsTable;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchTxtBox;
        private System.Windows.Forms.Button ViewAllBtn;
        private System.Windows.Forms.CheckBox ByLastName;
        private System.Windows.Forms.CheckBox ByEmail;
        private System.Windows.Forms.CheckBox ByPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSubscribedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EnrollBtn;
        private System.Windows.Forms.DataGridViewButtonColumn EditBtn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteBtn;
        private System.Windows.Forms.Label NumberOfStudentsLabel;
    }
}