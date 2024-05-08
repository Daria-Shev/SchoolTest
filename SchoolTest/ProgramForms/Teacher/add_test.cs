using Newtonsoft.Json;
using SchoolTest.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolTest.ProgramForms.Teacher
{
    public partial class add_test : Form
    {
        public add_test()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form ifrm = new addData();
            ifrm.Show();
            this.Close();
        }

        private void add_test_Load(object sender, EventArgs e)
        {
            Table();
            combo_Load();
            comboBox1.Text = "";
        }
        private void combo_Load()
        {
            List<KeyValuePair<string, string>> items = new List<KeyValuePair<string, string>>();

            // Перебираем колонки DataGridView
            for (int columnIndex = 5; columnIndex < dataGridView1.Columns.Count; columnIndex++)
            {
                // Получаем колонку
                DataGridViewColumn column = dataGridView1.Columns[columnIndex];

                // Добавляем пару ключ-значение в список
                items.Add(new KeyValuePair<string, string>(column.DataPropertyName, column.HeaderText));

            }
            comboBox1.DataSource = new BindingSource(items, null);
            comboBox1.DisplayMember = "Value"; // Отображаемый текст
            comboBox1.ValueMember = "Key"; // Значение
        }

        public void Table()
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "test_table";
            authApi.uriCreate();

            var Stream = authApi.ServerAuthorization();

            var info = JsonHelpers.ReadFromJsonStream<string>(Stream);
            dataGridView1.DataSource = JsonConvert.DeserializeObject(info, typeof(DataTable)) as DataTable;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
            // Получаем выбранное значение из comboBox1
            string selectedColumnName = comboBox1.SelectedValue.ToString();
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
            comboBox2.DataSource = new BindingSource(uniqueValues.ToList(), null);
            comboBox2.Text = "";
            comboBox2_SelectedIndexChanged(sender, e);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filteredText = comboBox2.Text.Replace("'", "''");
            try
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"{comboBox1.SelectedValue} LIKE '%{filteredText}%'";
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("theme_name LIKE '%{0}%' OR subject_name LIKE '%{0}%' OR test_name LIKE '%{0}%' OR test_type LIKE '%{0}%' OR attempt_count LIKE '%{0}%' OR execution_time LIKE '%{0}%' OR class_name LIKE '%{0}%'OR creation_date LIKE '%{0}%'OR full_name LIKE '%{0}%'", textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox2.DataSource = null;
            textBox1.Text = "";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
        }
    }
}
