using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolTest.Helpers;
using SchoolTest.Info;
using SchoolTest.ProgramForms;
using SchoolTest.ProgramForms.Student;
using SchoolTest.ProgramForms.Teacher;

namespace SchoolTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ApiClass api;

        private void button3_Click(object sender, EventArgs e)
        {
            string nicname = textBox1.Text;
            string password = textBox2.Text;
            ApiClass authApi = new ApiClass();

            authApi.path = "login";
            authApi.query.Add("nickname", nicname);
            authApi.query.Add("password", password);
            authApi.uriCreate();

            var Stream = authApi.ServerAuthorization();

            MessageString message = new MessageString();
            message = JsonHelpers.ReadFromJsonStream<MessageString>(Stream);
            //потом включить сообщение что закоментила
            //SchoolTest.ProgramForms.Message.MessageInfo(message.message);
            if ((message.message == "Авторизація успішна"))
            {
                Form ifrm = new studentHome();
                getInfo(nicname);
                if (User.user_account_type.StartsWith("teacher"))
                {
                    ifrm = new teacherHome();
                }

                ifrm.Show();
                this.Hide();
            }
   
        }
        private void getInfo(string nicname)
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "InfoUser";
            authApi.query.Add("nickname", nicname);
            //authApi.query.Add("password", password);
            authApi.uriCreate();
            var Stream = authApi.ServerAuthorization();
            var info = JsonHelpers.ReadFromJsonStream(new { nickname = "", user_account_type = "", full_name = "",  id = "" }, Stream);
            User.nickname = info.nickname;
            User.user_account_type = info.user_account_type;
            User.full_name = info.full_name;
            User.id = info.id;
            if (User.user_account_type.StartsWith("student"))
            {
                authApi = new ApiClass();
                authApi.path = "InfoClass";
                authApi.query.Add("id", User.id);
                authApi.uriCreate();
                Stream = authApi.ServerAuthorization();
                var info2 = JsonHelpers.ReadFromJsonStream(new { class_name = "", class_number="" }, Stream);
                User.class_name = info2.class_name;
                User.class_number = info2.class_number;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            api.exit();
            this.Close();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            api.exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             api = new ApiClass();
            api.createClient();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //void Exit()
        //{
        //    ApiClass api = new ApiClass();
        //    api.url = new Uri("https://localhost:44382/logout");
        //    var Stream = api.GetServerResult();
        //    MessageString message = new MessageString();
        //    message = JsonHelpers.ReadFromJsonStream<MessageString>(Stream);
        //    //label1.Text = message.message;
        //    SchoolTest.ProgramForms.Message.MessageInfo(message.message);
        //}
    }
}
