using SchoolTest.Helpers;
using SchoolTest.Info;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolTest.ProgramForms.Student.Test
{
    public partial class test_info : Form
    {
        string theme_id;
        string test_id="";
        string test_type;
        int attempts_used;

        public test_info(string data, string test_type)
        {
            InitializeComponent();
            this.theme_id = data;
            this.test_type = test_type;
        }
        public test_info(string test_id)
        {
            InitializeComponent();
            this.test_id = test_id;
        }

        private void test_info_Load(object sender, EventArgs e)
        {
                getInfo();



        }
        private void getInfo()
        {
              ApiClass authApi = new ApiClass();
            if (test_id == "")
            {
                authApi.path = "InfoTest";
                authApi.query.Add("theme_id", theme_id);
                authApi.query.Add("class_id", User.class_id);
                authApi.query.Add("test_type", test_type);
            }
            else
            {
                authApi.path = "InfoTest2";
                authApi.query.Add("test_id", test_id);
            }
            


            authApi.uriCreate();
            var Stream = authApi.ServerAuthorization();

            var test = JsonHelpers.ReadFromJsonStream(new { test_id = "", test_name = "", execution_time = "", attempt_count = "", theme_name = "" }, Stream);


            authApi = new ApiClass();
            authApi.path = "check_attempts_used_test";
            authApi.query.Add("test_id", test.test_id);
            authApi.query.Add("user_account_id", User.id);
            authApi.query.Add("test_type", test_type);


            authApi.uriCreate();
            Stream = authApi.ServerAuthorization();
            var info = JsonHelpers.ReadFromJsonStream(new { attempts_used = "", max_grade = ""}, Stream);
            int attempt_count_now = int.Parse(test.attempt_count)- int.Parse(info.attempts_used);
            attempts_used = int.Parse(info.attempts_used);
            test_id = test.test_id;
            label_test_name.Text = test.test_name;
            label_theme.Text = test.theme_name;
            label_attempt_count.Text = test.attempt_count;
            label_count_now.Text= attempt_count_now.ToString();
            label_execution_time.Text = test.execution_time+" хв";
            
            if (attempt_count_now!=int.Parse(test.attempt_count))
            {
                int grade_number = int.Parse(info.max_grade);
                string grade = grade_number_string(grade_number);
                label_text.Text = "Ви вже проходили цей тест, ваш результат: "+ grade;
            }
        }
        private string grade_number_string(int grade_number)
        {
            string grade = "";
            switch (grade_number)
            {
                case 1:
                    grade = "П";
                    break;
                case 2:
                    grade = "С";
                    break;
                case 3:
                    grade = "Д";
                    break;
                case 4:
                    grade = "В";
                    break;
            }
            return grade;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ifrm = new Test(test_id, theme_id, attempts_used);
            ifrm.Show();
            this.Close();
        }
    }
}
