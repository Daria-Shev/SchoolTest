namespace SchoolTest.ProgramForms.Teacher
{
    partial class add_open_response
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
            System.Windows.Forms.Label correct_responseLabel;
            this.correct_responseTextBox = new System.Windows.Forms.TextBox();
            correct_responseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // correct_responseLabel
            // 
            correct_responseLabel.AutoSize = true;
            correct_responseLabel.Location = new System.Drawing.Point(28, 42);
            correct_responseLabel.Name = "correct_responseLabel";
            correct_responseLabel.Size = new System.Drawing.Size(57, 13);
            correct_responseLabel.TabIndex = 4;
            correct_responseLabel.Text = "Відповідь:";
            // 
            // correct_responseTextBox
            // 
            this.correct_responseTextBox.Location = new System.Drawing.Point(102, 39);
            this.correct_responseTextBox.Name = "correct_responseTextBox";
            this.correct_responseTextBox.Size = new System.Drawing.Size(195, 20);
            this.correct_responseTextBox.TabIndex = 5;
            // 
            // add_open_response
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 103);
            this.Controls.Add(correct_responseLabel);
            this.Controls.Add(this.correct_responseTextBox);
            this.Name = "add_open_response";
            this.Text = "add_response";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox correct_responseTextBox;
    }
}