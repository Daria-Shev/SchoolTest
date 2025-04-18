﻿namespace SchoolTest.ProgramForms.Teacher
{
    partial class add_test
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.test_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theme_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_account_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.execution_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theme_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attempt_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.question_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creation_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1015, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "Фільтрація:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1061, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(114, 21);
            this.comboBox2.TabIndex = 90;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(928, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Вибрати лише";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1033, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 88;
            this.label5.Text = "Дані:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(248)))), ((int)(((byte)(206)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(976, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 26);
            this.button1.TabIndex = 87;
            this.button1.Text = "Відміна";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1018, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 86;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(968, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Шукати";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1061, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 84;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(928, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Фільтрувати по колонці";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(248)))), ((int)(((byte)(206)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Location = new System.Drawing.Point(976, 265);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(150, 26);
            this.buttonBack.TabIndex = 82;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Location = new System.Drawing.Point(976, 218);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 26);
            this.buttonDelete.TabIndex = 81;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(252)))), ((int)(((byte)(208)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(976, 186);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 26);
            this.buttonAdd.TabIndex = 80;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.test_id,
            this.theme_id,
            this.subject_id,
            this.class_id,
            this.user_account_id,
            this.test_name,
            this.execution_time,
            this.theme_name,
            this.subject_name,
            this.class_name,
            this.attempt_count,
            this.question_count,
            this.test_type,
            this.full_name,
            this.creation_date});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(909, 288);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // test_id
            // 
            this.test_id.DataPropertyName = "test_id";
            this.test_id.HeaderText = "test_id";
            this.test_id.Name = "test_id";
            this.test_id.ReadOnly = true;
            this.test_id.Visible = false;
            // 
            // theme_id
            // 
            this.theme_id.DataPropertyName = "theme_id";
            this.theme_id.HeaderText = "theme_id";
            this.theme_id.Name = "theme_id";
            this.theme_id.ReadOnly = true;
            this.theme_id.Visible = false;
            // 
            // subject_id
            // 
            this.subject_id.DataPropertyName = "subject_id";
            this.subject_id.HeaderText = "subject_id";
            this.subject_id.Name = "subject_id";
            this.subject_id.ReadOnly = true;
            this.subject_id.Visible = false;
            // 
            // class_id
            // 
            this.class_id.DataPropertyName = "class_id";
            this.class_id.HeaderText = "class_id";
            this.class_id.Name = "class_id";
            this.class_id.ReadOnly = true;
            this.class_id.Visible = false;
            // 
            // user_account_id
            // 
            this.user_account_id.DataPropertyName = "user_account_id";
            this.user_account_id.HeaderText = "user_account_id";
            this.user_account_id.Name = "user_account_id";
            this.user_account_id.ReadOnly = true;
            this.user_account_id.Visible = false;
            // 
            // test_name
            // 
            this.test_name.DataPropertyName = "test_name";
            this.test_name.HeaderText = "Тест";
            this.test_name.Name = "test_name";
            this.test_name.ReadOnly = true;
            this.test_name.Width = 150;
            // 
            // execution_time
            // 
            this.execution_time.DataPropertyName = "execution_time";
            this.execution_time.HeaderText = "Час";
            this.execution_time.Name = "execution_time";
            this.execution_time.ReadOnly = true;
            this.execution_time.Width = 40;
            // 
            // theme_name
            // 
            this.theme_name.DataPropertyName = "theme_name";
            this.theme_name.HeaderText = "Тема";
            this.theme_name.Name = "theme_name";
            this.theme_name.ReadOnly = true;
            // 
            // subject_name
            // 
            this.subject_name.DataPropertyName = "subject_name";
            this.subject_name.HeaderText = "Предмет";
            this.subject_name.Name = "subject_name";
            this.subject_name.ReadOnly = true;
            // 
            // class_name
            // 
            this.class_name.DataPropertyName = "class_name";
            this.class_name.HeaderText = "Клас";
            this.class_name.Name = "class_name";
            this.class_name.ReadOnly = true;
            this.class_name.Width = 40;
            // 
            // attempt_count
            // 
            this.attempt_count.DataPropertyName = "attempt_count";
            this.attempt_count.HeaderText = "Спроб";
            this.attempt_count.Name = "attempt_count";
            this.attempt_count.ReadOnly = true;
            this.attempt_count.Width = 45;
            // 
            // question_count
            // 
            this.question_count.DataPropertyName = "question_count";
            this.question_count.HeaderText = "К-сть питань";
            this.question_count.Name = "question_count";
            this.question_count.ReadOnly = true;
            // 
            // test_type
            // 
            this.test_type.DataPropertyName = "test_type";
            this.test_type.HeaderText = "Тип тесту";
            this.test_type.Name = "test_type";
            this.test_type.ReadOnly = true;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            this.full_name.HeaderText = "Створив";
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            // 
            // creation_date
            // 
            this.creation_date.DataPropertyName = "creation_date";
            this.creation_date.HeaderText = "Дата створення";
            this.creation_date.Name = "creation_date";
            this.creation_date.ReadOnly = true;
            this.creation_date.Width = 70;
            // 
            // add_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1180, 316);
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "add_test";
            this.Text = "Тести";
            this.Load += new System.EventHandler(this.add_test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn theme_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_account_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn execution_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn theme_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn attempt_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn question_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn creation_date;
    }
}