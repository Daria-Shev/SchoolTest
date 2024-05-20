namespace SchoolTest.ProgramForms.Student.Test
{
    partial class result_test
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.answer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_account_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_id123 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_attempt123 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.question_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.question_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.answer_id,
            this.user_account_id,
            this.test_id123,
            this.test_attempt123,
            this.question_id,
            this.question_text,
            this.correctness});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 279);
            this.dataGridView1.TabIndex = 54;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(204, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(299, 51);
            this.button3.TabIndex = 55;
            this.button3.Text = "Завершити перегляд";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // answer_id
            // 
            this.answer_id.DataPropertyName = "answer_id";
            this.answer_id.HeaderText = "answer_id";
            this.answer_id.Name = "answer_id";
            this.answer_id.Visible = false;
            // 
            // user_account_id
            // 
            this.user_account_id.DataPropertyName = "user_account_id";
            this.user_account_id.HeaderText = "user_account_id";
            this.user_account_id.Name = "user_account_id";
            this.user_account_id.Visible = false;
            // 
            // test_id123
            // 
            this.test_id123.DataPropertyName = "test_id";
            this.test_id123.HeaderText = "test_id";
            this.test_id123.Name = "test_id123";
            this.test_id123.Visible = false;
            // 
            // test_attempt123
            // 
            this.test_attempt123.DataPropertyName = "test_attempt";
            this.test_attempt123.HeaderText = "test_attempt";
            this.test_attempt123.Name = "test_attempt123";
            this.test_attempt123.Visible = false;
            // 
            // question_id
            // 
            this.question_id.DataPropertyName = "question_id";
            this.question_id.HeaderText = "question_id";
            this.question_id.Name = "question_id";
            this.question_id.Visible = false;
            // 
            // question_text
            // 
            this.question_text.DataPropertyName = "question_text";
            this.question_text.HeaderText = "Питання";
            this.question_text.Name = "question_text";
            this.question_text.Width = 500;
            // 
            // correctness
            // 
            this.correctness.DataPropertyName = "correctness";
            this.correctness.HeaderText = "Правильність";
            this.correctness.Name = "correctness";
            this.correctness.Width = 150;
            // 
            // result_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(718, 372);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "result_test";
            this.Text = "Результати тестування";
            this.Load += new System.EventHandler(this.result_test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_account_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_id123;
        private System.Windows.Forms.DataGridViewTextBoxColumn test_attempt123;
        private System.Windows.Forms.DataGridViewTextBoxColumn question_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn question_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctness;
    }
}