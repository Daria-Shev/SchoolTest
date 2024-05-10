namespace SchoolTest.ProgramForms.Student
{
    partial class menuTest
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_subject = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox_theme = new System.Windows.Forms.ComboBox();
            subject_idLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Обери тему:";
            // 
            // comboBox_subject
            // 
            this.comboBox_subject.DisplayMember = "subject_name";
            this.comboBox_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_subject.FormattingEnabled = true;
            this.comboBox_subject.Location = new System.Drawing.Point(143, 21);
            this.comboBox_subject.Name = "comboBox_subject";
            this.comboBox_subject.Size = new System.Drawing.Size(274, 28);
            this.comboBox_subject.TabIndex = 46;
            this.comboBox_subject.ValueMember = "subject_id";
            // 
            // subject_idLabel
            // 
            subject_idLabel.AutoSize = true;
            subject_idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            subject_idLabel.Location = new System.Drawing.Point(12, 24);
            subject_idLabel.Name = "subject_idLabel";
            subject_idLabel.Size = new System.Drawing.Size(132, 20);
            subject_idLabel.TabIndex = 45;
            subject_idLabel.Text = "Обери предмет:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(56, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(299, 58);
            this.button4.TabIndex = 49;
            this.button4.Text = "Почати тестування";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(56, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 58);
            this.button1.TabIndex = 50;
            this.button1.Text = "Пройти підготовчий тест";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(56, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(299, 58);
            this.button2.TabIndex = 51;
            this.button2.Text = "Подивитися рекомендовану літературу";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(56, 305);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(299, 58);
            this.button3.TabIndex = 53;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // comboBox_theme
            // 
            this.comboBox_theme.DisplayMember = "theme_name";
            this.comboBox_theme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_theme.FormattingEnabled = true;
            this.comboBox_theme.Location = new System.Drawing.Point(143, 66);
            this.comboBox_theme.Name = "comboBox_theme";
            this.comboBox_theme.Size = new System.Drawing.Size(274, 28);
            this.comboBox_theme.TabIndex = 54;
            this.comboBox_theme.ValueMember = "theme_id";
            // 
            // menuTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 372);
            this.Controls.Add(this.comboBox_theme);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_subject);
            this.Controls.Add(subject_idLabel);
            this.Name = "menuTest";
            this.Text = "menuTest";
            this.Load += new System.EventHandler(this.menuTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_subject;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox_theme;
    }
}