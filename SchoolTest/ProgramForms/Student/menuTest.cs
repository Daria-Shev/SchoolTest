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
        }
        private void combo_box_subject()
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "subject_list_student";
            authApi.query.Add("class_number", User.class_number);

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

            authApi.path = "theme_list_student";
            authApi.query.Add("class_number", User.class_number);
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
