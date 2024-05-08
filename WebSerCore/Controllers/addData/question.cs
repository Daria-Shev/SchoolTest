using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using WebSerCore.Class;
using Newtonsoft.Json;
using System;
using System.Data.SqlClient;
using System.Net.Mail;
using static WebSerCore.Controllers.addData.response;
using static WebSerCore.Controllers.addData.theme;

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
        public class questionData
        {
            public int theme_id { get; set; }
            public string question_text { get; set; }
            public int question_id { get; set; }
            public int points { get; set; }

        }
        [HttpGet, Route("question_add")]
        [Authorize(Roles = "teacher")]
        public object question_add(string jsonData)
        {
            // Десериализуем JSON строку в объект класса
            var classData = JsonConvert.DeserializeObject<questionData>(jsonData);


            BD bd = new BD();
            bd.connectionBD();

            try
            {
                string sqlExpression = @"
                MERGE INTO [test].[dbo].[question] AS target
                USING (
                    VALUES (
                        @question_id,
                        @theme_id,
                        @question_text,
                        @points
                    )
                ) AS source (question_id, theme_id, question_text, points)
                ON target.question_id = source.question_id
                WHEN MATCHED THEN
                    UPDATE SET 
                        target.theme_id = source.theme_id,
                        target.question_text = source.question_text,
                        target.points = source.points
                WHEN NOT MATCHED THEN
                    INSERT ( theme_id, question_text, points) 
                    VALUES ( source.theme_id, source.question_text,source.points);
                   ";

                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@question_id", classData.question_id);
                    sqlCommand.Parameters.AddWithValue("@theme_id", classData.theme_id);
                    sqlCommand.Parameters.AddWithValue("@question_text", classData.question_text);
                    sqlCommand.Parameters.AddWithValue("@points", classData.points);



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
