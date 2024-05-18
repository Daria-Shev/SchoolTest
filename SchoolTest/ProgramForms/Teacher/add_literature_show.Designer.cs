namespace SchoolTest.ProgramForms.Teacher
{
    partial class add_literature_show
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
            System.Windows.Forms.Label subject_idLabel;
            System.Windows.Forms.Label theme_idLabel;
            System.Windows.Forms.Label literature_nameLabel;
            System.Windows.Forms.Label literature_linkLabel;
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBox_subject = new System.Windows.Forms.ComboBox();
            this.comboBox_theme = new System.Windows.Forms.ComboBox();
            this.literature_nameTextBox = new System.Windows.Forms.TextBox();
            this.literature_linkTextBox = new System.Windows.Forms.TextBox();
            subject_idLabel = new System.Windows.Forms.Label();
            theme_idLabel = new System.Windows.Forms.Label();
            literature_nameLabel = new System.Windows.Forms.Label();
            literature_linkLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // subject_idLabel
            // 
            subject_idLabel.AutoSize = true;
            subject_idLabel.Location = new System.Drawing.Point(16, 125);
            subject_idLabel.Name = "subject_idLabel";
            subject_idLabel.Size = new System.Drawing.Size(55, 13);
            subject_idLabel.TabIndex = 24;
            subject_idLabel.Text = "Предмет:";
            // 
            // theme_idLabel
            // 
            theme_idLabel.AutoSize = true;
            theme_idLabel.Location = new System.Drawing.Point(16, 152);
            theme_idLabel.Name = "theme_idLabel";
            theme_idLabel.Size = new System.Drawing.Size(37, 13);
            theme_idLabel.TabIndex = 26;
            theme_idLabel.Text = "Тема:";
            // 
            // literature_nameLabel
            // 
            literature_nameLabel.AutoSize = true;
            literature_nameLabel.Location = new System.Drawing.Point(16, 27);
            literature_nameLabel.Name = "literature_nameLabel";
            literature_nameLabel.Size = new System.Drawing.Size(65, 13);
            literature_nameLabel.TabIndex = 28;
            literature_nameLabel.Text = "Література:";
            // 
            // literature_linkLabel
            // 
            literature_linkLabel.AutoSize = true;
            literature_linkLabel.Location = new System.Drawing.Point(15, 86);
            literature_linkLabel.Name = "literature_linkLabel";
            literature_linkLabel.Size = new System.Drawing.Size(66, 13);
            literature_linkLabel.TabIndex = 30;
            literature_linkLabel.Text = "Посилання:";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Location = new System.Drawing.Point(202, 187);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 23;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(68, 187);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Зберегти";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBox_subject
            // 
            this.comboBox_subject.DisplayMember = "subject_name";
            this.comboBox_subject.FormattingEnabled = true;
            this.comboBox_subject.Location = new System.Drawing.Point(89, 122);
            this.comboBox_subject.Name = "comboBox_subject";
            this.comboBox_subject.Size = new System.Drawing.Size(227, 21);
            this.comboBox_subject.TabIndex = 25;
            this.comboBox_subject.ValueMember = "subject_id";
            this.comboBox_subject.SelectionChangeCommitted += new System.EventHandler(this.comboBox_subject_SelectionChangeCommitted);
            // 
            // comboBox_theme
            // 
            this.comboBox_theme.DisplayMember = "theme_name";
            this.comboBox_theme.FormattingEnabled = true;
            this.comboBox_theme.Location = new System.Drawing.Point(89, 149);
            this.comboBox_theme.Name = "comboBox_theme";
            this.comboBox_theme.Size = new System.Drawing.Size(227, 21);
            this.comboBox_theme.TabIndex = 27;
            this.comboBox_theme.ValueMember = "theme_id";
            // 
            // literature_nameTextBox
            // 
            this.literature_nameTextBox.Location = new System.Drawing.Point(89, 8);
            this.literature_nameTextBox.Multiline = true;
            this.literature_nameTextBox.Name = "literature_nameTextBox";
            this.literature_nameTextBox.Size = new System.Drawing.Size(227, 46);
            this.literature_nameTextBox.TabIndex = 29;
            // 
            // literature_linkTextBox
            // 
            this.literature_linkTextBox.Location = new System.Drawing.Point(89, 60);
            this.literature_linkTextBox.Multiline = true;
            this.literature_linkTextBox.Name = "literature_linkTextBox";
            this.literature_linkTextBox.Size = new System.Drawing.Size(227, 55);
            this.literature_linkTextBox.TabIndex = 31;
            // 
            // add_literature_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(355, 232);
            this.Controls.Add(literature_nameLabel);
            this.Controls.Add(this.literature_nameTextBox);
            this.Controls.Add(literature_linkLabel);
            this.Controls.Add(this.literature_linkTextBox);
            this.Controls.Add(this.comboBox_theme);
            this.Controls.Add(theme_idLabel);
            this.Controls.Add(this.comboBox_subject);
            this.Controls.Add(subject_idLabel);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Name = "add_literature_show";
            this.Text = "Додавання літератури";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.add_literature_show_FormClosed);
            this.Load += new System.EventHandler(this.add_literature_show_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBox_subject;
        private System.Windows.Forms.ComboBox comboBox_theme;
        private System.Windows.Forms.TextBox literature_nameTextBox;
        private System.Windows.Forms.TextBox literature_linkTextBox;
    }
}