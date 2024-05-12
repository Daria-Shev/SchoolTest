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
    SELECT TOP(10) dbo.question.question_id, dbo.question.question_text, dbo.question.points, dbo.question.theme_id
    FROM dbo.question  
    WHERE dbo.question.theme_id = 2
    ORDER BY NEWID()
) AS q
LEFT JOIN response AS r ON r.question_id IN (
    SELECT question_id FROM dbo.question WHERE theme_id = 2
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


    }
}
