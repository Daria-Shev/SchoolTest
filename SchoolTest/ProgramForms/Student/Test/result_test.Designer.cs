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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.answer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.question_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.question_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
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
            this.question_id,
            this.question_text,
            this.correctness});
            this.dataGridView1.Location = new System.Drawing.Point(75, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(695, 279);
            this.dataGridView1.TabIndex = 54;
            // 
            // answer_id
            // 
            this.answer_id.DataPropertyName = "answer_id";
            this.answer_id.HeaderText = "answer_id";
            this.answer_id.Name = "answer_id";
            this.answer_id.ReadOnly = true;
            this.answer_id.Visible = false;
            // 
            // question_id
            // 
            this.question_id.DataPropertyName = "question_id";
            this.question_id.HeaderText = "question_id";
            this.question_id.Name = "question_id";
            this.question_id.ReadOnly = true;
            this.question_id.Visible = false;
            // 
            // question_text
            // 
            this.question_text.DataPropertyName = "question_text";
            this.question_text.HeaderText = "Питання";
            this.question_text.Name = "question_text";
            this.question_text.ReadOnly = true;
            this.question_text.Width = 300;
            // 
            // correctness
            // 
            this.correctness.DataPropertyName = "correctness";
            this.correctness.HeaderText = "Правильність";
            this.correctness.Name = "correctness";
            this.correctness.ReadOnly = true;
            this.correctness.Width = 150;
            // 
            // result_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "result_test";
            this.Text = "result_test";
            this.Load += new System.EventHandler(this.result_test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn answer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn question_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn question_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctness;
    }
}