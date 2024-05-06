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
    public partial class add_user_show : Form
    {
        object data;
        string id;
        public add_user_show(object data)
        {
            InitializeComponent();
            this.data = data;
        }



        private void add_user_show_FormClosed(object sender, FormClosedEventArgs e)
        {
            buttonBack_Click(sender, e);
        }

        private void add_user_show_Load(object sender, EventArgs e)
        {
            var dataTable = (dynamic)data;
            nicknameTextBox.Text = dataTable.nickname;
            passwordTextBox.Text = dataTable.password;
            full_nameTextBox.Text = dataTable.full_name;


            combo_box_type();
            comboBox_type.SelectedIndex = 0;
            combo_box_class();


            //// Находим соответствующий элемент в списке ComboBox по заданному значению
            //var itemToSelect = comboBox_type.Items.Cast<DataRowView>().FirstOrDefault(item => item["Value"].ToString() == dataTable.user_account_type);
            var itemToSelect = comboBox_type.Items.Cast<type_item>().FirstOrDefault(item => item.Value == dataTable.user_account_type);

            // Если такой элемент найден, выбираем его
            if (itemToSelect != null)
            {
                comboBox_type.SelectedItem = itemToSelect;
            }
            if (dataTable.user_account_type.StartsWith("teacher"))
            {
                panelTeacher.Visible = true;
                panelStudent.Visible = false;
                email_addressTextBox.Text = dataTable.email_address;
            }
            else
            {
                panelStudent.Visible = true;
                panelTeacher.Visible = false;
                student_emailTextBox.Text= dataTable.student_email;
                parent_emailTextBox.Text= dataTable.parent_email;
                var itemToSelect2 = comboBox_class.Items.Cast<DataRowView>().FirstOrDefault(item => item["class_id"].ToString() == dataTable.class_id);
                if (itemToSelect2 != null)
                {
                    comboBox_class.SelectedItem = itemToSelect2;
                }
            }       
            id = dataTable.user_account_id;
        }
        private void combo_box_type()
        {
            List<type_item> items = new List<type_item>();
            items.Add(new type_item("Вчитель", "teacher"));
            items.Add(new type_item("Учень", "student"));

            // Установка свойств DisplayMember и ValueMember для ComboBox
            comboBox_type.DisplayMember = "Display";
            comboBox_type.ValueMember = "Value";
            foreach (var item in items)
            {
                comboBox_type.Items.Add(item);
            }
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            add_user form1Instance = Application.OpenForms.OfType<add_user>().FirstOrDefault();
            if (form1Instance != null)
            {
                form1Instance.Table();
            }
            this.Close();
        }

        private void comboBox_type_TextChanged(object sender, EventArgs e)
        {
            user_account_visibility();

        }
        private void user_account_visibility()
        {
            if (comboBox_type.Text.StartsWith("Учень"))
            {
                panelStudent.Visible = true;
                panelTeacher.Visible = false;

            }
            else
            {
                panelTeacher.Visible = true;
                panelStudent.Visible = false;
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ApiClass authApi = new ApiClass();
            authApi.path = "user_add";
            var selectedItem = comboBox_type.SelectedItem as type_item;
            var selectedValue=new object();
            if (selectedItem != null)
            {
                selectedValue = selectedItem.Value;
                // Используйте selectedValue по вашему усмотрению, например:               
            }
            var classObject = new
            {
                user_account_id = id,
                nickname = nicknameTextBox.Text,
                password = passwordTextBox.Text,
                user_account_type = selectedValue,
                full_name = full_nameTextBox.Text
            };
            var json = JsonConvert.SerializeObject(classObject);
            authApi.query.Add("jsonData", json);
            authApi.uriCreate();
            var Stream = authApi.ServerAuthorization();
            MessageString message = new MessageString();
            message = JsonHelpers.ReadFromJsonStream<MessageString>(Stream);
            //Message.MessageInfo(message.message);
            if(message.message == "Виникла помилка")
            {
                Message.MessageInfo(message.message);
                return;
            }
            authApi = new ApiClass();

            if (comboBox_type.Text.StartsWith("Учень"))
            {
                authApi.path = "user_student_add";
                var classStudent = new
                {
                    user_account_id = id,
                    student_email = student_emailTextBox.Text,
                    parent_email = parent_emailTextBox.Text,
                    class_id = comboBox_class.SelectedValue,
                };
                json = JsonConvert.SerializeObject(classStudent);

            }
            else
            {
                authApi.path = "user_teacher_add";
                var classTeacher = new
                {
                    user_account_id = id,
                    email_address = email_addressTextBox.Text
                };
                json = JsonConvert.SerializeObject(classTeacher);


            }
            authApi.query.Add("jsonData", json);
            authApi.uriCreate();
            Stream = authApi.ServerAuthorization();
            //message = new MessageString();
            message = JsonHelpers.ReadFromJsonStream<MessageString>(Stream);
            Message.MessageInfo(message.message);
        }
    }
}
