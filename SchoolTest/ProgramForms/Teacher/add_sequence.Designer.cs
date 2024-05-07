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
            sequence_numberLabel = new System.Windows.Forms.Label();
            sequence_textLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sequence_numberLabel
            // 
            sequence_numberLabel.AutoSize = true;
            sequence_numberLabel.Location = new System.Drawing.Point(20, 26);
            sequence_numberLabel.Name = "sequence_numberLabel";
            sequence_numberLabel.Size = new System.Drawing.Size(116, 13);
            sequence_numberLabel.TabIndex = 6;
            sequence_numberLabel.Text = "Номер послідовності:";
            // 
            // sequence_numberTextBox
            // 
            this.sequence_numberTextBox.Location = new System.Drawing.Point(140, 23);
            this.sequence_numberTextBox.Name = "sequence_numberTextBox";
            this.sequence_numberTextBox.Size = new System.Drawing.Size(192, 20);
            this.sequence_numberTextBox.TabIndex = 7;
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
            // sequence_textTextBox
            // 
            this.sequence_textTextBox.Location = new System.Drawing.Point(140, 49);
            this.sequence_textTextBox.Name = "sequence_textTextBox";
            this.sequence_textTextBox.Size = new System.Drawing.Size(192, 20);
            this.sequence_textTextBox.TabIndex = 9;
            // 
            // add_sequence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 120);
            this.Controls.Add(sequence_numberLabel);
            this.Controls.Add(this.sequence_numberTextBox);
            this.Controls.Add(sequence_textLabel);
            this.Controls.Add(this.sequence_textTextBox);
            this.Name = "add_sequence";
            this.Text = "add_sequence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sequence_numberTextBox;
        private System.Windows.Forms.TextBox sequence_textTextBox;
    }
}