using Newtonsoft.Json;
using SchoolTest.Helpers;
using SchoolTest.Info;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolTest.ProgramForms.Student.Test
{
    public partial class Test : Form
    {
 
        string test_id;
        string test_type;
        int execution_time;
        int question_count;
        string theme_id;


        public Test(string test_id, string theme_id)
        {
            InitializeComponent();
            this.test_id = test_id;
            this.theme_id = theme_id;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            Info();
            question();
            taimer();

        }
        private void Info()
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "info_test_id";
            authApi.query.Add("test_id", test_id);
            authApi.uriCreate();
            var Stream = authApi.ServerAuthorization();

            var test = JsonHelpers.ReadFromJsonStream(new { test_type = "", test_name = "", execution_time = "", question_count = "" }, Stream);
            test_type = test.test_type;
            this.Text = test.test_name;
            execution_time = int.Parse(test.execution_time);
            question_count = int.Parse(test.question_count);
            test_type = test.test_type;
        }
        private void taimer()
        {
            

        }
        private void question()
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "question_list";
            authApi.query.Add("count", question_count.ToString());
            authApi.query.Add("theme_id", theme_id);

            authApi.uriCreate();
            var Stream = authApi.ServerAuthorization();

            //..List<question> questions = new List<question>();

            List<QuerstionAndResponce> questions = JsonHelpers.ReadFromJsonStream<List<QuerstionAndResponce>>(Stream);

            testStart a = new testStart();
            a.questionResponce = new Dictionary<int, question>();

            foreach (QuerstionAndResponce question in questions)
            {
                

                if (a.questionResponce.ContainsKey(question.question_id))
                {
                    dictionaryAdd(a, question);
                    //a.questionResponce[question.question_id].question_text = question.question_text_BD;
                    //a.questionResponce[question.question_id].response_type = question.response_type;
                    //a.questionResponce[question.question_id].response_type = question.response_type;
                    //a.questionResponce[question.question_id].points = question.points;
                    //a.questionResponce[question.question_id].response_id.Add(question.response_id);


                }
                else
                {
                    a.questionResponce.Add(question.question_id, new question());
                    dictionaryAdd(a, question);

                    //a.questionResponce[question.question_id].question_text = question.question_text_BD;
                    //a.questionResponce[question.question_id].response_type = question.response_type;
                    //a.questionResponce[question.question_id].response_type = question.response_type;
                    //a.questionResponce[question.question_id].points = question.points;
                    //a.questionResponce[question.question_id].response_id.Add(question.response_id);

                }
            }
            int o = 0;

        }
       public void dictionaryAdd(testStart a, QuerstionAndResponce question)
        {
            a.questionResponce[question.question_id].question_text = question.question_text;
            a.questionResponce[question.question_id].response_type = question.response_type;
            a.questionResponce[question.question_id].points = question.points;

            a.questionResponce[question.question_id].response_id.Add(question.response_id);
        }
    }
}
