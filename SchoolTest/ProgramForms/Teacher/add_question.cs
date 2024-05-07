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
    public partial class add_question : Form
    {
        public add_question()
        {
            InitializeComponent();
        }

        private void add_question_Load(object sender, EventArgs e)
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

            authApi.path = "question_table";
            authApi.uriCreate();

            var Stream = authApi.ServerAuthorization();

            var info = JsonHelpers.ReadFromJsonStream<string>(Stream);
            dataGridView1.DataSource = JsonConvert.DeserializeObject(info, typeof(DataTable)) as DataTable;
        }
        public void TableType()
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "question_table";
            authApi.uriCreate();

            var Stream = authApi.ServerAuthorization();

            var info = JsonHelpers.ReadFromJsonStream<string>(Stream);
            dataGridView1.DataSource = JsonConvert.DeserializeObject(info, typeof(DataTable)) as DataTable;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form ifrm = new addData();
            ifrm.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("theme_name LIKE '%{0}%' OR subject_name LIKE '%{0}%' OR question_text LIKE '%{0}%' OR response_type_ukr LIKE '%{0}%'", textBox1.Text);
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
                id = selectedRow.Cells["question_id"].Value.ToString();
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

            authApi.path = "question_delete";
            authApi.query.Add("question_id", id);
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

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
        //    foreach (DataGridViewRow row in dataGridView1.Rows)
        //    {
        //        string response = row.Cells["response_type"].Value?.ToString();
        //        if (response != null)
        //        {
        //            switch (response)
        //            {
        //                case "open_response":
        //                    row.Cells["response_type_ukr"].Value = "Відкрита відповідь";
        //                    break;
        //                case "answer_options":
        //                    row.Cells["response_type_ukr"].Value = "Варіанти відповідей";
        //                    break;
        //                case "sequence":
        //                    row.Cells["response_type_ukr"].Value = "Послідовність";
        //                    break;
        //                case "matching":
        //                    row.Cells["response_type_ukr"].Value = "Відповідність";
        //                    break;
        //                default:
        //                    // Если значение не соответствует ни одному известному варианту, оставляем его без изменений
        //                    break;
        //            }
        //        }
        //    }
        //    // Находим индекс колонки
        //    int columnIndex = dataGridView1.Columns["response_type_ukr"].Index;

        //    // Перемещаем колонку в конец списка колонок
        //    dataGridView1.Columns[columnIndex].DisplayIndex = dataGridView1.Columns.Count - 1;
        }
    }
}
