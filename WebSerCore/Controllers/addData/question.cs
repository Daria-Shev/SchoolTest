using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using WebSerCore.Class;
using Newtonsoft.Json;
using System;
using System.Data.SqlClient;
using System.Net.Mail;

namespace WebSerCore.Controllers.addData
{
    public class question : Controller
    {
        [HttpGet, Route("question_table")]
        [Authorize(Roles = "teacher")]
        public object question_table()
        {
            BD bd = new BD();
            bd.connectionBD();
            string sqlExpression = @"SELECT
                                    dbo.subject.subject_id,
                                    dbo.theme.theme_id,
                                    dbo.question.question_id,
                                    dbo.response.response_id,
                                    dbo.response.response_type,
                                    dbo.subject.subject_name,
                                    dbo.theme.theme_name,
                                    dbo.question.question_text,
                                    dbo.question.points,
                                    CASE
                                        WHEN dbo.response.response_type = 'open_response' THEN N'Відкрита відповідь'
                                        WHEN dbo.response.response_type = 'answer_options' THEN N'Варіанти відповідей'
                                        WHEN dbo.response.response_type = 'sequence' THEN N'Послідовність'
                                        WHEN dbo.response.response_type = 'matching' THEN N'Відповідність'
                                        ELSE NULL
                                    END AS response_type_ukr
                                FROM
                                    dbo.subject
                                    INNER JOIN dbo.theme ON dbo.subject.subject_id = dbo.theme.subject_id
                                    INNER JOIN dbo.question ON dbo.theme.theme_id = dbo.question.theme_id
                                    INNER JOIN dbo.response ON dbo.question.question_id = dbo.response.question_id;
                                ";

            // Создаем SqlDataAdapter и передаем ему SQL-выражение и подключение
            SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, bd.connection);

            DataTable dataTable = new DataTable();

            // Заполняем DataTable данными из запроса
            adapter.Fill(dataTable);

            // Преобразование DataTable в JSON строку
            string json = JsonConvert.SerializeObject(dataTable);

            bd.closeBD();
            return json;
        }

        [HttpGet, Route("question_delete")]
        [Authorize(Roles = "teacher")]
        public object question_delete(int question_id)
        {
            BD bd = new BD();
            bd.connectionBD();

            try
            {
                string sqlExpression = @"DELETE FROM [test].[dbo].[question]
                    WHERE [question_id] = @question_id;
                   ";

                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@question_id", question_id);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch
            {
                return BadRequest(new { Message = "Виникла помилка" });
            }
            bd.closeBD();
            var message = new Message { message = "Операція успішна" };
            return Ok(message);
        }



    }
}
