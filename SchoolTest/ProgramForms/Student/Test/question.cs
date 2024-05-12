using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTest.ProgramForms.Student.Test
{
    public class question
    {
        string question_text;
        int points;
        string response_type;
        int question_id;


    }
    public class open_response
    {
        int question_id;

        string correct_response;
    }
    public class sequence
    {
        int question_id;

        int sequence_number;
        string sequence_text;

    }
    public class answer_options
    {
        int question_id;

        int option_number;
        string correct_option;
        string option_text;

    }
    public class matching
    {
        int question_id;

        int matching_number;
        string option_text;
        string matching_text;
    }
}
