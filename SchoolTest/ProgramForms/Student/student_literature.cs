using Newtonsoft.Json;
using SchoolTest.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolTest.ProgramForms.Student
{
    public partial class student_literature : Form
    {

        string theme_id;
        public student_literature(string data)
        {
            InitializeComponent();
            theme_id = data;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["literature_name"].Index)
            {
                // Получаем скрытое значение с гиперссылкой
                string literature_link = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag as string;

                // Открываем гиперссылку
                if (!string.IsNullOrEmpty(literature_link))
                {
                    Process.Start(literature_link);
                }
            }
        }

        private void student_literature_Load(object sender, EventArgs e)
        {
            Table();


        }
        public void Table()
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "literature_table_student";
            authApi.query.Add("theme_id", theme_id);
            authApi.uriCreate();

            var Stream = authApi.ServerAuthorization();

            var info = JsonHelpers.ReadFromJsonStream<string>(Stream);
            DataTable dataTable = new DataTable();
             dataTable = JsonConvert.DeserializeObject(info, typeof(DataTable)) as DataTable;
            dataGridView1.DataSource = dataTable;
            // Форматирование ячеек DataGridView
            dataGridView1.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex == dataGridView1.Columns["literature_name"].Index && e.RowIndex >= 0)
                {
                    // Отображаем текст в ячейке
                    e.Value = dataTable.Rows[e.RowIndex]["literature_name"];

                    // Скрываем значение гиперссылки в ячейке
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag = dataTable.Rows[e.RowIndex]["literature_link"];
                }
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
