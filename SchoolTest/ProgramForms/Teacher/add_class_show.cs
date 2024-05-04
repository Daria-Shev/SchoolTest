using Newtonsoft.Json;
using SchoolTest.Helpers;
using SchoolTest.Info;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolTest.ProgramForms.Teacher
{
    public partial class add_class_show : Form
    {
        object data;
        string id;
        public add_class_show(object data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            add_class form1Instance = Application.OpenForms.OfType<add_class>().FirstOrDefault();
            if (form1Instance != null)
            {
                form1Instance.Table();
            }
            this.Close();
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

            authApi.path = "class_add";

            var classObject = new
            {
                class_id = id,
                class_name = class_nameTextBox.Text,
                class_number = class_numberTextBox.Text
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

        private void add_class_show_Load(object sender, EventArgs e)
        {
            var dataTable = (dynamic)data;
            class_nameTextBox.Text = dataTable.class_name;
            class_numberTextBox.Text = dataTable.class_number;
            id = dataTable.id;
        }

        private void add_class_show_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void add_class_show_FormClosed(object sender, FormClosedEventArgs e)
        {
            buttonBack_Click(sender, e);    
        }
    }
}
