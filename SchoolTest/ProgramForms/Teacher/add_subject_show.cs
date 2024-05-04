using SchoolTest.Helpers;
using SchoolTest.Info;
using SchoolTest.ProgramForms.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SchoolTest.ProgramForms.Teacher
{
    public partial class add_subject_show : Form
    {
        object data;
        string id;
        public add_subject_show(object data)
        {
            InitializeComponent();
            this.data = data;
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            server_add();
        }
        private void server_add()
        {
            string subject_name = subject_nameTextBox.Text;
            string class_number = ClassTextBox.Text;
            ApiClass authApi = new ApiClass();

            authApi.path = "subject_add";
            authApi.query.Add("subject_id", id);
            authApi.query.Add("subject_name", subject_name);
            authApi.query.Add("subject_class_number", class_number);
            //authApi.query = HttpUtility.UrlDecode(authApi.query.ToString());
            authApi.uriCreate();

           
            var Stream = authApi.ServerAuthorization();

            MessageString message = new MessageString();
            message = JsonHelpers.ReadFromJsonStream<MessageString>(Stream);

            Message.MessageInfo(message.message);

        }

        private void add_subject_show_Load(object sender, EventArgs e)
        {
            var dataTable = (dynamic)data;
            subject_nameTextBox.Text = dataTable.subject_name;
            ClassTextBox.Text = dataTable.class_number;
            id = dataTable.id;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            add_subject form1Instance = Application.OpenForms.OfType<add_subject>().FirstOrDefault();
            if (form1Instance != null)
            {
                form1Instance.Table();
            }
            this.Close();
        }

        private void add_subject_show_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void add_subject_show_FormClosed(object sender, FormClosedEventArgs e)
        {
            buttonBack_Click(sender, e);
        }
    }
}
