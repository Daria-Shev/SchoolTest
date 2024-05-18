namespace SchoolTest.ProgramForms.Teacher
{
    partial class add_user_show
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
            System.Windows.Forms.Label class_idLabel;
            System.Windows.Forms.Label parent_emailLabel;
            System.Windows.Forms.Label student_emailLabel;
            System.Windows.Forms.Label email_addressLabel;
            System.Windows.Forms.Label nicknameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label user_account_typeLabel;
            System.Windows.Forms.Label full_nameLabel;
            this.panelStudent = new System.Windows.Forms.Panel();
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.parent_emailTextBox = new System.Windows.Forms.TextBox();
            this.student_emailTextBox = new System.Windows.Forms.TextBox();
            this.panelTeacher = new System.Windows.Forms.Panel();
            this.email_addressTextBox = new System.Windows.Forms.TextBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.full_nameTextBox = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            class_idLabel = new System.Windows.Forms.Label();
            parent_emailLabel = new System.Windows.Forms.Label();
            student_emailLabel = new System.Windows.Forms.Label();
            email_addressLabel = new System.Windows.Forms.Label();
            nicknameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            user_account_typeLabel = new System.Windows.Forms.Label();
            full_nameLabel = new System.Windows.Forms.Label();
            this.panelStudent.SuspendLayout();
            this.panelTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // class_idLabel
            // 
            class_idLabel.AutoSize = true;
            class_idLabel.Location = new System.Drawing.Point(5, 63);
            class_idLabel.Name = "class_idLabel";
            class_idLabel.Size = new System.Drawing.Size(35, 13);
            class_idLabel.TabIndex = 22;
            class_idLabel.Text = "Клас:";
            // 
            // parent_emailLabel
            // 
            parent_emailLabel.AutoSize = true;
            parent_emailLabel.Location = new System.Drawing.Point(5, 37);
            parent_emailLabel.Name = "parent_emailLabel";
            parent_emailLabel.Size = new System.Drawing.Size(83, 13);
            parent_emailLabel.TabIndex = 20;
            parent_emailLabel.Text = "Пошта батьків:";
            // 
            // student_emailLabel
            // 
            student_emailLabel.AutoSize = true;
            student_emailLabel.Location = new System.Drawing.Point(5, 11);
            student_emailLabel.Name = "student_emailLabel";
            student_emailLabel.Size = new System.Drawing.Size(70, 13);
            student_emailLabel.TabIndex = 18;
            student_emailLabel.Text = "Пошта учнів:";
            // 
            // email_addressLabel
            // 
            email_addressLabel.AutoSize = true;
            email_addressLabel.Location = new System.Drawing.Point(5, 11);
            email_addressLabel.Name = "email_addressLabel";
            email_addressLabel.Size = new System.Drawing.Size(43, 13);
            email_addressLabel.TabIndex = 13;
            email_addressLabel.Text = "Пошта:";
            // 
            // nicknameLabel
            // 
            nicknameLabel.AutoSize = true;
            nicknameLabel.Location = new System.Drawing.Point(29, 22);
            nicknameLabel.Name = "nicknameLabel";
            nicknameLabel.Size = new System.Drawing.Size(52, 13);
            nicknameLabel.TabIndex = 30;
            nicknameLabel.Text = "Нікнейм:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(29, 48);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(48, 13);
            passwordLabel.TabIndex = 32;
            passwordLabel.Text = "Пароль:";
            // 
            // user_account_typeLabel
            // 
            user_account_typeLabel.AutoSize = true;
            user_account_typeLabel.Location = new System.Drawing.Point(29, 74);
            user_account_typeLabel.Name = "user_account_typeLabel";
            user_account_typeLabel.Size = new System.Drawing.Size(95, 13);
            user_account_typeLabel.TabIndex = 34;
            user_account_typeLabel.Text = "Тип користувача:";
            // 
            // full_nameLabel
            // 
            full_nameLabel.AutoSize = true;
            full_nameLabel.Location = new System.Drawing.Point(29, 100);
            full_nameLabel.Name = "full_nameLabel";
            full_nameLabel.Size = new System.Drawing.Size(32, 13);
            full_nameLabel.TabIndex = 36;
            full_nameLabel.Text = "ФІО:";
            // 
            // panelStudent
            // 
            this.panelStudent.Controls.Add(this.comboBox_class);
            this.panelStudent.Controls.Add(class_idLabel);
            this.panelStudent.Controls.Add(this.parent_emailTextBox);
            this.panelStudent.Controls.Add(parent_emailLabel);
            this.panelStudent.Controls.Add(student_emailLabel);
            this.panelStudent.Controls.Add(this.student_emailTextBox);
            this.panelStudent.Location = new System.Drawing.Point(321, 12);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(292, 101);
            this.panelStudent.TabIndex = 26;
            // 
            // comboBox_class
            // 
            this.comboBox_class.DisplayMember = "class_name";
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Location = new System.Drawing.Point(94, 60);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(48, 21);
            this.comboBox_class.TabIndex = 26;
            this.comboBox_class.ValueMember = "class_id";
            // 
            // parent_emailTextBox
            // 
            this.parent_emailTextBox.Location = new System.Drawing.Point(94, 34);
            this.parent_emailTextBox.Name = "parent_emailTextBox";
            this.parent_emailTextBox.Size = new System.Drawing.Size(180, 20);
            this.parent_emailTextBox.TabIndex = 21;
            // 
            // student_emailTextBox
            // 
            this.student_emailTextBox.Location = new System.Drawing.Point(94, 8);
            this.student_emailTextBox.Name = "student_emailTextBox";
            this.student_emailTextBox.Size = new System.Drawing.Size(180, 20);
            this.student_emailTextBox.TabIndex = 19;
            // 
            // panelTeacher
            // 
            this.panelTeacher.Controls.Add(this.email_addressTextBox);
            this.panelTeacher.Controls.Add(email_addressLabel);
            this.panelTeacher.Location = new System.Drawing.Point(321, 12);
            this.panelTeacher.Name = "panelTeacher";
            this.panelTeacher.Size = new System.Drawing.Size(309, 42);
            this.panelTeacher.TabIndex = 27;
            // 
            // email_addressTextBox
            // 
            this.email_addressTextBox.Location = new System.Drawing.Point(54, 8);
            this.email_addressTextBox.Name = "email_addressTextBox";
            this.email_addressTextBox.Size = new System.Drawing.Size(220, 20);
            this.email_addressTextBox.TabIndex = 14;
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Location = new System.Drawing.Point(130, 71);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(185, 21);
            this.comboBox_type.TabIndex = 38;
            this.comboBox_type.TextChanged += new System.EventHandler(this.comboBox_type_TextChanged);
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Location = new System.Drawing.Point(130, 19);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(185, 20);
            this.nicknameTextBox.TabIndex = 31;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(130, 45);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(185, 20);
            this.passwordTextBox.TabIndex = 33;
            // 
            // full_nameTextBox
            // 
            this.full_nameTextBox.Location = new System.Drawing.Point(130, 98);
            this.full_nameTextBox.Multiline = true;
            this.full_nameTextBox.Name = "full_nameTextBox";
            this.full_nameTextBox.Size = new System.Drawing.Size(185, 21);
            this.full_nameTextBox.TabIndex = 37;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Location = new System.Drawing.Point(312, 129);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 40;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(207, 130);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 39;
            this.buttonAdd.Text = "Зберегти";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // add_user_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(616, 164);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(nicknameLabel);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(user_account_typeLabel);
            this.Controls.Add(this.panelTeacher);
            this.Controls.Add(full_nameLabel);
            this.Controls.Add(this.full_nameTextBox);
            this.Controls.Add(this.panelStudent);
            this.Name = "add_user_show";
            this.Text = "Додавання користувачів";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.add_user_show_FormClosed);
            this.Load += new System.EventHandler(this.add_user_show_Load);
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            this.panelTeacher.ResumeLayout(false);
            this.panelTeacher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.ComboBox comboBox_class;
        private System.Windows.Forms.TextBox parent_emailTextBox;
        private System.Windows.Forms.TextBox student_emailTextBox;
        private System.Windows.Forms.Panel panelTeacher;
        private System.Windows.Forms.TextBox email_addressTextBox;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox full_nameTextBox;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
    }
}