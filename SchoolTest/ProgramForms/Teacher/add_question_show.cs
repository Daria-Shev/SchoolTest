using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class add_question_show : Form
    {

        object data;
        string id;
        public add_question_show(object data)
        {
            InitializeComponent();
            this.data = data;
        }


        private void add_question_show_Load(object sender, EventArgs e)
        {
            var dataTable = (dynamic)data;
            question_textTextBox.Text = dataTable.question_text;
            pointsTextBox.Text = dataTable.points;
            id = dataTable.question_id;
            Table();

            combo_box_subject();
            // Находим соответствующий элемент в списке ComboBox по заданному значению
            var itemToSelect = comboBox_subject.Items.Cast<DataRowView>().FirstOrDefault(item => item["subject_id"].ToString() == dataTable.subject_id);

            // Если такой элемент найден, выбираем его
            if (itemToSelect != null)
            {
                comboBox_subject.SelectedItem = itemToSelect;
            }
            combo_box_theme();
            combo_box_query(comboBox_subject.SelectedValue.ToString());
            var itemToSelect2 = comboBox_theme.Items.Cast<DataRowView>().FirstOrDefault(item => item["theme_id"].ToString() == dataTable.theme_id);

            // Если такой элемент найден, выбираем его
            if (itemToSelect2 != null)
            {
                comboBox_theme.SelectedItem = itemToSelect2;
            }
            comboBox_type.SelectedIndex = 0;
            combo_box_type();
            if (dataTable.response_type== "open_response")
            {
                comboBox_type.SelectedIndex = 2;
            }
            if (dataTable.response_type == "answer_options")
            {
                comboBox_type.SelectedIndex = 3;
            }
            if (dataTable.response_type == "sequence")
            {
                comboBox_type.SelectedIndex = 0;
            }
            if (dataTable.response_type == "matching")
            {
                comboBox_type.SelectedIndex = 1;
            }
            //var itemToSelect3 = comboBox_type.Items.Cast<type_item>().FirstOrDefault(item => item.Value == dataTable.response_type);

            //// Если такой элемент найден, выбираем его
            //if (itemToSelect3 != null)
            //{
            //    comboBox_type.SelectedItem = itemToSelect;
            //}
            //////var targetItem = comboBox_type.Items.Cast<type_item>().FirstOrDefault(item => item.Value == dataTable.response_type);

            //// Если найден элемент с заданным значением Value, выбрать его
            //if (targetItem != null)
            //{
            //    comboBox_type.SelectedItem = targetItem;
            //}    

        }
        public void Table()
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "open_response_table";
            authApi.uriCreate();
            var Stream = authApi.ServerAuthorization();
            var info = JsonHelpers.ReadFromJsonStream<string>(Stream);
            dataGridView_open_response.DataSource = JsonConvert.DeserializeObject(info, typeof(DataTable)) as DataTable;

            authApi.path = "answer_options_table";
            authApi.uriCreate();
            Stream = authApi.ServerAuthorization();
            info = JsonHelpers.ReadFromJsonStream<string>(Stream);
            dataGridView_answer_options.DataSource = JsonConvert.DeserializeObject(info, typeof(DataTable)) as DataTable;

            authApi.path = "sequence_table";
            authApi.uriCreate();
            Stream = authApi.ServerAuthorization();
            info = JsonHelpers.ReadFromJsonStream<string>(Stream);
            dataGridView_sequence.DataSource = JsonConvert.DeserializeObject(info, typeof(DataTable)) as DataTable;

            authApi.path = "matching_table";
            authApi.uriCreate();
            Stream = authApi.ServerAuthorization();
            info = JsonHelpers.ReadFromJsonStream<string>(Stream);
            dataGridView_matching.DataSource = JsonConvert.DeserializeObject(info, typeof(DataTable)) as DataTable;
        }
        private void combo_box_type()
        {
            List<type_item> items = new List<type_item>();
            items.Add(new type_item("Відкрита відповідь", "open_response"));
            items.Add(new type_item("Варіанти відповідей", "answer_options"));
            items.Add(new type_item("Послідовність", "sequence"));
            items.Add(new type_item("Відповідність", "matching"));


            // Установка свойств DisplayMember и ValueMember для ComboBox
            comboBox_type.DisplayMember = "Display";
            comboBox_type.ValueMember = "Value";
            //foreach (var item in items)
            //{
            //    comboBox_type.Items.Add(item);
            //}
        }

        private void combo_box_subject()
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "subject_list";
            authApi.uriCreate();

            var Stream = authApi.ServerAuthorization();

            var info = JsonHelpers.ReadFromJsonStream<string>(Stream);
            DataTable dataTable = JsonConvert.DeserializeObject(info, typeof(DataTable)) as DataTable;

            // Привязываем dataTable к comboBox1
            comboBox_subject.DataSource = dataTable;
            comboBox_subject.DisplayMember = "subject_name"; // Отображаем столбец subject_name
            comboBox_subject.ValueMember = "subject_id"; // Используем значения столбца subject_id как значения элементов comboBox1
        }
        private void combo_box_theme()
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "theme_list";
            authApi.uriCreate();

            var Stream = authApi.ServerAuthorization();

            var info = JsonHelpers.ReadFromJsonStream<string>(Stream);
            DataTable dataTable = JsonConvert.DeserializeObject(info, typeof(DataTable)) as DataTable;

            // Привязываем dataTable к comboBox1
            comboBox_theme.DataSource = dataTable;
            comboBox_theme.DisplayMember = "theme_name"; // Отображаем столбец subject_name
            comboBox_theme.ValueMember = "theme_id"; // Используем значения столбца subject_id как значения элементов comboBox1
            // Находим соответствующий элемент в списке ComboBox по заданному значению
        }

        private void comboBox_type_TextChanged(object sender, EventArgs e)
        {
            user_account_visibility();

        }
        private void user_account_visibility()
        {
            long idValue = Convert.ToInt64(id);

            if (comboBox_type.Text.StartsWith("Відкрита відповідь"))
            {
                panel_sequence.Visible = false;
                panel_answer_options.Visible = false;
                panel_matching.Visible = false;
                panel_open_response.Visible = true;
                // Убедитесь, что dataGridView_open_response.DataSource не равен null
                if (dataGridView_open_response.DataSource != null && dataGridView_open_response.DataSource is DataTable )
                {
                    (dataGridView_open_response.DataSource as DataTable).DefaultView.RowFilter = string.Format("question_id = {0}", idValue);
                }
            }
            if (comboBox_type.Text.StartsWith("Послідовність"))
            {
                panel_sequence.Visible = true;
                panel_answer_options.Visible = false;
                panel_matching.Visible = false;
                panel_open_response.Visible = false;
                if (dataGridView_sequence.DataSource != null && dataGridView_sequence.DataSource is DataTable )
                {
                    (dataGridView_sequence.DataSource as DataTable).DefaultView.RowFilter = string.Format("question_id = {0}", idValue);
                }
            }
            if (comboBox_type.Text.StartsWith("Відповідність"))
            {
                panel_sequence.Visible = false;
                panel_answer_options.Visible = false;
                panel_matching.Visible = true;
                panel_open_response.Visible = false;
                // :(
                if (dataGridView_matching.DataSource != null && dataGridView_matching.DataSource is DataTable )
                {
                    (dataGridView_matching.DataSource as DataTable).DefaultView.RowFilter = string.Format("question_id = {0}", idValue);
                }
            }
            if (comboBox_type.Text.StartsWith("Варіанти відповідей"))
            {
                panel_sequence.Visible = false;
                panel_answer_options.Visible = true;
                panel_matching.Visible = false;
                panel_open_response.Visible = false;
                if (dataGridView_answer_options.DataSource != null && dataGridView_answer_options.DataSource is DataTable )
                {
                    (dataGridView_answer_options.DataSource as DataTable).DefaultView.RowFilter = string.Format("question_id = {0}", idValue);
                }
            }
        }

        private void comboBox_subject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            combo_box_query(comboBox_subject.SelectedValue.ToString());
        }
        private void combo_box_query(string id_subject)
        {
            DataTable dataTable = (comboBox_theme.DataSource as DataTable);
            dataTable.DefaultView.RowFilter = $"subject_id = '{id_subject}'";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            add_question form1Instance = Application.OpenForms.OfType<add_question>().FirstOrDefault();
            if (form1Instance != null)
            {
                form1Instance.Table();
            }
            this.Close();
        }

        private void add_question_show_FormClosed(object sender, FormClosedEventArgs e)
        {
            buttonBack_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string response_id = "0";
            string question_id = id;

            if (comboBox_type.Text.StartsWith("Відкрита відповідь"))
            {
                string correct_response = "";
                string response_type = "open_response";
                var data = new { question_id, response_id, correct_response, response_type };
                Form ifrm = new add_open_response(data);
                ifrm.ShowDialog();
            }
            if (comboBox_type.Text.StartsWith("Послідовність"))
            {
                string sequence_number = "";
                string sequence_text = "";
                string response_type = "sequence";
                var data = new { question_id, sequence_number, response_id, sequence_text, response_type };
                Form ifrm = new add_sequence(data);
                ifrm.ShowDialog();
            }
            if (comboBox_type.Text.StartsWith("Відповідність"))
            {
                string matching_number = "";
                string option_text = "";
                string matching_text = "";
                string response_type = "matching";
                var data = new { question_id, response_id, option_text, matching_number, matching_text, response_type };
                Form ifrm = new add_matching(data);
                ifrm.ShowDialog();
            }
            if (comboBox_type.Text.StartsWith("Варіанти відповідей"))
            {
                string option_number = "";
                string correct_option = "";
                string option_text = "";
                string response_type = "answer_options";
                var data = new { question_id, response_id, option_number, correct_option, option_text, response_type };
                Form ifrm = new add_answer_options(data);
                ifrm.ShowDialog();
            }
        }

        private void dataGridView_matching_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_matching.SelectedRows.Count != 1)
            {
                return;
            }
            string response_id = "0";
            string question_id = id;
            string matching_number = "";
            string option_text = "";
            string matching_text = "";
            string response_type = "matching";
            if (dataGridView_matching.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_matching.SelectedRows[0];
                response_id = selectedRow.Cells["response_id"].Value.ToString();
                matching_number = selectedRow.Cells["matching_number"].Value.ToString();
                option_text = selectedRow.Cells["option_text"].Value.ToString();
                matching_text = selectedRow.Cells["matching_text"].Value.ToString();
            }
            var data = new { question_id, response_id, option_text, matching_number, matching_text, response_type };
            Form ifrm = new add_matching(data);
            ifrm.ShowDialog();
        }

        private void dataGridView_answer_options_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_answer_options.SelectedRows.Count != 1)
            {
                return;
            }
            string response_id = "0";
            string question_id = id;
            string option_number = "";
            string correct_option = "";
            string option_text = "";
            string response_type = "answer_options";
            if (dataGridView_answer_options.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_answer_options.SelectedRows[0];
                response_id = selectedRow.Cells["response_id"].Value.ToString();
                option_number = selectedRow.Cells["option_number"].Value.ToString();
                option_text = selectedRow.Cells["option_text"].Value.ToString();
                correct_option = selectedRow.Cells["correct_option"].Value.ToString();
            }
            var data = new { question_id, response_id, option_number, correct_option, option_text, response_type };
            Form ifrm = new add_answer_options(data);
            ifrm.ShowDialog();
        }

        private void dataGridView_open_response_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_open_response.SelectedRows.Count != 1)
            {
                return;
            }
            string response_id = "0";
            string question_id = id;
            string correct_response = "";
            string response_type = "open_response";

            if (dataGridView_open_response.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_open_response.SelectedRows[0];
                response_id = selectedRow.Cells["response_id"].Value.ToString();
                correct_response = selectedRow.Cells["correct_response"].Value.ToString();
            }
            var data = new { question_id, response_id, correct_response, response_type };
            Form ifrm = new add_open_response(data);
            ifrm.ShowDialog();
        }

        private void dataGridView_sequence_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_sequence.SelectedRows.Count != 1)
            {
                return;
            }
            string response_id = "0";
            string question_id = id;
            string sequence_number = "";
            string sequence_text = "";
            string response_type = "sequence";

            if (dataGridView_sequence.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView_sequence.SelectedRows[0];
                response_id = selectedRow.Cells["response_id"].Value.ToString();
                sequence_number = selectedRow.Cells["sequence_number"].Value.ToString();
                sequence_text = selectedRow.Cells["sequence_text"].Value.ToString();
            }
            var data = new { question_id, sequence_number, response_id, sequence_text, response_type };
            Form ifrm = new add_sequence(data);
            ifrm.ShowDialog();
        }
    }
}
