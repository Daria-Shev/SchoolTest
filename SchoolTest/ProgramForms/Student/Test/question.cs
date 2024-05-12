using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTest.ProgramForms.Student.Test
{

    public class QuerstionAndResponce
    {
        public int response_id;
        public int question_id;
        public string response_type;
        public string question_text;
        public int points;
    }

    public class testStart
    {
        public Dictionary<int, question> questionResponce;
    }
    public class question
    {
        public string question_text;
        public int points;
        public string response_type;
        public int question_id;
        public List<int> response_id;

        public List<open_response> open_response;
        public question()
        {
            // Инициализация списка response_id как пустого списка
            response_id = new List<int>();
        }
    }
    public class open_response
    {
        public string correct_response;
    }
    public class sequence
    {
        public int question_id;

        public int sequence_number;
        public string sequence_text;

    }
    public class answer_options
    {
        public int question_id;

         public int option_number;
        public string correct_option;
        public string option_text;

    }
    public class matching
    {
        public int question_id;

        public int matching_number;
        public string option_text;
        public string matching_text;
    }
}
