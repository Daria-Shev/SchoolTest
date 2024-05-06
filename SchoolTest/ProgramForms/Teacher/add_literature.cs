using Newtonsoft.Json;
using SchoolTest.Helpers;
using SchoolTest.Info;
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
    public partial class add_literature : Form
    {
        public add_literature()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form ifrm = new addData();
            ifrm.Show();
            this.Close();
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
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("theme_name LIKE '%{0}%' OR subject_name LIKE '%{0}%' OR literature_name LIKE '%{0}%' OR literature_link LIKE '%{0}%'", textBox1.Text);
        }

        private void add_literature_Load(object sender, EventArgs e)
        {
            Table();
            combo_Load();
            comboBox1.Text = "";

        }

        private void combo_Load()
        {
            List<KeyValuePair<string, string>> items = new List<KeyValuePair<string, string>>();

            // Перебираем колонки DataGridView
            for (int columnIndex = 3; columnIndex < dataGridView1.Columns.Count; columnIndex++)
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

            authApi.path = "lit_table";
            authApi.uriCreate();

            var Stream = authApi.ServerAuthorization();

            var info = JsonHelpers.ReadFromJsonStream<string>(Stream);
            dataGridView1.DataSource = JsonConvert.DeserializeObject(info, typeof(DataTable)) as DataTable;
        }
        private object data_dedicated()
        {
            string literature_id = "0";
            string theme_id = "0";
            string subject_id = "0";
            string literature_name = "";
            string literature_link = "";
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                literature_id = selectedRow.Cells["literature_id"].Value.ToString();
                theme_id = selectedRow.Cells["theme_id"].Value.ToString();
                subject_id = selectedRow.Cells["subject_id"].Value.ToString();
                literature_name = selectedRow.Cells["literature_name"].Value.ToString();
                literature_link = selectedRow.Cells["literature_link"].Value.ToString();

            }
            var data = new { literature_id, theme_id, subject_id, literature_name, literature_link };
            return data;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string literature_id = "0";
            string theme_id = "0";
            string subject_id = "0";
            string literature_name = "";
            string literature_link = "";
            var data = new { literature_id, theme_id, subject_id, literature_name, literature_link };
            Form ifrm = new add_literature_show(data);
            ifrm.ShowDialog();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                return;
            }
            var data = data_dedicated();

            Form ifrm = new add_literature_show(data);
            ifrm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox2.DataSource = null;
            textBox1.Text = "";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string id = "0";
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                id = selectedRow.Cells["literature_id"].Value.ToString();
            }
            if (check_id(id))
            {
                return;
            }
            Delete_date(id);
            Table();
        }
        private void Delete_date(string id)
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "lit_delete";
            authApi.query.Add("literature_id", id);
            authApi.uriCreate();
            var Stream = authApi.ServerAuthorization();
            MessageString message = new MessageString();
            message = JsonHelpers.ReadFromJsonStream<MessageString>(Stream);
            Message.MessageInfo(message.message);
        }
        private bool check_id(string id)
        {
            if (id == "0")
            {
                Message.MessageInfo("Ви не обрали запис");
                return true;
            }
            return false;

        }
    }
}
