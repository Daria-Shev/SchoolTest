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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolTest.ProgramForms.Teacher
{
    public partial class add_literature_show : Form
    {
        object data;
        string id;
        public add_literature_show(object data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            add_literature form1Instance = Application.OpenForms.OfType<add_literature>().FirstOrDefault();
            if (form1Instance != null)
            {
                form1Instance.Table();
            }
            this.Close();
        }

        private void add_literature_show_FormClosed(object sender, FormClosedEventArgs e)
        {
            buttonBack_Click(sender, e);    
        }

        private void add_literature_show_Load(object sender, EventArgs e)
        {
            var dataTable = (dynamic)data;
            literature_nameTextBox.Text = dataTable.literature_name;
            literature_linkTextBox.Text = dataTable.literature_link;

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


            id = dataTable.literature_id;
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

        private void comboBox_subject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            combo_box_query(comboBox_subject.SelectedValue.ToString());
        }
        private void combo_box_query(string id_subject)
        {
            DataTable dataTable = (comboBox_theme.DataSource as DataTable);
            dataTable.DefaultView.RowFilter = $"subject_id = '{id_subject}'";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "lit_add";

            var classObject = new
            {
                literature_id = id,
                literature_name = literature_nameTextBox.Text,
                literature_link = literature_linkTextBox.Text,
                theme_id = comboBox_theme.SelectedValue,

            };
            var json = JsonConvert.SerializeObject(classObject);



            // старий варіант
            authApi.query.Add("jsonData", json);
            //authApi.query.Add("subject_name", class_name);
            //authApi.query.Add("subject_class_number", class_number);

            authApi.uriCreate();


            var Stream = authApi.ServerAuthorization();

            MessageString message = new MessageString();
            message = JsonHelpers.ReadFromJsonStream<MessageString>(Stream);

            Message.MessageInfo(message.message);
        }
    }
}
