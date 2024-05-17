using Newtonsoft.Json;
using SchoolTest.Helpers;
using SchoolTest.Info;
using SchoolTest.ProgramForms.Student;
using SchoolTest.ProgramForms.Teacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolTest.ProgramForms.Statistics
{
    public partial class Statistics_student : Form
    {
        public Statistics_student()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ifrm = new studentHome();
            ifrm.Show();
            this.Close();
        }

        private void Statistics_student_Load(object sender, EventArgs e)
        {
            Table();
            combo_Load();

        }
        private void combo_Load()
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
            // Получаем выбранное значение из comboBox1
            string selectedColumnName = "subject_name";
            // Получаем уникальные значения из выбранной колонки в DataGridView
            HashSet<string> uniqueValues = new HashSet<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Получаем значение ячейки из выбранной колонки
                string cellValue = row.Cells[selectedColumnName].Value?.ToString();
                // Добавляем значение в HashSet, если оно не пустое
                if (!string.IsNullOrEmpty(cellValue))
                {
                    uniqueValues.Add(cellValue);
                }
            }
            // Заполняем comboBox2 уникальными значениями
            comboBox1.DataSource = new BindingSource(uniqueValues.ToList(), null);
            //comboBox1_SelectedIndexChanged(sender, e);
        }


        public void Table()
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "statistics_student";

            var classObject = new
            {
                class_id = User.class_id,
                user_account_id = User.id,
            };
            var json = JsonConvert.SerializeObject(classObject);



            // старий варіант
            authApi.query.Add("jsonData", json);
            authApi.uriCreate();

            var Stream = authApi.ServerAuthorization();

            var info = JsonHelpers.ReadFromJsonStream<string>(Stream);
            dataGridView1.DataSource = JsonConvert.DeserializeObject(info, typeof(DataTable)) as DataTable;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filteredText = comboBox1.Text.Replace("'", "''");
            string columnName = "subject_name";

            // Экранирование специальных символов, таких как '%', '[', и ']'
            filteredText = filteredText.Replace("%", "[%]").Replace("[", "[[]").Replace("]", "[]]");

            try
            {
                // Используйте кавычки вокруг значения в фильтре
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"{columnName} LIKE '%{filteredText}%'";
            }
            catch { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
