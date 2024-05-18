namespace SchoolTest.ProgramForms.Student
{
    partial class student_literature
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.literature_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.literature_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.literature_link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.literature_name,
            this.theme,
            this.literature_id,
            this.literature_link});
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(666, 279);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // literature_name
            // 
            this.literature_name.DataPropertyName = "literature_name";
            this.literature_name.HeaderText = "Рекомендована література по темі";
            this.literature_name.Name = "literature_name";
            this.literature_name.ReadOnly = true;
            this.literature_name.Width = 600;
            // 
            // theme
            // 
            this.theme.DataPropertyName = "theme_id";
            this.theme.HeaderText = "theme_id";
            this.theme.Name = "theme";
            this.theme.ReadOnly = true;
            this.theme.Visible = false;
            // 
            // literature_id
            // 
            this.literature_id.DataPropertyName = "literature_id";
            this.literature_id.HeaderText = "literature_id";
            this.literature_id.Name = "literature_id";
            this.literature_id.ReadOnly = true;
            this.literature_id.Visible = false;
            // 
            // literature_link
            // 
            this.literature_link.DataPropertyName = "literature_link";
            this.literature_link.HeaderText = "literature_link";
            this.literature_link.Name = "literature_link";
            this.literature_link.ReadOnly = true;
            this.literature_link.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(252)))), ((int)(((byte)(222)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(270, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 36);
            this.button3.TabIndex = 55;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // student_literature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(251)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(693, 354);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "student_literature";
            this.Text = "Рекомендована література";
            this.Load += new System.EventHandler(this.student_literature_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn literature_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn theme;
        private System.Windows.Forms.DataGridViewTextBoxColumn literature_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn literature_link;
        private System.Windows.Forms.Button button3;
    }
}