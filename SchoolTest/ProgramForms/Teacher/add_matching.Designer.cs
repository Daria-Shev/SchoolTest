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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            matching_numberLabel = new System.Windows.Forms.Label();
            option_textLabel1 = new System.Windows.Forms.Label();
            matching_textLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // matching_numberLabel
            // 
            matching_numberLabel.AutoSize = true;
            matching_numberLabel.Location = new System.Drawing.Point(20, 16);
            matching_numberLabel.Name = "matching_numberLabel";
            matching_numberLabel.Size = new System.Drawing.Size(44, 13);
            matching_numberLabel.TabIndex = 8;
            matching_numberLabel.Text = "Номер:";
            // 
            // option_textLabel1
            // 
            option_textLabel1.AutoSize = true;
            option_textLabel1.Location = new System.Drawing.Point(20, 42);
            option_textLabel1.Name = "option_textLabel1";
            option_textLabel1.Size = new System.Drawing.Size(48, 13);
            option_textLabel1.TabIndex = 10;
            option_textLabel1.Text = "Варіант:";
            // 
            // matching_textLabel
            // 
            matching_textLabel.AutoSize = true;
            matching_textLabel.Location = new System.Drawing.Point(20, 71);
            matching_textLabel.Name = "matching_textLabel";
            matching_textLabel.Size = new System.Drawing.Size(76, 13);
            matching_textLabel.TabIndex = 12;
            matching_textLabel.Text = "Відповідність:";
            // 
            // matching_numberTextBox
            // 
            this.matching_numberTextBox.Location = new System.Drawing.Point(92, 13);
            this.matching_numberTextBox.Name = "matching_numberTextBox";
            this.matching_numberTextBox.Size = new System.Drawing.Size(57, 20);
            this.matching_numberTextBox.TabIndex = 9;
            // 
            // option_textTextBox1
            // 
            this.option_textTextBox1.Location = new System.Drawing.Point(92, 68);
            this.option_textTextBox1.Multiline = true;
            this.option_textTextBox1.Name = "option_textTextBox1";
            this.option_textTextBox1.Size = new System.Drawing.Size(218, 25);
            this.option_textTextBox1.TabIndex = 11;
            // 
            // matching_textTextBox
            // 
            this.matching_textTextBox.Location = new System.Drawing.Point(92, 39);
            this.matching_textTextBox.Multiline = true;
            this.matching_textTextBox.Name = "matching_textTextBox";
            this.matching_textTextBox.Size = new System.Drawing.Size(218, 23);
            this.matching_textTextBox.TabIndex = 13;
            this.matching_textTextBox.TextChanged += new System.EventHandler(this.matching_textTextBox_TextChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Location = new System.Drawing.Point(160, 110);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 46;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(73, 110);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 45;
            this.buttonAdd.Text = "Зберегти";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // add_matching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(327, 145);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(matching_numberLabel);
            this.Controls.Add(this.matching_numberTextBox);
            this.Controls.Add(option_textLabel1);
            this.Controls.Add(this.option_textTextBox1);
            this.Controls.Add(matching_textLabel);
            this.Controls.Add(this.matching_textTextBox);
            this.Name = "add_matching";
            this.Text = "matching";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.add_matching_FormClosed);
            this.Load += new System.EventHandler(this.add_matching_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox matching_numberTextBox;
        private System.Windows.Forms.TextBox option_textTextBox1;
        private System.Windows.Forms.TextBox matching_textTextBox;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
    }
}