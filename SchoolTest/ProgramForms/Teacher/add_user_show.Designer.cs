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
            System.Windows.Forms.Label user_account_idLabel2;
            System.Windows.Forms.Label parent_emailLabel;
            System.Windows.Forms.Label student_emailLabel;
            System.Windows.Forms.Label email_addressLabel;
            System.Windows.Forms.Label user_account_idLabel1;
            System.Windows.Forms.Label nicknameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label user_account_typeLabel;
            System.Windows.Forms.Label full_nameLabel;
            System.Windows.Forms.Label user_account_idLabel;
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.class_idTextBox = new System.Windows.Forms.TextBox();
            this.parent_emailTextBox = new System.Windows.Forms.TextBox();
            this.user_account_idTextBox2 = new System.Windows.Forms.TextBox();
            this.student_emailTextBox = new System.Windows.Forms.TextBox();
            this.panelTeacher = new System.Windows.Forms.Panel();
            this.email_addressTextBox = new System.Windows.Forms.TextBox();
            this.user_account_idTextBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.user_account_typeTextBox = new System.Windows.Forms.TextBox();
            this.full_nameTextBox = new System.Windows.Forms.TextBox();
            this.user_account_idTextBox = new System.Windows.Forms.TextBox();
            class_idLabel = new System.Windows.Forms.Label();
            user_account_idLabel2 = new System.Windows.Forms.Label();
            parent_emailLabel = new System.Windows.Forms.Label();
            student_emailLabel = new System.Windows.Forms.Label();
            email_addressLabel = new System.Windows.Forms.Label();
            user_account_idLabel1 = new System.Windows.Forms.Label();
            nicknameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            user_account_typeLabel = new System.Windows.Forms.Label();
            full_nameLabel = new System.Windows.Forms.Label();
            user_account_idLabel = new System.Windows.Forms.Label();
            this.panelStudent.SuspendLayout();
            this.panelTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(177, 196);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 23;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(84, 196);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Зберегти";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // panelStudent
            // 
            this.panelStudent.Controls.Add(this.comboBox2);
            this.panelStudent.Controls.Add(this.class_idTextBox);
            this.panelStudent.Controls.Add(class_idLabel);
            this.panelStudent.Controls.Add(user_account_idLabel2);
            this.panelStudent.Controls.Add(this.parent_emailTextBox);
            this.panelStudent.Controls.Add(this.user_account_idTextBox2);
            this.panelStudent.Controls.Add(parent_emailLabel);
            this.panelStudent.Controls.Add(student_emailLabel);
            this.panelStudent.Controls.Add(this.student_emailTextBox);
            this.panelStudent.Location = new System.Drawing.Point(367, 224);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(334, 167);
            this.panelStudent.TabIndex = 26;
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "class_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(94, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.ValueMember = "class_id";
            // 
            // class_idTextBox
            // 
            this.class_idTextBox.Location = new System.Drawing.Point(94, 86);
            this.class_idTextBox.Name = "class_idTextBox";
            this.class_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.class_idTextBox.TabIndex = 23;
            this.class_idTextBox.Visible = false;
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
            // user_account_idLabel2
            // 
            user_account_idLabel2.AutoSize = true;
            user_account_idLabel2.Location = new System.Drawing.Point(5, 126);
            user_account_idLabel2.Name = "user_account_idLabel2";
            user_account_idLabel2.Size = new System.Drawing.Size(83, 13);
            user_account_idLabel2.TabIndex = 16;
            user_account_idLabel2.Text = "user account id:";
            user_account_idLabel2.Visible = false;
            // 
            // parent_emailTextBox
            // 
            this.parent_emailTextBox.Location = new System.Drawing.Point(94, 34);
            this.parent_emailTextBox.Name = "parent_emailTextBox";
            this.parent_emailTextBox.Size = new System.Drawing.Size(229, 20);
            this.parent_emailTextBox.TabIndex = 21;
            // 
            // user_account_idTextBox2
            // 
            this.user_account_idTextBox2.Location = new System.Drawing.Point(94, 123);
            this.user_account_idTextBox2.Name = "user_account_idTextBox2";
            this.user_account_idTextBox2.Size = new System.Drawing.Size(100, 20);
            this.user_account_idTextBox2.TabIndex = 17;
            this.user_account_idTextBox2.Visible = false;
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
            // student_emailTextBox
            // 
            this.student_emailTextBox.Location = new System.Drawing.Point(94, 8);
            this.student_emailTextBox.Name = "student_emailTextBox";
            this.student_emailTextBox.Size = new System.Drawing.Size(229, 20);
            this.student_emailTextBox.TabIndex = 19;
            // 
            // panelTeacher
            // 
            this.panelTeacher.Controls.Add(this.email_addressTextBox);
            this.panelTeacher.Controls.Add(email_addressLabel);
            this.panelTeacher.Controls.Add(this.user_account_idTextBox1);
            this.panelTeacher.Controls.Add(user_account_idLabel1);
            this.panelTeacher.Location = new System.Drawing.Point(311, 39);
            this.panelTeacher.Name = "panelTeacher";
            this.panelTeacher.Size = new System.Drawing.Size(326, 133);
            this.panelTeacher.TabIndex = 27;
            // 
            // email_addressTextBox
            // 
            this.email_addressTextBox.Location = new System.Drawing.Point(99, 8);
            this.email_addressTextBox.Name = "email_addressTextBox";
            this.email_addressTextBox.Size = new System.Drawing.Size(226, 20);
            this.email_addressTextBox.TabIndex = 14;
            // 
            // email_addressLabel
            // 
            email_addressLabel.AutoSize = true;
            email_addressLabel.Location = new System.Drawing.Point(2, 11);
            email_addressLabel.Name = "email_addressLabel";
            email_addressLabel.Size = new System.Drawing.Size(43, 13);
            email_addressLabel.TabIndex = 13;
            email_addressLabel.Text = "Пошта:";
            // 
            // user_account_idTextBox1
            // 
            this.user_account_idTextBox1.Location = new System.Drawing.Point(98, 30);
            this.user_account_idTextBox1.Name = "user_account_idTextBox1";
            this.user_account_idTextBox1.Size = new System.Drawing.Size(102, 20);
            this.user_account_idTextBox1.TabIndex = 12;
            this.user_account_idTextBox1.Visible = false;
            // 
            // user_account_idLabel1
            // 
            user_account_idLabel1.AutoSize = true;
            user_account_idLabel1.Location = new System.Drawing.Point(9, 33);
            user_account_idLabel1.Name = "user_account_idLabel1";
            user_account_idLabel1.Size = new System.Drawing.Size(83, 13);
            user_account_idLabel1.TabIndex = 11;
            user_account_idLabel1.Text = "user account id:";
            user_account_idLabel1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Учень",
            "Вчитель"});
            this.comboBox1.Location = new System.Drawing.Point(141, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 38;
            this.comboBox1.Text = "Учень";
            // 
            // nicknameLabel
            // 
            nicknameLabel.AutoSize = true;
            nicknameLabel.Location = new System.Drawing.Point(40, 95);
            nicknameLabel.Name = "nicknameLabel";
            nicknameLabel.Size = new System.Drawing.Size(52, 13);
            nicknameLabel.TabIndex = 30;
            nicknameLabel.Text = "Нікнейм:";
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Location = new System.Drawing.Point(141, 92);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nicknameTextBox.TabIndex = 31;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(40, 121);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(48, 13);
            passwordLabel.TabIndex = 32;
            passwordLabel.Text = "Пароль:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(141, 118);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(121, 20);
            this.passwordTextBox.TabIndex = 33;
            // 
            // user_account_typeLabel
            // 
            user_account_typeLabel.AutoSize = true;
            user_account_typeLabel.Location = new System.Drawing.Point(40, 147);
            user_account_typeLabel.Name = "user_account_typeLabel";
            user_account_typeLabel.Size = new System.Drawing.Size(95, 13);
            user_account_typeLabel.TabIndex = 34;
            user_account_typeLabel.Text = "Тип користувача:";
            // 
            // user_account_typeTextBox
            // 
            this.user_account_typeTextBox.Location = new System.Drawing.Point(162, 144);
            this.user_account_typeTextBox.Name = "user_account_typeTextBox";
            this.user_account_typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.user_account_typeTextBox.TabIndex = 35;
            // 
            // full_nameLabel
            // 
            full_nameLabel.AutoSize = true;
            full_nameLabel.Location = new System.Drawing.Point(40, 173);
            full_nameLabel.Name = "full_nameLabel";
            full_nameLabel.Size = new System.Drawing.Size(32, 13);
            full_nameLabel.TabIndex = 36;
            full_nameLabel.Text = "ФІО:";
            // 
            // full_nameTextBox
            // 
            this.full_nameTextBox.Location = new System.Drawing.Point(141, 170);
            this.full_nameTextBox.Name = "full_nameTextBox";
            this.full_nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.full_nameTextBox.TabIndex = 37;
            // 
            // user_account_idTextBox
            // 
            this.user_account_idTextBox.Location = new System.Drawing.Point(140, 36);
            this.user_account_idTextBox.Name = "user_account_idTextBox";
            this.user_account_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.user_account_idTextBox.TabIndex = 29;
            this.user_account_idTextBox.Visible = false;
            // 
            // user_account_idLabel
            // 
            user_account_idLabel.AutoSize = true;
            user_account_idLabel.Location = new System.Drawing.Point(39, 39);
            user_account_idLabel.Name = "user_account_idLabel";
            user_account_idLabel.Size = new System.Drawing.Size(83, 13);
            user_account_idLabel.TabIndex = 28;
            user_account_idLabel.Text = "user account id:";
            user_account_idLabel.Visible = false;
            // 
            // add_user_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(user_account_idLabel);
            this.Controls.Add(this.user_account_idTextBox);
            this.Controls.Add(nicknameLabel);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(user_account_typeLabel);
            this.Controls.Add(this.user_account_typeTextBox);
            this.Controls.Add(full_nameLabel);
            this.Controls.Add(this.full_nameTextBox);
            this.Controls.Add(this.panelTeacher);
            this.Controls.Add(this.panelStudent);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Name = "add_user_show";
            this.Text = "add_user_show";
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            this.panelTeacher.ResumeLayout(false);
            this.panelTeacher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox class_idTextBox;
        private System.Windows.Forms.TextBox parent_emailTextBox;
        private System.Windows.Forms.TextBox user_account_idTextBox2;
        private System.Windows.Forms.TextBox student_emailTextBox;
        private System.Windows.Forms.Panel panelTeacher;
        private System.Windows.Forms.TextBox email_addressTextBox;
        private System.Windows.Forms.TextBox user_account_idTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox user_account_typeTextBox;
        private System.Windows.Forms.TextBox full_nameTextBox;
        private System.Windows.Forms.TextBox user_account_idTextBox;
    }
}