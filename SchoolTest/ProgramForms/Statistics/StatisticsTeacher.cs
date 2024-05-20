using Newtonsoft.Json;
using SchoolTest.Helpers;
using SchoolTest.Info;
using SchoolTest.ProgramForms.Teacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolTest.ProgramForms.Statistics
{
    public partial class StatisticsTeacher : Form
    {
        public StatisticsTeacher()
        {
            InitializeComponent();
        }

        private void StatisticsTeacher_Load(object sender, EventArgs e)
        {
            Table();
            combo_class_Load();
            combo_student_Load();
            combo_subject_Load();
            button1_Click(sender, e);
        }
        public void Table()
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "statistics_teacher";
            authApi.uriCreate();

            var Stream = authApi.ServerAuthorization();

            var info = JsonHelpers.ReadFromJsonStream<string>(Stream);
            dataGridView1.DataSource = JsonConvert.DeserializeObject(info, typeof(DataTable)) as DataTable;
        }
        private void combo_class_Load()
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
            // Получаем выбранное значение из comboBox1
            string selectedColumnName = "class_name";
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
            comboBox_class.DataSource = new BindingSource(uniqueValues.ToList(), null);
            //comboBox1_SelectedIndexChanged(sender, e);
        }
        private void combo_student_Load()
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
            // Получаем выбранное значение из comboBox1
            string selectedColumnName = "full_name";
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
            comboBox_student.DataSource = new BindingSource(uniqueValues.ToList(), null);
            //comboBox1_SelectedIndexChanged(sender, e);
        }
        private void combo_subject_Load()
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
            comboBox_subject.DataSource = new BindingSource(uniqueValues.ToList(), null);
            //comboBox1_SelectedIndexChanged(sender, e);
        }

        private void ApplyFilters()
        {
            string classFilter = GetFilter("class_name", comboBox_class.Text);
            string subjectFilter = GetFilter("subject_name", comboBox_subject.Text);
            string studentFilter = GetFilter("full_name", comboBox_student.Text);

            string combinedFilter = $"{classFilter} AND {subjectFilter} AND {studentFilter}";

            try
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = combinedFilter;
            }
            catch { }
        }

        private string GetFilter(string columnName, string filteredText)
        {
            // Екранування спеціальних символів
            filteredText = filteredText.Replace("'", "''");
            filteredText = filteredText.Replace("%", "[%]").Replace("[", "[[]").Replace("]", "[]]");

            // Повернення умови фільтрації для відповідної колонки
            return $"{columnName} LIKE '%{filteredText}%'";
        }

        private void comboBox_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
            combo_student_Load();
            combo_subject_Load();
        }

        private void comboBox_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void comboBox_student_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form ifrm = new teacherHome();
            ifrm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox_student.Text = "";
            comboBox_subject.Text = "";
            comboBox_class.Text = "";

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
        }
    }
}
