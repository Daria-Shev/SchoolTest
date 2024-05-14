using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using WebSerCore.Class;
using Newtonsoft.Json;
using System;
using System.Data.SqlClient;
using System.Net.Mail;

namespace WebSerCore.Controllers.Stydent
{
    public class question_test : Controller
    {
        [HttpGet, Route("question_list")]
        [Authorize]
        public object question_list(int count, string theme_id)
        {
            BD bd = new BD();
            bd.connectionBD();

            //        string sqlExpression = @"
            //    SELECT TOP(@count) dbo.question.question_id, dbo.question.question_text, dbo.question.points, dbo.question.theme_id
            //    FROM dbo.question  
            //    WHERE dbo.question.theme_id = @theme_id
            //    ORDER BY NEWID();
            //";
            string sqlExpression = @"
        SELECT q.question_id, q.question_text, q.points, q.theme_id, r.*
FROM (
    SELECT TOP(@count) dbo.question.question_id, dbo.question.question_text, dbo.question.points, dbo.question.theme_id
    FROM dbo.question  
    WHERE dbo.question.theme_id = @theme_id
    ORDER BY NEWID()
) AS q
LEFT JOIN response AS r ON r.question_id IN (
    SELECT question_id FROM dbo.question WHERE theme_id = @theme_id
) AND r.question_id = q.question_id;
            ";

            List<object> questions = new List<object>();

            using (SqlCommand command = new SqlCommand(sqlExpression, bd.connection))
            {
                command.Parameters.AddWithValue("@count", count);
                command.Parameters.AddWithValue("@theme_id", theme_id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var obj = new
                        {
                            response_id = reader["response_id"].ToString(),
                            question_id = reader["question_id"].ToString(),
                            question_text = reader["question_text"].ToString(),
                            points = reader["points"].ToString(),
                            response_type = reader["response_type"].ToString()
                        };

                        questions.Add(obj);
                    }
                }
            }

            bd.closeBD();
            return questions;
        }

        [HttpGet, Route("response_list")]
        [Authorize]
        public object response_list(string type, string question_id)
        {
            BD bd = new BD();
            bd.connectionBD();
            string sqlExpression = "";
            if (type.StartsWith("matching"))
            {
                sqlExpression = @"
SELECT        dbo.matching.matching_number, dbo.matching.option_text, dbo.matching.matching_text, dbo.response.response_id, dbo.response.question_id, dbo.response.response_type
FROM            dbo.matching INNER JOIN
                         dbo.response ON dbo.matching.response_id = dbo.response.response_id
WHERE        (dbo.response.question_id = @question_id)
            ";
            }
            if (type.StartsWith("open_response"))
            {
                sqlExpression = @"
SELECT        dbo.response.response_id, dbo.response.question_id, dbo.response.response_type, dbo.open_response.correct_response
FROM            dbo.response INNER JOIN
                         dbo.open_response ON dbo.response.response_id = dbo.open_response.response_id
WHERE        (dbo.response.question_id = @question_id)
            ";
            }
            if (type.StartsWith("answer_options"))
            {
                sqlExpression = @"
SELECT        dbo.response.response_id, dbo.response.question_id, dbo.response.response_type, dbo.answer_options.option_number, dbo.answer_options.correct_option, dbo.answer_options.option_text
FROM            dbo.response INNER JOIN
                         dbo.answer_options ON dbo.response.response_id = dbo.answer_options.response_id
WHERE        (dbo.response.question_id = @question_id)
            ";
            }
            if (type.StartsWith("sequence"))
            {
                sqlExpression = @"
SELECT        dbo.response.response_id, dbo.response.question_id, dbo.response.response_type, dbo.sequence.sequence_number, dbo.sequence.sequence_text
FROM            dbo.response INNER JOIN
                         dbo.sequence ON dbo.response.response_id = dbo.sequence.response_id
WHERE        (dbo.response.question_id = @question_id)
            ";
            }


            List<object> questions = new List<object>();

            using (SqlCommand command = new SqlCommand(sqlExpression, bd.connection))
            {
                command.Parameters.AddWithValue("@question_id", question_id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (type.StartsWith("matching"))
                        {
                            var obj = new
                            {
                                response_id = reader["response_id"].ToString(),
                                question_id = reader["question_id"].ToString(),
                                matching_number = reader["matching_number"].ToString(),
                                option_text = reader["option_text"].ToString(),
                                matching_text = reader["matching_text"].ToString(),
                            };
                            questions.Add(obj);
                        }
                        if (type.StartsWith("open_response"))
                        {
                            var obj = new
                            {
                                response_id = reader["response_id"].ToString(),
                                question_id = reader["question_id"].ToString(),
                                correct_response = reader["correct_response"].ToString(),

                            };
                            questions.Add(obj);
                        }
                        if (type.StartsWith("answer_options"))
                        {
                            var obj = new
                            {
                                response_id = reader["response_id"].ToString(),
                                question_id = reader["question_id"].ToString(),
                                option_number = reader["option_number"].ToString(),
                                correct_option = reader["correct_option"].ToString(),
                                option_text = reader["option_text"].ToString(),
                            };
                            questions.Add(obj);
                        }
                        if (type.StartsWith("sequence"))
                        {
                            var obj = new
                            {
                                response_id = reader["response_id"].ToString(),
                                question_id = reader["question_id"].ToString(),
                                sequence_number = reader["sequence_number"].ToString(),
                                sequence_text = reader["sequence_text"].ToString(),
                            };
                            questions.Add(obj);
                        }
                    }
                }
            }

            bd.closeBD();
            return questions;
        }
    }
}
