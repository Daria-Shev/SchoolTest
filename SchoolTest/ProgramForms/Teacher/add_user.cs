using Newtonsoft.Json;
using SchoolTest.Helpers;
using SchoolTest.Info;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolTest.ProgramForms.Teacher
{
    public partial class add_user : Form
    {
        public add_user()
        {
            InitializeComponent();
        }

        private void add_user_Load(object sender, EventArgs e)
        {
            Table();
            combo_Load();
            comboBox1.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form ifrm = new addData();
            ifrm.Show();
            this.Close();
        }

        public void Table()
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "user_table_teacher";
            authApi.uriCreate();

            var Stream = authApi.ServerAuthorization();

            var info = JsonHelpers.ReadFromJsonStream<string>(Stream);
            dataGridView_teacher.DataSource = JsonConvert.DeserializeObject(info, typeof(DataTable)) as DataTable;
            

            authApi.path = "user_table_student";
            authApi.uriCreate();

            Stream = authApi.ServerAuthorization();

            info = JsonHelpers.ReadFromJsonStream<string>(Stream);
            dataGridView_student.DataSource = JsonConvert.DeserializeObject(info, typeof(DataTable)) as DataTable;
        }

        private void combo_Load()
        {
            List<KeyValuePair<string, string>> items = new List<KeyValuePair<string, string>>();
            if (tabControl1.SelectedTab.Name == "tabPageTeacher")
            {
                for (int columnIndex = 2; columnIndex < dataGridView_teacher.Columns.Count; columnIndex++)
                {
                    // Получаем колонку
                    DataGridViewColumn column = dataGridView_teacher.Columns[columnIndex];

                    // Добавляем пару ключ-значение в список
                    items.Add(new KeyValuePair<string, string>(column.DataPropertyName, column.HeaderText));
                }
            }
            else
            {
                for (int columnIndex = 3; columnIndex < dataGridView_student.Columns.Count; columnIndex++)
                {
                    // Получаем колонку
                    DataGridViewColumn column = dataGridView_student.Columns[columnIndex];

                    // Добавляем пару ключ-значение в список
                    items.Add(new KeyValuePair<string, string>(column.DataPropertyName, column.HeaderText));
                }
            }
            // Перебираем колонки DataGridView
            comboBox1.DataSource = new BindingSource(items, null);
            comboBox1.DisplayMember = "Value"; // Отображаемый текст
            comboBox1.ValueMember = "Key"; // Значение
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabPageTeacher")
            {
                (dataGridView_teacher.DataSource as DataTable).DefaultView.RowFilter = string.Format("nickname LIKE '%{0}%' OR password LIKE '%{0}%' OR full_name LIKE '%{0}%' OR email_address LIKE '%{0}%'", textBox1.Text);
            }
            else
            {
                (dataGridView_student.DataSource as DataTable).DefaultView.RowFilter = string.Format("nickname LIKE '%{0}%' OR password LIKE '%{0}%' OR full_name LIKE '%{0}%' OR student_email LIKE '%{0}%' OR parent_email LIKE '%{0}%' OR class_name LIKE '%{0}%'", textBox1.Text);
            }

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedColumnName = comboBox1.SelectedValue.ToString();
            (dataGridView_teacher.DataSource as DataTable).DefaultView.RowFilter = "";
            (dataGridView_student.DataSource as DataTable).DefaultView.RowFilter = "";
            HashSet<string> uniqueValues = new HashSet<string>();


            if (tabControl1.SelectedTab.Name == "tabPageTeacher")
            {
                selectedColumnName += "_teacher";
                foreach (DataGridViewRow row in dataGridView_teacher.Rows)
                {
                    // Получаем значение ячейки из выбранной колонки
                    string cellValue = row.Cells[selectedColumnName].Value?.ToString();
                    // Добавляем значение в HashSet, если оно не пустое
                    if (!string.IsNullOrEmpty(cellValue))
                    {
                        uniqueValues.Add(cellValue);
                    }
                }
            }
            else
            {
                selectedColumnName += "_student";
                foreach (DataGridViewRow row in dataGridView_student.Rows)
                {
                    // Получаем значение ячейки из выбранной колонки
                    string cellValue = row.Cells[selectedColumnName].Value?.ToString();
                    // Добавляем значение в HashSet, если оно не пустое
                    if (!string.IsNullOrEmpty(cellValue))
                    {
                        uniqueValues.Add(cellValue);
                    }
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
                if (tabControl1.SelectedTab.Name == "tabPageTeacher")
                {
                    (dataGridView_teacher.DataSource as DataTable).DefaultView.RowFilter = $"{comboBox1.SelectedValue} LIKE '%{filteredText}%'";
                }
                else
                {
                    (dataGridView_student.DataSource as DataTable).DefaultView.RowFilter = $"{comboBox1.SelectedValue} LIKE '%{filteredText}%'";
                }
            }
            catch { }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_Load();
            comboBox1.Text = "";
            comboBox2.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox2.DataSource = null;
            textBox1.Text = "";
            (dataGridView_teacher.DataSource as DataTable).DefaultView.RowFilter = "";
            (dataGridView_student.DataSource as DataTable).DefaultView.RowFilter = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string id = "0";
            if (tabControl1.SelectedTab.Name == "tabPageTeacher")
            {
                if (dataGridView_teacher.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView_teacher.SelectedRows[0];
                    id = selectedRow.Cells["user_account_id_teacher"].Value.ToString();
                }
            }
            else
            {
                if (dataGridView_student.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView_student.SelectedRows[0];
                    id = selectedRow.Cells["user_account_id_student"].Value.ToString();
                }
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
            authApi.path = "user_delete";
            authApi.query.Add("user_id", id);
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string user_account_id = "0";
            string nickname = "";
            string password = "";
            string user_account_type = "";
            string full_name = "";
            var data = new object();
            if (tabControl1.SelectedTab.Name == "tabPageTeacher")
            {
                user_account_type = "teacher";
                string email_address = "";
                data = new { user_account_id, nickname, password, user_account_type, full_name, email_address };

            }
            else
            {
                user_account_type = "student";
                string student_email = "";
                string parent_email = "";
                string class_id = "0";
                data = new { user_account_id, nickname, password, user_account_type, full_name, student_email, parent_email, class_id };
            }
            Form ifrm = new add_user_show(data);
            ifrm.ShowDialog();
        }

        private void dataGridView_teacher_DoubleClick(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabPageTeacher" && dataGridView_teacher.SelectedRows.Count != 1)
            {
                return;
            }
            var data = data_dedicated();

            Form ifrm = new add_user_show(data);
            ifrm.ShowDialog();
        }

        private void dataGridView_student_DoubleClick(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabPageStudent" && dataGridView_student.SelectedRows.Count != 1)
            {
                return;
            }
            var data = data_dedicated();

            Form ifrm = new add_user_show(data);
            ifrm.ShowDialog();
        }
        private object data_dedicated()
        {
            var data = new object();
            string user_account_id = "0";
            string nickname = "";
            string password = "";
            string user_account_type = "";
            string full_name = "";
            string student_email = "";
            string parent_email = "";
            string class_id = "0";
            string email_address = "";
            DataGridViewRow selectedRow=null;

            if (tabControl1.SelectedTab.Name == "tabPageTeacher" && dataGridView_teacher.SelectedRows.Count > 0)
            {
                selectedRow = dataGridView_teacher.SelectedRows[0];
                user_account_id = selectedRow.Cells["user_account_id_teacher"].Value.ToString();
                nickname = selectedRow.Cells["nickname_teacher"].Value.ToString();
                password = selectedRow.Cells["password_teacher"].Value.ToString();
                user_account_type = selectedRow.Cells["user_account_type_teacher"].Value.ToString();
                full_name = selectedRow.Cells["full_name_teacher"].Value.ToString();
                email_address = selectedRow.Cells["email_address_teacher"].Value.ToString();
                data = new { user_account_id, nickname, password, user_account_type, full_name, email_address };

            }
            if (tabControl1.SelectedTab.Name == "tabPageStudent" && dataGridView_student.SelectedRows.Count > 0)
            {
                selectedRow = dataGridView_student.SelectedRows[0];
                user_account_id = selectedRow.Cells["user_account_id_student"].Value.ToString();
                nickname = selectedRow.Cells["nickname_student"].Value.ToString();
                password = selectedRow.Cells["password_student"].Value.ToString();
                user_account_type = selectedRow.Cells["user_account_type_student"].Value.ToString();
                full_name = selectedRow.Cells["full_name_student"].Value.ToString();
                student_email = selectedRow.Cells["student_email_student"].Value.ToString();
                parent_email = selectedRow.Cells["parent_email_student"].Value.ToString();
                class_id = selectedRow.Cells["class_id"].Value.ToString();
                data = new { user_account_id, nickname, password, user_account_type, full_name, student_email, parent_email, class_id };
            }
            return data;
        }

        private void tabPageTeacher_Click(object sender, EventArgs e)
        {

        }
    }
}
