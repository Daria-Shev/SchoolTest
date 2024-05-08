namespace SchoolTest.ProgramForms.Teacher
{
    partial class add_sequence
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
            System.Windows.Forms.Label sequence_numberLabel;
            System.Windows.Forms.Label sequence_textLabel;
            this.sequence_numberTextBox = new System.Windows.Forms.TextBox();
            this.sequence_textTextBox = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            sequence_numberLabel = new System.Windows.Forms.Label();
            sequence_textLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sequence_numberLabel
            // 
            sequence_numberLabel.AutoSize = true;
            sequence_numberLabel.Location = new System.Drawing.Point(22, 26);
            sequence_numberLabel.Name = "sequence_numberLabel";
            sequence_numberLabel.Size = new System.Drawing.Size(126, 13);
            sequence_numberLabel.TabIndex = 6;
            sequence_numberLabel.Text = "Порядок послідовності:";
            // 
            // sequence_textLabel
            // 
            sequence_textLabel.AutoSize = true;
            sequence_textLabel.Location = new System.Drawing.Point(22, 52);
            sequence_textLabel.Name = "sequence_textLabel";
            sequence_textLabel.Size = new System.Drawing.Size(112, 13);
            sequence_textLabel.TabIndex = 8;
            sequence_textLabel.Text = "Текст послідовності:";
            // 
            // sequence_numberTextBox
            // 
            this.sequence_numberTextBox.Location = new System.Drawing.Point(150, 23);
            this.sequence_numberTextBox.Name = "sequence_numberTextBox";
            this.sequence_numberTextBox.Size = new System.Drawing.Size(192, 20);
            this.sequence_numberTextBox.TabIndex = 7;
            // 
            // sequence_textTextBox
            // 
            this.sequence_textTextBox.Location = new System.Drawing.Point(150, 49);
            this.sequence_textTextBox.Multiline = true;
            this.sequence_textTextBox.Name = "sequence_textTextBox";
            this.sequence_textTextBox.Size = new System.Drawing.Size(192, 59);
            this.sequence_textTextBox.TabIndex = 9;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Location = new System.Drawing.Point(176, 119);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 44;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(89, 119);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 43;
            this.buttonAdd.Text = "Зберегти";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // add_sequence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 154);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(sequence_numberLabel);
            this.Controls.Add(this.sequence_numberTextBox);
            this.Controls.Add(sequence_textLabel);
            this.Controls.Add(this.sequence_textTextBox);
            this.Name = "add_sequence";
            this.Text = "add_sequence";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.add_sequence_FormClosed);
            this.Load += new System.EventHandler(this.add_sequence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sequence_numberTextBox;
        private System.Windows.Forms.TextBox sequence_textTextBox;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
    }
}