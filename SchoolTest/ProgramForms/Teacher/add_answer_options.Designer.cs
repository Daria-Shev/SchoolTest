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
            this.option_textTextBox = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            option_numberLabel = new System.Windows.Forms.Label();
            correct_optionLabel = new System.Windows.Forms.Label();
            option_textLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // option_numberLabel
            // 
            option_numberLabel.AutoSize = true;
            option_numberLabel.Location = new System.Drawing.Point(12, 28);
            option_numberLabel.Name = "option_numberLabel";
            option_numberLabel.Size = new System.Drawing.Size(44, 13);
            option_numberLabel.TabIndex = 8;
            option_numberLabel.Text = "Номер:";
            // 
            // correct_optionLabel
            // 
            correct_optionLabel.AutoSize = true;
            correct_optionLabel.Location = new System.Drawing.Point(116, 25);
            correct_optionLabel.Name = "correct_optionLabel";
            correct_optionLabel.Size = new System.Drawing.Size(112, 13);
            correct_optionLabel.TabIndex = 10;
            correct_optionLabel.Text = "Правильний варіант:";
            // 
            // option_textLabel
            // 
            option_textLabel.AutoSize = true;
            option_textLabel.Location = new System.Drawing.Point(12, 52);
            option_textLabel.Name = "option_textLabel";
            option_textLabel.Size = new System.Drawing.Size(48, 13);
            option_textLabel.TabIndex = 12;
            option_textLabel.Text = "Варіант:";
            // 
            // option_numberTextBox
            // 
            this.option_numberTextBox.Location = new System.Drawing.Point(62, 25);
            this.option_numberTextBox.Name = "option_numberTextBox";
            this.option_numberTextBox.Size = new System.Drawing.Size(47, 20);
            this.option_numberTextBox.TabIndex = 9;
            // 
            // option_textTextBox
            // 
            this.option_textTextBox.Location = new System.Drawing.Point(62, 52);
            this.option_textTextBox.Multiline = true;
            this.option_textTextBox.Name = "option_textTextBox";
            this.option_textTextBox.Size = new System.Drawing.Size(213, 16);
            this.option_textTextBox.TabIndex = 13;
            this.option_textTextBox.TextChanged += new System.EventHandler(this.option_textTextBox_TextChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Location = new System.Drawing.Point(153, 83);
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
            this.buttonAdd.Location = new System.Drawing.Point(66, 83);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 43;
            this.buttonAdd.Text = "Зберегти";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Так",
            "Ні"});
            this.comboBox1.Location = new System.Drawing.Point(228, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(47, 21);
            this.comboBox1.TabIndex = 45;
            // 
            // add_answer_options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(293, 118);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(option_numberLabel);
            this.Controls.Add(this.option_numberTextBox);
            this.Controls.Add(correct_optionLabel);
            this.Controls.Add(option_textLabel);
            this.Controls.Add(this.option_textTextBox);
            this.Name = "add_answer_options";
            this.Text = "add_answer_options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.add_answer_options_FormClosed);
            this.Load += new System.EventHandler(this.add_answer_options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox option_numberTextBox;
        private System.Windows.Forms.TextBox option_textTextBox;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}