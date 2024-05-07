namespace SchoolTest.ProgramForms.Teacher
{
    partial class add_answer_options
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
            System.Windows.Forms.Label option_numberLabel;
            System.Windows.Forms.Label correct_optionLabel;
            System.Windows.Forms.Label option_textLabel;
            this.option_numberTextBox = new System.Windows.Forms.TextBox();
            this.correct_optionTextBox = new System.Windows.Forms.TextBox();
            this.option_textTextBox = new System.Windows.Forms.TextBox();
            option_numberLabel = new System.Windows.Forms.Label();
            correct_optionLabel = new System.Windows.Forms.Label();
            option_textLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // option_numberLabel
            // 
            option_numberLabel.AutoSize = true;
            option_numberLabel.Location = new System.Drawing.Point(21, 32);
            option_numberLabel.Name = "option_numberLabel";
            option_numberLabel.Size = new System.Drawing.Size(89, 13);
            option_numberLabel.TabIndex = 8;
            option_numberLabel.Text = "Номер варіанту:";
            // 
            // option_numberTextBox
            // 
            this.option_numberTextBox.Location = new System.Drawing.Point(110, 29);
            this.option_numberTextBox.Name = "option_numberTextBox";
            this.option_numberTextBox.Size = new System.Drawing.Size(200, 20);
            this.option_numberTextBox.TabIndex = 9;
            // 
            // correct_optionLabel
            // 
            correct_optionLabel.AutoSize = true;
            correct_optionLabel.Location = new System.Drawing.Point(24, 55);
            correct_optionLabel.Name = "correct_optionLabel";
            correct_optionLabel.Size = new System.Drawing.Size(83, 13);
            correct_optionLabel.TabIndex = 10;
            correct_optionLabel.Text = "Вірний варіант:";
            // 
            // correct_optionTextBox
            // 
            this.correct_optionTextBox.Location = new System.Drawing.Point(110, 55);
            this.correct_optionTextBox.Name = "correct_optionTextBox";
            this.correct_optionTextBox.Size = new System.Drawing.Size(200, 20);
            this.correct_optionTextBox.TabIndex = 11;
            // 
            // option_textLabel
            // 
            option_textLabel.AutoSize = true;
            option_textLabel.Location = new System.Drawing.Point(43, 84);
            option_textLabel.Name = "option_textLabel";
            option_textLabel.Size = new System.Drawing.Size(48, 13);
            option_textLabel.TabIndex = 12;
            option_textLabel.Text = "Варіант:";
            // 
            // option_textTextBox
            // 
            this.option_textTextBox.Location = new System.Drawing.Point(110, 81);
            this.option_textTextBox.Name = "option_textTextBox";
            this.option_textTextBox.Size = new System.Drawing.Size(200, 20);
            this.option_textTextBox.TabIndex = 13;
            // 
            // add_answer_options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(option_numberLabel);
            this.Controls.Add(this.option_numberTextBox);
            this.Controls.Add(correct_optionLabel);
            this.Controls.Add(this.correct_optionTextBox);
            this.Controls.Add(option_textLabel);
            this.Controls.Add(this.option_textTextBox);
            this.Name = "add_answer_options";
            this.Text = "add_answer_options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox option_numberTextBox;
        private System.Windows.Forms.TextBox correct_optionTextBox;
        private System.Windows.Forms.TextBox option_textTextBox;
    }
}