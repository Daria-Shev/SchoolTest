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
        int execution_time, test_attempt;
        int question_count;
        int question_count_now = 0;
        private int executionTimeInSeconds; // Время выполнения в секундах
        private int remainingTimeInSeconds; // Оставшееся время в секундах

        string theme_id;
        testStart a = new testStart();

        public Test(string test_id, string theme_id, int attempts_used)
        {
            InitializeComponent();
            this.test_id = test_id;
            this.theme_id = theme_id;
            this.test_attempt = attempts_used;

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

            label_count_question.Text = "Питання " + (question_count_now + 1) + " з " + question_count;
            var quest = a.questionResponce.ElementAt(question_count_now).Value;
            label_question_text.Text = quest.question_text;
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
            for (int i = 0; i < quest.answer_options.Count; i++)
            {
                panel_answer_options.Controls["checkBox" + (i + 1).ToString()].Visible = true;
                ((CheckBox)panel_answer_options.Controls["checkBox" + (i + 1).ToString()]).Text = quest.answer_options[i].option_text;
            }
        }
        private void question_sequence()
        {
            panel_sequence.Visible = true;

            var quest = a.questionResponce.ElementAt(question_count_now).Value;
            label_type_text.Text = "Вкажіть правильну послідовність";
            for (int i = 0; i < quest.sequence.Count; i++)
            {
                panel_sequence.Controls["label" + (i + 7).ToString()].Visible = true;
                panel_sequence.Controls["comboBox" + (i + 7).ToString()].Visible = true;
                for (int j = 0; j < quest.sequence.Count; j++)
                {
                    ((ComboBox)panel_sequence.Controls["comboBox" + (i + 7).ToString()]).Items.Add(quest.sequence[j].sequence_text);

                }
            }
        }
        private void question_matching()
        {
            panel_matching.Visible = true;
            var quest = a.questionResponce.ElementAt(question_count_now).Value;
            label_type_text.Text = "Установіть відповідність";
            for (int i = 0; i < quest.matching.Count; i++)
            {
                panel_matching.Controls["label" + (i + 1).ToString()].Visible = true;
                panel_matching.Controls["comboBox" + (i + 1).ToString()].Visible = true;
                panel_matching.Controls["label" + (i + 1).ToString()].Text = quest.matching[i].matching_text;
                for (int j = 0; j < quest.matching.Count; j++)
                {
                    ((ComboBox)panel_matching.Controls["comboBox" + (i + 1).ToString()]).Items.Add(quest.matching[j].option_text);

                }
            }

        }
        private void panel_visible_false()
        {
            panel_open_response.Visible = false;
            panel_matching.Visible = false;
            panel_sequence.Visible = false;
            panel_answer_options.Visible = false;
            richTextBox1.Text = "";
            for (int i = 1; i <= 6; i++)
            {
                panel_matching.Controls["label" + i.ToString()].Visible = false;
                panel_matching.Controls["comboBox" + i.ToString()].Visible = false;
                ((ComboBox)panel_matching.Controls["comboBox" + i.ToString()]).Items.Clear();

            }
            for (int i = 7; i <= 12; i++)
            {
                panel_sequence.Controls["label" + i.ToString()].Visible = false;
                panel_sequence.Controls["comboBox" + i.ToString()].Visible = false;
                ((ComboBox)panel_sequence.Controls["comboBox" + i.ToString()]).Items.Clear();

            }
            for (int i = 1; i <= 8; i++)
            {
                panel_answer_options.Controls["checkBox" + i.ToString()].Visible = false;
                ((CheckBox)panel_answer_options.Controls["checkBox" + i.ToString()]).Checked = false;

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
            label_count_question.Text = "Питання " + (question_count_now + 1) + " з " + question_count;
        }
        private void taimer()
        {
            executionTimeInSeconds = execution_time * 60;
            remainingTimeInSeconds = executionTimeInSeconds;
            timer.Tick += timer_Tick;
            timer.Interval = 2000; // 1 секунда
            timer.Start();
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
                if (checkResponce(a, question))
                {
                    response(a, question);

                }
                //response(a, question);
            }

        }
        public bool checkResponce(testStart a, QuerstionAndResponce question)
        {
            if (a.questionResponce[question.question_id].matching.Count != 0)
            {
                return false;
            }
            if (a.questionResponce[question.question_id].answer_options.Count != 0)
            {
                return false;
            }
            if (a.questionResponce[question.question_id].sequence.Count != 0)
            {
                return false;
            }
            if (a.questionResponce[question.question_id].open_response.Count != 0)
            {
                return false;
            }
            return true;

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
                    a.questionResponce[question.question_id].matching.Add(matching);
                }
            }
            if (question.response_type.StartsWith("open_response"))
            {
                List<open_response> response = JsonHelpers.ReadFromJsonStream<List<open_response>>(Stream);
                foreach (open_response open_response in response)
                {
                    a.questionResponce[question.question_id].open_response.Add(open_response);
                }
            }
            if (question.response_type.StartsWith("sequence"))
            {
                List<sequence> response = JsonHelpers.ReadFromJsonStream<List<sequence>>(Stream);
                foreach (sequence sequence in response)
                {
                    a.questionResponce[question.question_id].sequence.Add(sequence);
                }
            }
            if (question.response_type.StartsWith("answer_options"))
            {
                List<answer_options> response = JsonHelpers.ReadFromJsonStream<List<answer_options>>(Stream);
                foreach (answer_options answer_options in response)
                {
                    a.questionResponce[question.question_id].answer_options.Add(answer_options);
                }
            }
            //List<QuerstionAndResponce> questions = JsonHelpers.ReadFromJsonStream<List<QuerstionAndResponce>>(Stream);

            ////testStart a = new testStart();

            //a.questionResponce[question.question_id].open_response.Add(question.open_response);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            response_sent_to_server();
            question_count_now++;
            if (question_count_now == question_count)
            {
                button1.Text = "Завершити тестування";
            }
            if (question_count_now > question_count)
            {
                exit_test();

            }
            question_form();

        }
        private void response_sent_to_server()
        {
            var quest = a.questionResponce.ElementAt(question_count_now).Value;
            if (quest.response_type.StartsWith("open_response"))
            {
                open_response_sent_to_server();
            }
            if (quest.response_type.StartsWith("matching"))
            {
                matching_sent_to_server();
            }
            if (quest.response_type.StartsWith("sequence"))
            {
                sequence_sent_to_server();
            }
            if (quest.response_type.StartsWith("answer_options"))
            {
                answer_options_sent_to_server();
            }
        }
        private void answer_options_sent_to_server()
        {
            var quest = a.questionResponce.ElementAt(question_count_now).Value;
            var checkBoxTextList = new List<string>();
            var correct_optionTextList = new List<string>();
            //var response_idList = new List<string>();

            for (int i = 0; i < quest.answer_options.Count; i++)
            {
                checkBoxTextList.Add(((CheckBox)panel_answer_options.Controls["checkBox" + (i + 1).ToString()]).Text);
                bool isChecked = ((CheckBox)panel_answer_options.Controls["checkBox" + (i + 1).ToString()]).Checked;
                correct_optionTextList.Add(isChecked ? "Так" : "Ні");
            }

            ApiClass authApi = new ApiClass();

            authApi.path = "answer_options_sent_to_server";

            var classObject = new
            {
                test_id = test_id,
                user_account_id = User.id,
                test_attempt = test_attempt,
                response_id = quest.response_id,
                option_text = checkBoxTextList,
                correct_option= correct_optionTextList
            };
            var json = JsonConvert.SerializeObject(classObject);
            authApi.query.Add("jsonData", json);
            authApi.uriCreate();
            var Stream = authApi.ServerAuthorization();

        }
        private void sequence_sent_to_server()
        {
            var quest = a.questionResponce.ElementAt(question_count_now).Value;
            var sequenceTextList = new List<string>();
            for (int i = 0; i < quest.sequence.Count; i++)
            {
                sequenceTextList.Add(((ComboBox)panel_sequence.Controls["comboBox" + (i + 7).ToString()]).Text);
            }
            ApiClass authApi = new ApiClass();

            authApi.path = "sequence_sent_to_server";

            var classObject = new
            {
                test_id = test_id,
                user_account_id = User.id,
                test_attempt = test_attempt,
                response_id = quest.response_id,
                sequence_text = sequenceTextList,

            };
            var json = JsonConvert.SerializeObject(classObject);
            authApi.query.Add("jsonData", json);
            authApi.uriCreate();
            var Stream = authApi.ServerAuthorization();

        }
        private void matching_sent_to_server()
        {
            var quest = a.questionResponce.ElementAt(question_count_now).Value;
            var optionTextList = new List<string>();
            var matchingTextList = new List<string>();
            for (int i = 0; i < quest.matching.Count; i++)
            {
                matchingTextList.Add(panel_matching.Controls["label" + (i + 1).ToString()].Text);
                optionTextList.Add(((ComboBox)panel_matching.Controls["comboBox" + (i + 1).ToString()]).Text);
            }
            ApiClass authApi = new ApiClass();

            authApi.path = "matching_sent_to_server";

            var classObject = new
            {
                test_id = test_id,
                user_account_id = User.id,
                test_attempt = test_attempt,
                response_id = quest.response_id,
                option_text = optionTextList,
                matching_text = matchingTextList

            };
            var json = JsonConvert.SerializeObject(classObject);
            authApi.query.Add("jsonData", json);
            authApi.uriCreate();
            var Stream = authApi.ServerAuthorization();

        }
        private void open_response_sent_to_server()
        {
            var quest = a.questionResponce.ElementAt(question_count_now).Value;

            ApiClass authApi = new ApiClass();

            authApi.path = "open_response_sent_to_server";

            var classObject = new
            {
                test_id=test_id,
                user_account_id=User.id,
                test_attempt = test_attempt,
                response_id = quest.response_id[0],
                user_response = richTextBox1.Text,             
            };
            var json = JsonConvert.SerializeObject(classObject);
            authApi.query.Add("jsonData", json);
            authApi.uriCreate();
            var Stream = authApi.ServerAuthorization();


        }
        private void exit_test()
        {
            List<int> question_id_list = new List<int>();
            for (int i = 0; i < a.questionResponce.Count; i++)
            {
                question_id_list.Add( a.questionResponce.ElementAt(i).Key);
            }
            ApiClass authApi = new ApiClass();

            authApi.path = "test_end";

            var classObject = new
            {
                test_id = test_id,
                user_account_id = User.id,
                test_attempt = test_attempt,
                 question_id = question_id_list,
            };
            var json = JsonConvert.SerializeObject(classObject);
            authApi.query.Add("jsonData", json);
            authApi.uriCreate();
            var Stream = authApi.ServerAuthorization();


            Form ifrm = new test_info(test_id);
            ifrm.ShowDialog();
            this.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            remainingTimeInSeconds--;
            TimeSpan remainingTime = TimeSpan.FromSeconds(remainingTimeInSeconds);
            label_time.Text = $"{remainingTime.Minutes:00}:{remainingTime.Seconds:00}";

            if (remainingTimeInSeconds <= 120) // Если осталось 2 минуты или меньше
            {
                label_time.ForeColor = Color.Red;
            }

            if (remainingTimeInSeconds <= 0) // Если время истекло
            {
                timer.Stop();
                Message.MessageInfo("Час вийшов. Тестування завершено.");

                // Вызов функции по истечении времени
                exit_test();
            }

        }
    }
}
