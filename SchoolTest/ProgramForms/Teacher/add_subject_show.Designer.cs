namespace SchoolTest.ProgramForms.Teacher
{
    partial class add_subject_show
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
            System.Windows.Forms.Label subject_nameLabel;
            System.Windows.Forms.Label label1;
            this.subject_nameTextBox = new System.Windows.Forms.TextBox();
            this.ClassTextBox = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            subject_nameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // subject_nameLabel
            // 
            subject_nameLabel.AutoSize = true;
            subject_nameLabel.Location = new System.Drawing.Point(31, 31);
            subject_nameLabel.Name = "subject_nameLabel";
            subject_nameLabel.Size = new System.Drawing.Size(55, 13);
            subject_nameLabel.TabIndex = 12;
            subject_nameLabel.Text = "Предмет:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(31, 57);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 13);
            label1.TabIndex = 14;
            label1.Text = "Клас:";
            // 
            // subject_nameTextBox
            // 
            this.subject_nameTextBox.Location = new System.Drawing.Point(92, 28);
            this.subject_nameTextBox.Name = "subject_nameTextBox";
            this.subject_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.subject_nameTextBox.TabIndex = 13;
            // 
            // ClassTextBox
            // 
            this.ClassTextBox.Location = new System.Drawing.Point(92, 54);
            this.ClassTextBox.Name = "ClassTextBox";
            this.ClassTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClassTextBox.TabIndex = 15;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Location = new System.Drawing.Point(127, 94);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 17;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(34, 94);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Зберегти";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // add_subject_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(238, 134);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(label1);
            this.Controls.Add(this.ClassTextBox);
            this.Controls.Add(subject_nameLabel);
            this.Controls.Add(this.subject_nameTextBox);
            this.Name = "add_subject_show";
            this.Text = "Додавання предметів";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.add_subject_show_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.add_subject_show_FormClosed);
            this.Load += new System.EventHandler(this.add_subject_show_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subject_nameTextBox;
        private System.Windows.Forms.TextBox ClassTextBox;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
    }
}