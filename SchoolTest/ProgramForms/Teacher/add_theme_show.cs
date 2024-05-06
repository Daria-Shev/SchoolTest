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
    public partial class add_theme_show : Form
    {
        object data;
        string id;
        public add_theme_show(object data)
        {
            InitializeComponent();
            this.data = data;
        }
        private void add_theme_show_Load(object sender, EventArgs e)
        {
            var dataTable = (dynamic)data;
            theme_nameTextBox.Text = dataTable.theme_name;

            combo_box_data();
            // Находим соответствующий элемент в списке ComboBox по заданному значению
            var itemToSelect = comboBox1.Items.Cast<DataRowView>().FirstOrDefault(item => item["subject_id"].ToString() == dataTable.subject_id);

            // Если такой элемент найден, выбираем его
            if (itemToSelect != null)
            {
                comboBox1.SelectedItem = itemToSelect;
            }

            //????

            //comboBox1.Text = dataTable.subject_name;
            id = dataTable.theme_id;
        }
        private void combo_box_data()
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "subject_list";
            authApi.uriCreate();

            var Stream = authApi.ServerAuthorization();

            var info = JsonHelpers.ReadFromJsonStream<string>(Stream);
            DataTable dataTable = JsonConvert.DeserializeObject(info, typeof(DataTable)) as DataTable;

            // Привязываем dataTable к comboBox1
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "subject_name"; // Отображаем столбец subject_name
            comboBox1.ValueMember = "subject_id"; // Используем значения столбца subject_id как значения элементов comboBox1
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            add_theme form1Instance = Application.OpenForms.OfType<add_theme>().FirstOrDefault();
            if (form1Instance != null)
            {
                form1Instance.Table();
            }
            this.Close();
        }

        private void add_theme_show_FormClosed(object sender, FormClosedEventArgs e)
        {
            buttonBack_Click(sender, e);    
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            server_add();
        }
        private void server_add()
        {
            //string class_name = class_nameTextBox.Text;
            //string class_number = class_numberTextBox.Text;
            ApiClass authApi = new ApiClass();

            authApi.path = "theme_add";

            var classObject = new
            {
                theme_id = id,
                theme_name = theme_nameTextBox.Text,
                subject_id = comboBox1.SelectedValue
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
