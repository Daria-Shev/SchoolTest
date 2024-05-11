using Newtonsoft.Json;
using SchoolTest.Helpers;
using SchoolTest.Info;
using SchoolTest.ProgramForms.Teacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolTest.ProgramForms.Student.Test;


namespace SchoolTest.ProgramForms.Student
{
    public partial class menuTest : Form
    {
        public menuTest()
        {
            InitializeComponent();
        }

        private void menuTest_Load(object sender, EventArgs e)
        {
            combo_box_subject();
            combo_box_theme();
            combo_box_query(comboBox_subject.SelectedValue.ToString());

        }
        private void combo_box_query(string id_subject)
        {
            DataTable dataTable = (comboBox_theme.DataSource as DataTable);
            dataTable.DefaultView.RowFilter = $"subject_id = '{id_subject}'";
            comboBox_theme.Text = "";
        }
        private void combo_box_subject()
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "subject_list_student";
            authApi.query.Add("subject_class_number", User.class_number);

            authApi.uriCreate();

            var Stream = authApi.ServerAuthorization();

            var info = JsonHelpers.ReadFromJsonStream<string>(Stream);
            DataTable dataTable = JsonConvert.DeserializeObject(info, typeof(DataTable)) as DataTable;
            comboBox_subject.DataSource = dataTable;
            comboBox_subject.DisplayMember = "subject_name";
            comboBox_subject.ValueMember = "subject_id"; 
        }
        private void combo_box_theme()
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "theme_list_student";
            authApi.query.Add("subject_class_number", User.class_number);
            authApi.uriCreate();

            var Stream = authApi.ServerAuthorization();

            var info = JsonHelpers.ReadFromJsonStream<string>(Stream);
            DataTable dataTable = JsonConvert.DeserializeObject(info, typeof(DataTable)) as DataTable;
            comboBox_theme.DataSource = dataTable;
            comboBox_theme.DisplayMember = "theme_name"; 
            comboBox_theme.ValueMember = "theme_id"; 

        }

        private void comboBox_subject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            combo_box_query(comboBox_subject.SelectedValue.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ifrm = new addData();
            ifrm.Show();
            this.Close();
        }

        private bool check_info()
        {
            if (comboBox_theme.Text=="" || comboBox_subject.Text=="")
            {
                Message.MessageInfo("Ви не обрали предмет або/та тему");
                return true;
            }
            return false;
        }

        private bool check_data(string path)
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "check_"+path;
            string theme_id = comboBox_theme.SelectedValue.ToString();

            // старий варіант
            authApi.query.Add("theme_id", theme_id);
            if (path != "literature")
            {
                authApi.query.Add("id_class", User.class_id);

            }
            authApi.uriCreate();
            var Stream = authApi.ServerAuthorization();

            MessageString message = new MessageString();
            message = JsonHelpers.ReadFromJsonStream<MessageString>(Stream);
            if (message.message=="")
            {
                return true;
            }
            Message.MessageInfo(message.message);
            return false;

        }
        private void button_test_Click(object sender, EventArgs e)
        {
            if (check_info())
            {
                return;
            }
            if (check_data("test"))
            {
                Form ifrm = new test_info(comboBox_theme.SelectedValue.ToString(), "Оцінювальний");
                ifrm.ShowDialog();
            }

        }

        private void button_lit_Click(object sender, EventArgs e)
        {
            if (check_info())
            {
                return;
            }
            if ( check_data("literature")) 
            {
                Form ifrm = new student_literature(comboBox_theme.SelectedValue.ToString());
                ifrm.ShowDialog();
            }
        }

        private void button_practice_test_Click(object sender, EventArgs e)
        {
            if (check_info())
            {
                return;
            }
            if (check_data("practice_test")) {
                Form ifrm = new test_info(comboBox_theme.SelectedValue.ToString(), "Підготовчий");
                ifrm.ShowDialog();
            }
        }

    }
}
