namespace SchoolTest.ProgramForms.Teacher
{
    partial class add_question_show
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
            System.Windows.Forms.Label theme_idLabel;
            System.Windows.Forms.Label question_textLabel;
            System.Windows.Forms.Label pointsLabel;
            System.Windows.Forms.Label response_typeLabel;
            System.Windows.Forms.Label subject_idLabel;
            this.comboBox_theme = new System.Windows.Forms.ComboBox();
            this.question_textTextBox = new System.Windows.Forms.TextBox();
            this.pointsTextBox = new System.Windows.Forms.TextBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.panel_open_response = new System.Windows.Forms.Panel();
            this.dataGridView_open_response = new System.Windows.Forms.DataGridView();
            this.panel_sequence = new System.Windows.Forms.Panel();
            this.dataGridView_sequence = new System.Windows.Forms.DataGridView();
            this.panel_matching = new System.Windows.Forms.Panel();
            this.dataGridView_matching = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matching_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option_text_m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matching_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_answer_options = new System.Windows.Forms.Panel();
            this.dataGridView_answer_options = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBox_subject = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sequence_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sequence_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.response_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.question_id_response = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correct_response = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correct_option = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            theme_idLabel = new System.Windows.Forms.Label();
            question_textLabel = new System.Windows.Forms.Label();
            pointsLabel = new System.Windows.Forms.Label();
            response_typeLabel = new System.Windows.Forms.Label();
            subject_idLabel = new System.Windows.Forms.Label();
            this.panel_open_response.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_open_response)).BeginInit();
            this.panel_sequence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sequence)).BeginInit();
            this.panel_matching.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_matching)).BeginInit();
            this.panel_answer_options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_answer_options)).BeginInit();
            this.SuspendLayout();
            // 
            // theme_idLabel
            // 
            theme_idLabel.AutoSize = true;
            theme_idLabel.Location = new System.Drawing.Point(21, 102);
            theme_idLabel.Name = "theme_idLabel";
            theme_idLabel.Size = new System.Drawing.Size(37, 13);
            theme_idLabel.TabIndex = 15;
            theme_idLabel.Text = "Тема:";
            // 
            // question_textLabel
            // 
            question_textLabel.AutoSize = true;
            question_textLabel.Location = new System.Drawing.Point(21, 18);
            question_textLabel.Name = "question_textLabel";
            question_textLabel.Size = new System.Drawing.Size(53, 13);
            question_textLabel.TabIndex = 16;
            question_textLabel.Text = "Питання:";
            // 
            // pointsLabel
            // 
            pointsLabel.AutoSize = true;
            pointsLabel.Location = new System.Drawing.Point(21, 168);
            pointsLabel.Name = "pointsLabel";
            pointsLabel.Size = new System.Drawing.Size(35, 13);
            pointsLabel.TabIndex = 18;
            pointsLabel.Text = "Бали:";
            // 
            // response_typeLabel
            // 
            response_typeLabel.AutoSize = true;
            response_typeLabel.Location = new System.Drawing.Point(21, 138);
            response_typeLabel.Name = "response_typeLabel";
            response_typeLabel.Size = new System.Drawing.Size(73, 13);
            response_typeLabel.TabIndex = 26;
            response_typeLabel.Text = "Тип питання:";
            // 
            // subject_idLabel
            // 
            subject_idLabel.AutoSize = true;
            subject_idLabel.Location = new System.Drawing.Point(21, 71);
            subject_idLabel.Name = "subject_idLabel";
            subject_idLabel.Size = new System.Drawing.Size(55, 13);
            subject_idLabel.TabIndex = 43;
            subject_idLabel.Text = "Предмет:";
            // 
            // comboBox_theme
            // 
            this.comboBox_theme.DisplayMember = "theme_name";
            this.comboBox_theme.FormattingEnabled = true;
            this.comboBox_theme.Location = new System.Drawing.Point(97, 99);
            this.comboBox_theme.Name = "comboBox_theme";
            this.comboBox_theme.Size = new System.Drawing.Size(238, 21);
            this.comboBox_theme.TabIndex = 20;
            this.comboBox_theme.ValueMember = "theme_id";
            // 
            // question_textTextBox
            // 
            this.question_textTextBox.Location = new System.Drawing.Point(97, 15);
            this.question_textTextBox.Multiline = true;
            this.question_textTextBox.Name = "question_textTextBox";
            this.question_textTextBox.Size = new System.Drawing.Size(238, 47);
            this.question_textTextBox.TabIndex = 17;
            // 
            // pointsTextBox
            // 
            this.pointsTextBox.Location = new System.Drawing.Point(97, 165);
            this.pointsTextBox.Name = "pointsTextBox";
            this.pointsTextBox.Size = new System.Drawing.Size(45, 20);
            this.pointsTextBox.TabIndex = 19;
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "Відповідність",
            "Послідовність",
            "Відкрита відповідь",
            "Варіанти відповідей"});
            this.comboBox_type.Location = new System.Drawing.Point(97, 135);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(195, 21);
            this.comboBox_type.TabIndex = 29;
            this.comboBox_type.TextChanged += new System.EventHandler(this.comboBox_type_TextChanged);
            // 
            // panel_open_response
            // 
            this.panel_open_response.Controls.Add(this.dataGridView_open_response);
            this.panel_open_response.Location = new System.Drawing.Point(379, 17);
            this.panel_open_response.Name = "panel_open_response";
            this.panel_open_response.Size = new System.Drawing.Size(583, 193);
            this.panel_open_response.TabIndex = 30;
            // 
            // dataGridView_open_response
            // 
            this.dataGridView_open_response.AllowUserToAddRows = false;
            this.dataGridView_open_response.AllowUserToDeleteRows = false;
            this.dataGridView_open_response.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_open_response.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_open_response.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_open_response.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.response_id,
            this.question_id_response,
            this.correct_response});
            this.dataGridView_open_response.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_open_response.Name = "dataGridView_open_response";
            this.dataGridView_open_response.ReadOnly = true;
            this.dataGridView_open_response.Size = new System.Drawing.Size(493, 183);
            this.dataGridView_open_response.TabIndex = 54;
            this.dataGridView_open_response.DoubleClick += new System.EventHandler(this.dataGridView_open_response_DoubleClick);
            // 
            // panel_sequence
            // 
            this.panel_sequence.Controls.Add(this.dataGridView_sequence);
            this.panel_sequence.Location = new System.Drawing.Point(379, 16);
            this.panel_sequence.Name = "panel_sequence";
            this.panel_sequence.Size = new System.Drawing.Size(723, 194);
            this.panel_sequence.TabIndex = 31;
            // 
            // dataGridView_sequence
            // 
            this.dataGridView_sequence.AllowUserToAddRows = false;
            this.dataGridView_sequence.AllowUserToDeleteRows = false;
            this.dataGridView_sequence.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_sequence.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_sequence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sequence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Column2,
            this.sequence_number,
            this.sequence_text});
            this.dataGridView_sequence.Location = new System.Drawing.Point(3, 0);
            this.dataGridView_sequence.Name = "dataGridView_sequence";
            this.dataGridView_sequence.ReadOnly = true;
            this.dataGridView_sequence.Size = new System.Drawing.Size(493, 183);
            this.dataGridView_sequence.TabIndex = 56;
            this.dataGridView_sequence.DoubleClick += new System.EventHandler(this.dataGridView_sequence_DoubleClick);
            // 
            // panel_matching
            // 
            this.panel_matching.Controls.Add(this.dataGridView_matching);
            this.panel_matching.Location = new System.Drawing.Point(379, 18);
            this.panel_matching.Name = "panel_matching";
            this.panel_matching.Size = new System.Drawing.Size(516, 193);
            this.panel_matching.TabIndex = 31;
            // 
            // dataGridView_matching
            // 
            this.dataGridView_matching.AllowUserToAddRows = false;
            this.dataGridView_matching.AllowUserToDeleteRows = false;
            this.dataGridView_matching.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_matching.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_matching.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_matching.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.matching_number,
            this.Column3,
            this.option_text_m,
            this.matching_text});
            this.dataGridView_matching.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_matching.Name = "dataGridView_matching";
            this.dataGridView_matching.ReadOnly = true;
            this.dataGridView_matching.Size = new System.Drawing.Size(493, 183);
            this.dataGridView_matching.TabIndex = 57;
            this.dataGridView_matching.DoubleClick += new System.EventHandler(this.dataGridView_matching_DoubleClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "response_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "response_id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // matching_number
            // 
            this.matching_number.DataPropertyName = "matching_number";
            this.matching_number.HeaderText = "Номер";
            this.matching_number.Name = "matching_number";
            this.matching_number.ReadOnly = true;
            this.matching_number.Width = 50;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "question_id";
            this.Column3.HeaderText = "question_id";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // option_text_m
            // 
            this.option_text_m.DataPropertyName = "option_text";
            this.option_text_m.HeaderText = "Текст варіанту";
            this.option_text_m.Name = "option_text_m";
            this.option_text_m.ReadOnly = true;
            this.option_text_m.Width = 200;
            // 
            // matching_text
            // 
            this.matching_text.DataPropertyName = "matching_text";
            this.matching_text.HeaderText = "Текст відповідності";
            this.matching_text.Name = "matching_text";
            this.matching_text.ReadOnly = true;
            this.matching_text.Width = 200;
            // 
            // panel_answer_options
            // 
            this.panel_answer_options.Controls.Add(this.dataGridView_answer_options);
            this.panel_answer_options.Location = new System.Drawing.Point(379, 19);
            this.panel_answer_options.Name = "panel_answer_options";
            this.panel_answer_options.Size = new System.Drawing.Size(592, 194);
            this.panel_answer_options.TabIndex = 31;
            // 
            // dataGridView_answer_options
            // 
            this.dataGridView_answer_options.AllowUserToAddRows = false;
            this.dataGridView_answer_options.AllowUserToDeleteRows = false;
            this.dataGridView_answer_options.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_answer_options.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_answer_options.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_answer_options.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column1,
            this.option_number,
            this.correct_option,
            this.option_text});
            this.dataGridView_answer_options.Location = new System.Drawing.Point(0, 3);
            this.dataGridView_answer_options.Name = "dataGridView_answer_options";
            this.dataGridView_answer_options.ReadOnly = true;
            this.dataGridView_answer_options.Size = new System.Drawing.Size(493, 183);
            this.dataGridView_answer_options.TabIndex = 55;
            this.dataGridView_answer_options.DoubleClick += new System.EventHandler(this.dataGridView_answer_options_DoubleClick);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Location = new System.Drawing.Point(190, 210);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 42;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(103, 210);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 41;
            this.buttonAdd.Text = "Зберегти";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // comboBox_subject
            // 
            this.comboBox_subject.DisplayMember = "subject_name";
            this.comboBox_subject.FormattingEnabled = true;
            this.comboBox_subject.Location = new System.Drawing.Point(97, 68);
            this.comboBox_subject.Name = "comboBox_subject";
            this.comboBox_subject.Size = new System.Drawing.Size(238, 21);
            this.comboBox_subject.TabIndex = 44;
            this.comboBox_subject.ValueMember = "subject_id";
            this.comboBox_subject.SelectionChangeCommitted += new System.EventHandler(this.comboBox_subject_SelectionChangeCommitted);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(557, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Додати відповідь";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "response_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "response_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "question_id";
            this.Column2.HeaderText = "question_id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // sequence_number
            // 
            this.sequence_number.DataPropertyName = "sequence_number";
            this.sequence_number.HeaderText = "Номер";
            this.sequence_number.Name = "sequence_number";
            this.sequence_number.ReadOnly = true;
            this.sequence_number.Width = 50;
            // 
            // sequence_text
            // 
            this.sequence_text.DataPropertyName = "sequence_text";
            this.sequence_text.HeaderText = "Текст послідовності";
            this.sequence_text.Name = "sequence_text";
            this.sequence_text.ReadOnly = true;
            this.sequence_text.Width = 400;
            // 
            // response_id
            // 
            this.response_id.DataPropertyName = "response_id";
            this.response_id.HeaderText = "response_id";
            this.response_id.Name = "response_id";
            this.response_id.ReadOnly = true;
            this.response_id.Visible = false;
            // 
            // question_id_response
            // 
            this.question_id_response.DataPropertyName = "question_id";
            this.question_id_response.HeaderText = "question_id";
            this.question_id_response.Name = "question_id_response";
            this.question_id_response.ReadOnly = true;
            this.question_id_response.Visible = false;
            // 
            // correct_response
            // 
            this.correct_response.DataPropertyName = "correct_response";
            this.correct_response.HeaderText = "Правильна відповідь";
            this.correct_response.Name = "correct_response";
            this.correct_response.ReadOnly = true;
            this.correct_response.Width = 450;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "response_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "response_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "question_id";
            this.Column1.HeaderText = "question_id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // option_number
            // 
            this.option_number.DataPropertyName = "option_number";
            this.option_number.HeaderText = "Номер";
            this.option_number.Name = "option_number";
            this.option_number.ReadOnly = true;
            this.option_number.Width = 50;
            // 
            // correct_option
            // 
            this.correct_option.DataPropertyName = "correct_option";
            this.correct_option.HeaderText = "Правильний варіант";
            this.correct_option.Name = "correct_option";
            this.correct_option.ReadOnly = true;
            this.correct_option.Width = 75;
            // 
            // option_text
            // 
            this.option_text.DataPropertyName = "option_text";
            this.option_text.HeaderText = "Текст варіанту";
            this.option_text.Name = "option_text";
            this.option_text.ReadOnly = true;
            this.option_text.Width = 325;
            // 
            // add_question_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 243);
            this.Controls.Add(this.panel_sequence);
            this.Controls.Add(this.panel_open_response);
            this.Controls.Add(this.panel_matching);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_subject);
            this.Controls.Add(subject_idLabel);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panel_answer_options);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(response_typeLabel);
            this.Controls.Add(this.comboBox_theme);
            this.Controls.Add(theme_idLabel);
            this.Controls.Add(question_textLabel);
            this.Controls.Add(this.question_textTextBox);
            this.Controls.Add(pointsLabel);
            this.Controls.Add(this.pointsTextBox);
            this.Name = "add_question_show";
            this.Text = "add_question_show";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.add_question_show_FormClosed);
            this.Load += new System.EventHandler(this.add_question_show_Load);
            this.panel_open_response.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_open_response)).EndInit();
            this.panel_sequence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sequence)).EndInit();
            this.panel_matching.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_matching)).EndInit();
            this.panel_answer_options.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_answer_options)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_theme;
        private System.Windows.Forms.TextBox question_textTextBox;
        private System.Windows.Forms.TextBox pointsTextBox;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Panel panel_open_response;
        private System.Windows.Forms.Panel panel_sequence;
        private System.Windows.Forms.Panel panel_matching;
        private System.Windows.Forms.Panel panel_answer_options;
        private System.Windows.Forms.DataGridView dataGridView_open_response;
        private System.Windows.Forms.DataGridView dataGridView_sequence;
        private System.Windows.Forms.DataGridView dataGridView_answer_options;
        private System.Windows.Forms.DataGridView dataGridView_matching;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBox_subject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn matching_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn option_text_m;
        private System.Windows.Forms.DataGridViewTextBoxColumn matching_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn response_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn question_id_response;
        private System.Windows.Forms.DataGridViewTextBoxColumn correct_response;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequence_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequence_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn option_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn correct_option;
        private System.Windows.Forms.DataGridViewTextBoxColumn option_text;
    }
}