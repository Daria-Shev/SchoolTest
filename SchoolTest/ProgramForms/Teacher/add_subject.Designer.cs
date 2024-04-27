namespace SchoolTest.ProgramForms.Teacher
{
    partial class add_subject
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.subject_nameTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            subject_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subject,
            this.class_number,
            this.subject_id});
            this.dataGridView1.Location = new System.Drawing.Point(57, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(352, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(78, 103);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Додати";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // subject
            // 
            this.subject.HeaderText = "Назва предмета";
            this.subject.Name = "subject";
            // 
            // class_number
            // 
            this.class_number.HeaderText = "Клас";
            this.class_number.Name = "class_number";
            // 
            // subject_id
            // 
            this.subject_id.HeaderText = "id";
            this.subject_id.Name = "subject_id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Оновити";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // subject_nameLabel
            // 
            subject_nameLabel.AutoSize = true;
            subject_nameLabel.Location = new System.Drawing.Point(102, 60);
            subject_nameLabel.Name = "subject_nameLabel";
            subject_nameLabel.Size = new System.Drawing.Size(55, 13);
            subject_nameLabel.TabIndex = 10;
            subject_nameLabel.Text = "Предмет:";
            // 
            // subject_nameTextBox
            // 
            this.subject_nameTextBox.Location = new System.Drawing.Point(181, 57);
            this.subject_nameTextBox.Name = "subject_nameTextBox";
            this.subject_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.subject_nameTextBox.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Видалити";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // add_subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 340);
            this.Controls.Add(this.button2);
            this.Controls.Add(subject_nameLabel);
            this.Controls.Add(this.subject_nameTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "add_subject";
            this.Text = "add_subject";
            this.Load += new System.EventHandler(this.add_subject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox subject_nameTextBox;
        private System.Windows.Forms.Button button2;
    }
}