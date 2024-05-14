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
        int question_count_now=0;

        string theme_id;
        testStart a = new testStart();

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
            question_form();

            taimer();

        }
        private void question_form()
        {
            var quest = a.questionResponce.ElementAt(question_count_now).Value;
            label_question_text.Text= quest.question_text;
            panel_visible_false();
            if (quest.response_type.StartsWith("open_response"))
            {
                panel_open_response.Visible = true;
                label_type_text.Text = "Дайте відповідь текстом";
            }
            if (quest.response_type.StartsWith("matching"))
            {
                question_matching();
            }
            if (quest.response_type.StartsWith("sequence"))
            {
                question_sequence();
            }
            if (quest.response_type.StartsWith("answer_options"))
            {               
                question_answer_options();
            }
        }
        private void question_answer_options()
        {
            panel_answer_options.Visible = true;
            var quest = a.questionResponce.ElementAt(question_count_now).Value;
            label_type_text.Text = "Виберіть одну або декілько правильних відповідей";
            for (int i = 1; i <= quest.matching.Count; i++)
            {
                this.Controls["checkBox" + i.ToString()].Visible = true;
                ((CheckBox)this.Controls["checkBox" + i.ToString()]).Text=quest.answer_options[i - 1].option_text;
            }
        }
        private void question_sequence()
        {
            panel_sequence.Visible = true;

            var quest = a.questionResponce.ElementAt(question_count_now).Value;
            label_type_text.Text = "Вкажіть правильну послідовність";
            for (int i = 7; i <= quest.matching.Count; i++)
            {
                this.Controls["label" + i.ToString()].Visible = true;
                this.Controls["comboBox" + i.ToString()].Visible = true;
                ((ComboBox)this.Controls["comboBox" + i.ToString()]).Items.Add(quest.sequence[i - 7].sequence_text);
            }
        }
        private void question_matching()
        {
            panel_matching.Visible = true;
            var quest = a.questionResponce.ElementAt(question_count_now).Value;
            label_type_text.Text = "Установіть відповідність";
            for (int i = 1; i <= quest.matching.Count; i++)
            {
                this.Controls["label" + i.ToString()].Visible = true;
                this.Controls["comboBox" + i.ToString()].Visible = true;
                this.Controls["label" + i.ToString()].Text = quest.matching[i-1].matching_text;
                ((ComboBox)this.Controls["comboBox" + i.ToString()]).Items.Add(quest.matching[i - 1].option_text);
            }

        }
        private void panel_visible_false()
        {
            panel_open_response.Visible = false;
            panel_matching.Visible = false;
            panel_sequence.Visible = false;
            panel_answer_options.Visible = false;
            for (int i = 1; i <= 12; i++)
            {
                this.Controls["label" + i.ToString()].Visible = false;
                this.Controls["comboBox" + i.ToString()].Visible = false;
            }
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
            label_count_question.Text = "Питання" + (question_count_now+1)+ " з " + question_count;
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

            //testStart a = new testStart();
            a.questionResponce = new Dictionary<int, question>();

            foreach (QuerstionAndResponce question in questions)
            {
                if (a.questionResponce.ContainsKey(question.question_id))
                {
                    dictionaryAdd(a, question);
                }
                else
                {
                    a.questionResponce.Add(question.question_id, new question());
                    dictionaryAdd(a, question);
                }
            }
            foreach (QuerstionAndResponce question in questions)
            {
                response(a, question);
            }

        }
       public void dictionaryAdd(testStart a, QuerstionAndResponce question)
        {
            a.questionResponce[question.question_id].question_text = question.question_text;
            a.questionResponce[question.question_id].response_type = question.response_type;
            a.questionResponce[question.question_id].points = question.points;

            a.questionResponce[question.question_id].response_id.Add(question.response_id);
        }
        private void response(testStart a, QuerstionAndResponce question)
        {
            ApiClass authApi = new ApiClass();

            authApi.path = "response_list";
            authApi.query.Add("question_id", question.question_id.ToString());
            authApi.query.Add("type", question.response_type);

            authApi.uriCreate();
            var Stream = authApi.ServerAuthorization();
            if (question.response_type.StartsWith("matching"))
            {
                List<matching> response = JsonHelpers.ReadFromJsonStream<List<matching>>(Stream);
                foreach (matching matching in response)
                {
                    //if (question.response_id== matching.response_id)
                   // {
                        a.questionResponce[question.question_id].matching.Add(matching);

                   // }
                }
            }
            if (question.response_type.StartsWith("open_response"))
            {
                List<open_response> response = JsonHelpers.ReadFromJsonStream<List<open_response>>(Stream);
                foreach (open_response open_response in response)
                {
                    //if (question.response_id == open_response.response_id)
                    //{
                        a.questionResponce[question.question_id].open_response.Add(open_response);

                    //}
                }
            }
            if (question.response_type.StartsWith("sequence"))
            {
                List<sequence> response = JsonHelpers.ReadFromJsonStream<List<sequence>>(Stream);
                foreach (sequence sequence in response)
                {
                    //if (question.response_id == sequence.response_id)
                   // {
                        a.questionResponce[question.question_id].sequence.Add(sequence);

                  //  }
                }
            }
            if (question.response_type.StartsWith("answer_options"))
            {
                List<answer_options> response = JsonHelpers.ReadFromJsonStream<List<answer_options>>(Stream);
                foreach (answer_options answer_options in response)
                {
                           // if (question.response_id == answer_options.response_id)
                   // {
                        a.questionResponce[question.question_id].answer_options.Add(answer_options);

                    //}
                }
            }
            //List<QuerstionAndResponce> questions = JsonHelpers.ReadFromJsonStream<List<QuerstionAndResponce>>(Stream);

            ////testStart a = new testStart();

            //a.questionResponce[question.question_id].open_response.Add(question.open_response);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            question_count_now++;
            if (question_count_now> question_count)
            {
                // сделать что-то окончание теста
            }
            question_form();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
