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
    public partial class add_test_show : Form
    {
        object data;
        string id, data_time, teacher;
        public add_test_show(object data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            add_test form1Instance = Application.OpenForms.OfType<add_test>().FirstOrDefault();
            if (form1Instance != null)
            {
                form1Instance.Table();
            }
            this.Close();
        }

        private void add_test_show_FormClosed(object sender, FormClosedEventArgs e)
        {
            buttonBack_Click(sender, e);
        }

        private void add_test_show_Load(object sender, EventArgs e)
        {
            var dataTable = (dynamic)data;
            test_nameTextBox.Text = dataTable.test_name;
            comboBox_type.Text = dataTable.test_type;
            execution_timeTextBox.Text = dataTable.execution_time;
            attempt_countTextBox.Text = dataTable.attempt_count;

            combo_box_subject();
            var itemToSelect = comboBox_subject.Items.Cast<DataRowView>().FirstOrDefault(item => item["subject_id"].ToString() == dataTable.subject_id);

            if (itemToSelect != null)
            {
                comboBox_subject.SelectedItem = itemToSelect;
            }
            combo_box_class();

            combo_box_theme();
            combo_box_query(comboBox_subject.SelectedValue.ToString());
            var itemToSelect2 = comboBox_theme.Items.Cast<DataRowView>().FirstOrDefault(item => item["theme_id"].ToString() == dataTable.theme_id);
            if (itemToSelect2 != null)
            {
                comboBox_theme.SelectedItem = itemToSelect2;
            }
            var itemToSelect3 = comboBox_class.Items.Cast<DataRowView>().FirstOrDefault(item => item["class_id"].ToString() == dataTable.class_id);
            if (itemToSelect3 != null)
            {
                comboBox_class.SelectedItem = itemToSelect3;
            }


            id = dataTable.test_id;
        }
        private void combo_box_class()
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "class_list";
            authApi.uriCreate();

            var Stream = authApi.ServerAuthorization();

            var info = JsonHelpers.ReadFromJsonStream<string>(Stream);
            DataTable dataTable = JsonConvert.DeserializeObject(info, typeof(DataTable)) as DataTable;

            // Привязываем dataTable к comboBox1
            comboBox_class.DataSource = dataTable;
            comboBox_class.DisplayMember = "class_name"; // Отображаем столбец subject_name
            comboBox_class.ValueMember = "class_id"; // Используем значения столбца subject_id как значения элементов comboBox1
        }
        private void combo_box_query(string id_subject)
        {
            DataTable dataTable = (comboBox_theme.DataSource as DataTable);
            dataTable.DefaultView.RowFilter = $"subject_id = '{id_subject}'";
        }

        private void comboBox_subject_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_type.Text.StartsWith("Підсумковий"))
            {
                label2.Visible = false;
                comboBox_theme.Visible = false;
                comboBox_theme.Text = "";
            }
            else
            {
                label2.Visible = true;
                comboBox_theme.Visible = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ApiClass authApi = new ApiClass();
            authApi.path = "test_add";
            
            data_time= DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            teacher=User.nickname;

            var classObject = new
            {
                test_id = id,
                test_name = test_nameTextBox.Text,
                execution_time = execution_timeTextBox.Text,
                attempt_count = attempt_countTextBox.Text,
                test_type = comboBox_type.Text,
                user_nickname = teacher,
                creation_date = data_time,
                theme_id = comboBox_theme.SelectedValue,

            };
            var json = JsonConvert.SerializeObject(classObject);
            authApi.query.Add("jsonData", json);
            authApi.uriCreate();
            var Stream = authApi.ServerAuthorization();

            MessageString message = new MessageString();
            message = JsonHelpers.ReadFromJsonStream<MessageString>(Stream);

            Message.MessageInfo(message.message);
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

    }
}
