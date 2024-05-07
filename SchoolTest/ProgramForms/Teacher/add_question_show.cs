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

            combo_box_type();
            comboBox_type.SelectedIndex = 0;
            var itemToSelect3 = comboBox_type.Items.Cast<type_item>().FirstOrDefault(item => item.Value == dataTable.response_type);

            // Если такой элемент найден, выбираем его
            if (itemToSelect3 != null)
            {
                comboBox_type.SelectedItem = itemToSelect;
            }



            Table();
            id = dataTable.literature_id;
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
            foreach (var item in items)
            {
                comboBox_type.Items.Add(item);
            }
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
            if (comboBox_type.Text.StartsWith("Відкрита відповідь"))
            {
                panel_sequence.Visible = false;
                panel_answer_options.Visible = false;
                panel_matching.Visible = false;
                panel_open_response.Visible = true;
            }
            if (comboBox_type.Text.StartsWith("Послідовність"))
            {
                panel_sequence.Visible = true;
                panel_answer_options.Visible = false;
                panel_matching.Visible = false;
                panel_open_response.Visible = false;
            }
            if (comboBox_type.Text.StartsWith("Відповідність"))
            {
                panel_sequence.Visible = false;
                panel_answer_options.Visible = false;
                panel_matching.Visible = true;
                panel_open_response.Visible = false;
            }
            if (comboBox_type.Text.StartsWith("Варіанти відповідей"))
            {
                panel_sequence.Visible = false;
                panel_answer_options.Visible = true;
                panel_matching.Visible = false;
                panel_open_response.Visible = false;
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
    }
}
