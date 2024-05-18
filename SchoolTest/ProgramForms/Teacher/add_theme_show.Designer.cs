namespace SchoolTest.ProgramForms.Teacher
{
    partial class add_theme_show
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
            System.Windows.Forms.Label theme_nameLabel;
            System.Windows.Forms.Label subject_idLabel;
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.theme_nameTextBox = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            theme_nameLabel = new System.Windows.Forms.Label();
            subject_idLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // theme_nameLabel
            // 
            theme_nameLabel.AutoSize = true;
            theme_nameLabel.Location = new System.Drawing.Point(14, 26);
            theme_nameLabel.Name = "theme_nameLabel";
            theme_nameLabel.Size = new System.Drawing.Size(37, 13);
            theme_nameLabel.TabIndex = 10;
            theme_nameLabel.Text = "Тема:";
            // 
            // subject_idLabel
            // 
            subject_idLabel.AutoSize = true;
            subject_idLabel.Location = new System.Drawing.Point(14, 79);
            subject_idLabel.Name = "subject_idLabel";
            subject_idLabel.Size = new System.Drawing.Size(55, 13);
            subject_idLabel.TabIndex = 12;
            subject_idLabel.Text = "Предмет:";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "subject_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "subject_id";
            // 
            // theme_nameTextBox
            // 
            this.theme_nameTextBox.Location = new System.Drawing.Point(88, 26);
            this.theme_nameTextBox.Multiline = true;
            this.theme_nameTextBox.Name = "theme_nameTextBox";
            this.theme_nameTextBox.Size = new System.Drawing.Size(214, 44);
            this.theme_nameTextBox.TabIndex = 11;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Location = new System.Drawing.Point(156, 116);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(63, 116);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Зберегти";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // add_theme_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(315, 161);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(theme_nameLabel);
            this.Controls.Add(this.theme_nameTextBox);
            this.Controls.Add(subject_idLabel);
            this.Name = "add_theme_show";
            this.Text = "Додавання тем";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.add_theme_show_FormClosed);
            this.Load += new System.EventHandler(this.add_theme_show_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox theme_nameTextBox;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
    }
}