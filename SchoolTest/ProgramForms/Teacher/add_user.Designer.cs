namespace SchoolTest.ProgramForms.Teacher
{
    partial class add_user
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
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView_teacher = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTeacher = new System.Windows.Forms.TabPage();
            this.tabPageStudent = new System.Windows.Forms.TabPage();
            this.dataGridView_student = new System.Windows.Forms.DataGridView();
            this.user_account_id_teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nickname_teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password_teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_account_type_teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name_teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_address_teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_account_id_student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nickname_student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password_student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_account_type_student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name_student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_email_student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parent_email_student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_name_student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_teacher)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageTeacher.SuspendLayout();
            this.tabPageStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(760, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Фільтрація:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(806, 73);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(114, 21);
            this.comboBox2.TabIndex = 38;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(673, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Вибрати лише";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(778, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Дані:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(248)))), ((int)(((byte)(206)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(721, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 26);
            this.button1.TabIndex = 35;
            this.button1.Text = "Відміна";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(763, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 34;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(713, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Шукати";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(806, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(673, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Фільтрувати по колонці";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(248)))), ((int)(((byte)(206)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Location = new System.Drawing.Point(721, 296);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(150, 26);
            this.buttonBack.TabIndex = 30;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Location = new System.Drawing.Point(721, 233);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 26);
            this.buttonDelete.TabIndex = 29;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(252)))), ((int)(((byte)(208)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(721, 201);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 26);
            this.buttonAdd.TabIndex = 28;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // dataGridView_teacher
            // 
            this.dataGridView_teacher.AllowUserToAddRows = false;
            this.dataGridView_teacher.AllowUserToDeleteRows = false;
            this.dataGridView_teacher.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_teacher.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_teacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_teacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_account_id_teacher,
            this.nickname_teacher,
            this.password_teacher,
            this.user_account_type_teacher,
            this.full_name_teacher,
            this.email_address_teacher});
            this.dataGridView_teacher.Location = new System.Drawing.Point(6, 6);
            this.dataGridView_teacher.Name = "dataGridView_teacher";
            this.dataGridView_teacher.ReadOnly = true;
            this.dataGridView_teacher.Size = new System.Drawing.Size(627, 282);
            this.dataGridView_teacher.TabIndex = 27;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTeacher);
            this.tabControl1.Controls.Add(this.tabPageStudent);
            this.tabControl1.Location = new System.Drawing.Point(4, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(663, 320);
            this.tabControl1.TabIndex = 40;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageTeacher
            // 
            this.tabPageTeacher.Controls.Add(this.dataGridView_teacher);
            this.tabPageTeacher.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeacher.Name = "tabPageTeacher";
            this.tabPageTeacher.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeacher.Size = new System.Drawing.Size(655, 294);
            this.tabPageTeacher.TabIndex = 0;
            this.tabPageTeacher.Text = "Вчитель";
            this.tabPageTeacher.UseVisualStyleBackColor = true;
            // 
            // tabPageStudent
            // 
            this.tabPageStudent.Controls.Add(this.dataGridView_student);
            this.tabPageStudent.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudent.Name = "tabPageStudent";
            this.tabPageStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudent.Size = new System.Drawing.Size(655, 294);
            this.tabPageStudent.TabIndex = 1;
            this.tabPageStudent.Text = "Учень";
            this.tabPageStudent.UseVisualStyleBackColor = true;
            // 
            // dataGridView_student
            // 
            this.dataGridView_student.AllowUserToAddRows = false;
            this.dataGridView_student.AllowUserToDeleteRows = false;
            this.dataGridView_student.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_student.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_account_id_student,
            this.nickname_student,
            this.password_student,
            this.user_account_type_student,
            this.full_name_student,
            this.student_email_student,
            this.parent_email_student,
            this.class_id,
            this.class_name_student});
            this.dataGridView_student.Location = new System.Drawing.Point(3, 6);
            this.dataGridView_student.Name = "dataGridView_student";
            this.dataGridView_student.ReadOnly = true;
            this.dataGridView_student.Size = new System.Drawing.Size(646, 282);
            this.dataGridView_student.TabIndex = 28;
            // 
            // user_account_id_teacher
            // 
            this.user_account_id_teacher.DataPropertyName = "user_account_id";
            this.user_account_id_teacher.HeaderText = "user_account_id";
            this.user_account_id_teacher.Name = "user_account_id_teacher";
            this.user_account_id_teacher.ReadOnly = true;
            this.user_account_id_teacher.Visible = false;
            // 
            // nickname_teacher
            // 
            this.nickname_teacher.DataPropertyName = "nickname";
            this.nickname_teacher.HeaderText = "Нікнейм";
            this.nickname_teacher.Name = "nickname_teacher";
            this.nickname_teacher.ReadOnly = true;
            // 
            // password_teacher
            // 
            this.password_teacher.DataPropertyName = "password";
            this.password_teacher.HeaderText = "Пароль";
            this.password_teacher.Name = "password_teacher";
            this.password_teacher.ReadOnly = true;
            // 
            // user_account_type_teacher
            // 
            this.user_account_type_teacher.DataPropertyName = "user_account_type";
            this.user_account_type_teacher.HeaderText = "user_account_type";
            this.user_account_type_teacher.Name = "user_account_type_teacher";
            this.user_account_type_teacher.ReadOnly = true;
            this.user_account_type_teacher.Visible = false;
            // 
            // full_name_teacher
            // 
            this.full_name_teacher.DataPropertyName = "full_name";
            this.full_name_teacher.HeaderText = "ФІО";
            this.full_name_teacher.Name = "full_name_teacher";
            this.full_name_teacher.ReadOnly = true;
            this.full_name_teacher.Width = 200;
            // 
            // email_address_teacher
            // 
            this.email_address_teacher.DataPropertyName = "email_address";
            this.email_address_teacher.HeaderText = "Пошта";
            this.email_address_teacher.Name = "email_address_teacher";
            this.email_address_teacher.ReadOnly = true;
            this.email_address_teacher.Width = 150;
            // 
            // user_account_id_student
            // 
            this.user_account_id_student.DataPropertyName = "user_account_id";
            this.user_account_id_student.HeaderText = "user_account_id";
            this.user_account_id_student.Name = "user_account_id_student";
            this.user_account_id_student.ReadOnly = true;
            this.user_account_id_student.Visible = false;
            // 
            // nickname_student
            // 
            this.nickname_student.DataPropertyName = "nickname";
            this.nickname_student.HeaderText = "Нікнейм";
            this.nickname_student.Name = "nickname_student";
            this.nickname_student.ReadOnly = true;
            // 
            // password_student
            // 
            this.password_student.DataPropertyName = "password";
            this.password_student.HeaderText = "Пароль";
            this.password_student.Name = "password_student";
            this.password_student.ReadOnly = true;
            // 
            // user_account_type_student
            // 
            this.user_account_type_student.DataPropertyName = "user_account_type";
            this.user_account_type_student.HeaderText = "user_account_type";
            this.user_account_type_student.Name = "user_account_type_student";
            this.user_account_type_student.ReadOnly = true;
            this.user_account_type_student.Visible = false;
            // 
            // full_name_student
            // 
            this.full_name_student.DataPropertyName = "full_name";
            this.full_name_student.HeaderText = "ФІО";
            this.full_name_student.Name = "full_name_student";
            this.full_name_student.ReadOnly = true;
            this.full_name_student.Width = 150;
            // 
            // student_email_student
            // 
            this.student_email_student.DataPropertyName = "student_email";
            this.student_email_student.HeaderText = "Пошта учня";
            this.student_email_student.Name = "student_email_student";
            this.student_email_student.ReadOnly = true;
            // 
            // parent_email_student
            // 
            this.parent_email_student.DataPropertyName = "parent_email";
            this.parent_email_student.HeaderText = "Пошта батьків";
            this.parent_email_student.Name = "parent_email_student";
            this.parent_email_student.ReadOnly = true;
            // 
            // class_id
            // 
            this.class_id.DataPropertyName = "class_id";
            this.class_id.HeaderText = "class_id";
            this.class_id.Name = "class_id";
            this.class_id.ReadOnly = true;
            this.class_id.Visible = false;
            // 
            // class_name_student
            // 
            this.class_name_student.DataPropertyName = "class_name";
            this.class_name_student.HeaderText = "Клас";
            this.class_name_student.Name = "class_name_student";
            this.class_name_student.ReadOnly = true;
            this.class_name_student.Width = 36;
            // 
            // add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 343);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Name = "add_user";
            this.Text = "add_teacher";
            this.Load += new System.EventHandler(this.add_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_teacher)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageTeacher.ResumeLayout(false);
            this.tabPageStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView_teacher;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTeacher;
        private System.Windows.Forms.TabPage tabPageStudent;
        private System.Windows.Forms.DataGridView dataGridView_student;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_account_id_teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickname_teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn password_teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_account_type_teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name_teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_address_teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_account_id_student;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickname_student;
        private System.Windows.Forms.DataGridViewTextBoxColumn password_student;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_account_type_student;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name_student;
        private System.Windows.Forms.DataGridViewTextBoxColumn student_email_student;
        private System.Windows.Forms.DataGridViewTextBoxColumn parent_email_student;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_name_student;
    }
}