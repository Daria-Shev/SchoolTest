namespace SchoolTest.ProgramForms.Teacher
{
    partial class add_class_show
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
            System.Windows.Forms.Label class_nameLabel;
            System.Windows.Forms.Label class_numberLabel;
            this.class_nameTextBox = new System.Windows.Forms.TextBox();
            this.class_numberTextBox = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            class_nameLabel = new System.Windows.Forms.Label();
            class_numberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // class_nameLabel
            // 
            class_nameLabel.AutoSize = true;
            class_nameLabel.Location = new System.Drawing.Point(33, 25);
            class_nameLabel.Name = "class_nameLabel";
            class_nameLabel.Size = new System.Drawing.Size(75, 13);
            class_nameLabel.TabIndex = 7;
            class_nameLabel.Text = "Назва класа:";
            // 
            // class_numberLabel
            // 
            class_numberLabel.AutoSize = true;
            class_numberLabel.Location = new System.Drawing.Point(33, 51);
            class_numberLabel.Name = "class_numberLabel";
            class_numberLabel.Size = new System.Drawing.Size(35, 13);
            class_numberLabel.TabIndex = 9;
            class_numberLabel.Text = "Клас:";
            // 
            // class_nameTextBox
            // 
            this.class_nameTextBox.Location = new System.Drawing.Point(111, 22);
            this.class_nameTextBox.Name = "class_nameTextBox";
            this.class_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.class_nameTextBox.TabIndex = 8;
            // 
            // class_numberTextBox
            // 
            this.class_numberTextBox.Location = new System.Drawing.Point(111, 48);
            this.class_numberTextBox.Name = "class_numberTextBox";
            this.class_numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.class_numberTextBox.TabIndex = 10;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Location = new System.Drawing.Point(126, 80);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 19;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(33, 80);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Зберегти";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // add_class_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(249, 116);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(class_nameLabel);
            this.Controls.Add(this.class_nameTextBox);
            this.Controls.Add(class_numberLabel);
            this.Controls.Add(this.class_numberTextBox);
            this.Name = "add_class_show";
            this.Text = "Додавання класу";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.add_class_show_FormClosed);
            this.Load += new System.EventHandler(this.add_class_show_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox class_nameTextBox;
        private System.Windows.Forms.TextBox class_numberTextBox;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
    }
}