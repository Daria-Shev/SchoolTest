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
    public partial class add_matching : Form
    {
        object data;
        string response_id, question_id, response_type;
        public add_matching(object data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void matching_textTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            add_question_show form1Instance = Application.OpenForms.OfType<add_question_show>().FirstOrDefault();
            if (form1Instance != null)
            {
                form1Instance.Table();
            }
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "response_add";

            var classObject = new
            {
                response_id = response_id,
                question_id = question_id,
                response_type = response_type,
            };
            var json = JsonConvert.SerializeObject(classObject);
            authApi.query.Add("jsonData", json);
            authApi.uriCreate();
            var Stream = authApi.ServerAuthorization();
            MessageString message = new MessageString();
            message = JsonHelpers.ReadFromJsonStream<MessageString>(Stream);
            if (message.message == "Виникла помилка")
            {
                Message.MessageInfo(message.message);
                return;
            }
            authApi = new ApiClass();

            authApi.path = "matching_add";

            var classObject2 = new
            {
                response_id = response_id,
                matching_number = matching_numberTextBox.Text,
                option_text = option_textTextBox1.Text,
                matching_text = matching_textTextBox.Text,

            };
            json = JsonConvert.SerializeObject(classObject2);
            authApi.query.Add("jsonData", json);
            authApi.uriCreate();
            Stream = authApi.ServerAuthorization();
            message = JsonHelpers.ReadFromJsonStream<MessageString>(Stream);

            Message.MessageInfo(message.message);
        }

        private void add_matching_FormClosed(object sender, FormClosedEventArgs e)
        {
            buttonBack_Click(sender, e);
        }

        private void add_matching_Load(object sender, EventArgs e)
        {
            var dataTable = (dynamic)data;
            response_id = dataTable.respose_id;
            question_id = dataTable.question_id;
            response_type = dataTable.response_type;
            matching_numberTextBox.Text = dataTable.matching_number;
            matching_textTextBox.Text = dataTable.matching_text;
            option_textTextBox1.Text = dataTable.option_text;

        }
    }
}
