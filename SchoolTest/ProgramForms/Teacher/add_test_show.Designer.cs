namespace SchoolTest.ProgramForms.Teacher
{
    partial class add_test_show
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
            System.Windows.Forms.Label test_nameLabel;
            System.Windows.Forms.Label execution_timeLabel;
            System.Windows.Forms.Label attempt_countLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label subject_idLabel;
            System.Windows.Forms.Label label3;
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.test_nameTextBox = new System.Windows.Forms.TextBox();
            this.execution_timeTextBox = new System.Windows.Forms.TextBox();
            this.attempt_countTextBox = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.comboBox_theme = new System.Windows.Forms.ComboBox();
            this.comboBox_subject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_question_count = new System.Windows.Forms.TextBox();
            class_idLabel = new System.Windows.Forms.Label();
            test_nameLabel = new System.Windows.Forms.Label();
            execution_timeLabel = new System.Windows.Forms.Label();
            attempt_countLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            subject_idLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // class_idLabel
            // 
            class_idLabel.AutoSize = true;
            class_idLabel.Location = new System.Drawing.Point(215, 83);
            class_idLabel.Name = "class_idLabel";
            class_idLabel.Size = new System.Drawing.Size(35, 13);
            class_idLabel.TabIndex = 22;
            class_idLabel.Text = "Клас:";
            // 
            // test_nameLabel
            // 
            test_nameLabel.AutoSize = true;
            test_nameLabel.Location = new System.Drawing.Point(4, 27);
            test_nameLabel.Name = "test_nameLabel";
            test_nameLabel.Size = new System.Drawing.Size(34, 13);
            test_nameLabel.TabIndex = 23;
            test_nameLabel.Text = "Тест:";
            // 
            // execution_timeLabel
            // 
            execution_timeLabel.AutoSize = true;
            execution_timeLabel.Location = new System.Drawing.Point(4, 75);
            execution_timeLabel.Name = "execution_timeLabel";
            execution_timeLabel.Size = new System.Drawing.Size(94, 26);
            execution_timeLabel.TabIndex = 28;
            execution_timeLabel.Text = "Час\r\nпроходження(хв):";
            // 
            // attempt_countLabel
            // 
            attempt_countLabel.AutoSize = true;
            attempt_countLabel.Location = new System.Drawing.Point(215, 113);
            attempt_countLabel.Name = "attempt_countLabel";
            attempt_countLabel.Size = new System.Drawing.Size(41, 13);
            attempt_countLabel.TabIndex = 30;
            attempt_countLabel.Text = "Спроб:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 52);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 13);
            label1.TabIndex = 38;
            label1.Text = "Тип тесту:";
            // 
            // subject_idLabel
            // 
            subject_idLabel.AutoSize = true;
            subject_idLabel.Location = new System.Drawing.Point(4, 137);
            subject_idLabel.Name = "subject_idLabel";
            subject_idLabel.Size = new System.Drawing.Size(55, 13);
            subject_idLabel.TabIndex = 40;
            subject_idLabel.Text = "Предмет:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(4, 110);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 13);
            label3.TabIndex = 45;
            label3.Text = "Кількість питань:";
            // 
            // comboBox_class
            // 
            this.comboBox_class.DisplayMember = "class_name";
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Location = new System.Drawing.Point(262, 81);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(97, 21);
            this.comboBox_class.TabIndex = 35;
            this.comboBox_class.ValueMember = "class_id";
            // 
            // test_nameTextBox
            // 
            this.test_nameTextBox.Location = new System.Drawing.Point(104, 24);
            this.test_nameTextBox.Name = "test_nameTextBox";
            this.test_nameTextBox.Size = new System.Drawing.Size(255, 20);
            this.test_nameTextBox.TabIndex = 24;
            // 
            // execution_timeTextBox
            // 
            this.execution_timeTextBox.Location = new System.Drawing.Point(104, 81);
            this.execution_timeTextBox.Name = "execution_timeTextBox";
            this.execution_timeTextBox.Size = new System.Drawing.Size(97, 20);
            this.execution_timeTextBox.TabIndex = 29;
            // 
            // attempt_countTextBox
            // 
            this.attempt_countTextBox.Location = new System.Drawing.Point(262, 110);
            this.attempt_countTextBox.Name = "attempt_countTextBox";
            this.attempt_countTextBox.Size = new System.Drawing.Size(97, 20);
            this.attempt_countTextBox.TabIndex = 31;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Location = new System.Drawing.Point(192, 199);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 37;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(80, 199);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 36;
            this.buttonAdd.Text = "Зберегти";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBox_type
            // 
            this.comboBox_type.DisplayMember = "theme_name";
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "Підготовчий",
            "Оцінювальний"});
            this.comboBox_type.Location = new System.Drawing.Point(104, 49);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(255, 21);
            this.comboBox_type.TabIndex = 39;
            this.comboBox_type.ValueMember = "theme_id";
            this.comboBox_type.TextChanged += new System.EventHandler(this.comboBox_type_TextChanged);
            // 
            // comboBox_theme
            // 
            this.comboBox_theme.DisplayMember = "theme_name";
            this.comboBox_theme.FormattingEnabled = true;
            this.comboBox_theme.Location = new System.Drawing.Point(104, 161);
            this.comboBox_theme.Name = "comboBox_theme";
            this.comboBox_theme.Size = new System.Drawing.Size(255, 21);
            this.comboBox_theme.TabIndex = 43;
            this.comboBox_theme.ValueMember = "theme_id";
            // 
            // comboBox_subject
            // 
            this.comboBox_subject.DisplayMember = "subject_name";
            this.comboBox_subject.FormattingEnabled = true;
            this.comboBox_subject.Location = new System.Drawing.Point(104, 134);
            this.comboBox_subject.Name = "comboBox_subject";
            this.comboBox_subject.Size = new System.Drawing.Size(255, 21);
            this.comboBox_subject.TabIndex = 41;
            this.comboBox_subject.ValueMember = "subject_id";
            this.comboBox_subject.TextChanged += new System.EventHandler(this.comboBox_subject_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Тема:";
            // 
            // textBox_question_count
            // 
            this.textBox_question_count.Location = new System.Drawing.Point(104, 107);
            this.textBox_question_count.Name = "textBox_question_count";
            this.textBox_question_count.Size = new System.Drawing.Size(97, 20);
            this.textBox_question_count.TabIndex = 46;
            // 
            // add_test_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(382, 234);
            this.Controls.Add(label3);
            this.Controls.Add(this.textBox_question_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_theme);
            this.Controls.Add(this.comboBox_subject);
            this.Controls.Add(subject_idLabel);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBox_class);
            this.Controls.Add(class_idLabel);
            this.Controls.Add(test_nameLabel);
            this.Controls.Add(this.test_nameTextBox);
            this.Controls.Add(execution_timeLabel);
            this.Controls.Add(this.execution_timeTextBox);
            this.Controls.Add(attempt_countLabel);
            this.Controls.Add(this.attempt_countTextBox);
            this.Name = "add_test_show";
            this.Text = "Додавання тестів";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.add_test_show_FormClosed);
            this.Load += new System.EventHandler(this.add_test_show_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_class;
        private System.Windows.Forms.TextBox test_nameTextBox;
        private System.Windows.Forms.TextBox execution_timeTextBox;
        private System.Windows.Forms.TextBox attempt_countTextBox;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.ComboBox comboBox_theme;
        private System.Windows.Forms.ComboBox comboBox_subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_question_count;
    }
}