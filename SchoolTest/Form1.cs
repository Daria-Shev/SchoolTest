using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolTest.Helpers;
using SchoolTest.Info;


namespace SchoolTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

            //label1.Text = message.message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exit();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApiClass api = new ApiClass();
            api.createClient();
        }
        void Exit()
        {
            ApiClass api = new ApiClass();
            api.url = new Uri("https://localhost:44382/logout");
            var Stream = api.GetServerResult();
            MessageString message = new MessageString();
            message = JsonHelpers.ReadFromJsonStream<MessageString>(Stream);
            //label1.Text = message.message;
        }
    }
}
