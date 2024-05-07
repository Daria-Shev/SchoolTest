namespace SchoolTest.ProgramForms.Teacher
{
    partial class add_matching
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
            System.Windows.Forms.Label matching_numberLabel;
            System.Windows.Forms.Label option_textLabel1;
            System.Windows.Forms.Label matching_textLabel;
            this.matching_numberTextBox = new System.Windows.Forms.TextBox();
            this.option_textTextBox1 = new System.Windows.Forms.TextBox();
            this.matching_textTextBox = new System.Windows.Forms.TextBox();
            matching_numberLabel = new System.Windows.Forms.Label();
            option_textLabel1 = new System.Windows.Forms.Label();
            matching_textLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // matching_numberLabel
            // 
            matching_numberLabel.AutoSize = true;
            matching_numberLabel.Location = new System.Drawing.Point(26, 42);
            matching_numberLabel.Name = "matching_numberLabel";
            matching_numberLabel.Size = new System.Drawing.Size(112, 13);
            matching_numberLabel.TabIndex = 8;
            matching_numberLabel.Text = "Номер відповідності:";
            // 
            // matching_numberTextBox
            // 
            this.matching_numberTextBox.Location = new System.Drawing.Point(144, 38);
            this.matching_numberTextBox.Name = "matching_numberTextBox";
            this.matching_numberTextBox.Size = new System.Drawing.Size(188, 20);
            this.matching_numberTextBox.TabIndex = 9;
            // 
            // option_textLabel1
            // 
            option_textLabel1.AutoSize = true;
            option_textLabel1.Location = new System.Drawing.Point(38, 68);
            option_textLabel1.Name = "option_textLabel1";
            option_textLabel1.Size = new System.Drawing.Size(48, 13);
            option_textLabel1.TabIndex = 10;
            option_textLabel1.Text = "Варіант:";
            // 
            // option_textTextBox1
            // 
            this.option_textTextBox1.Location = new System.Drawing.Point(144, 66);
            this.option_textTextBox1.Name = "option_textTextBox1";
            this.option_textTextBox1.Size = new System.Drawing.Size(188, 20);
            this.option_textTextBox1.TabIndex = 11;
            // 
            // matching_textLabel
            // 
            matching_textLabel.AutoSize = true;
            matching_textLabel.Location = new System.Drawing.Point(38, 94);
            matching_textLabel.Name = "matching_textLabel";
            matching_textLabel.Size = new System.Drawing.Size(76, 13);
            matching_textLabel.TabIndex = 12;
            matching_textLabel.Text = "Відповідність:";
            // 
            // matching_textTextBox
            // 
            this.matching_textTextBox.Location = new System.Drawing.Point(144, 92);
            this.matching_textTextBox.Name = "matching_textTextBox";
            this.matching_textTextBox.Size = new System.Drawing.Size(188, 20);
            this.matching_textTextBox.TabIndex = 13;
            // 
            // matching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(matching_numberLabel);
            this.Controls.Add(this.matching_numberTextBox);
            this.Controls.Add(option_textLabel1);
            this.Controls.Add(this.option_textTextBox1);
            this.Controls.Add(matching_textLabel);
            this.Controls.Add(this.matching_textTextBox);
            this.Name = "matching";
            this.Text = "matching";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox matching_numberTextBox;
        private System.Windows.Forms.TextBox option_textTextBox1;
        private System.Windows.Forms.TextBox matching_textTextBox;
    }
}