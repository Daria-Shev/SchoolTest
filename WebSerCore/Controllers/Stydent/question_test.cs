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

            string sqlExpression = @"
                    SELECT TOP(@count) dbo.question.question_id, dbo.question.question_text, dbo.question.points, dbo.question.theme_id, dbo.response.response_type
FROM            dbo.question INNER JOIN
                         dbo.response ON dbo.question.question_id = dbo.response.question_id
            WHERE dbo.question.theme_id = @theme_id
            ORDER BY NEWID();
                ";
            List<object> questions = new List<object>();

            object obj = null;
            using (SqlCommand command = new SqlCommand(sqlExpression, bd.connection))
            {
                command.Parameters.AddWithValue("@count", count);
                command.Parameters.AddWithValue("@theme_id", theme_id);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        obj = new
                        {
                            question_id = reader["question_id"].ToString(),
                            question_text = reader["question_text"].ToString(),
                            points = reader["points"].ToString(),
                            response_type = reader["theme_id"].ToString()
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
