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
    public class theme : Controller
    {
        public class themeData
        {
            public int theme_id { get; set; }
            public string theme_name { get; set; }
            public int subject_id { get; set; }
        }

        //даные в таблицу перенос  DataSource
        [HttpGet, Route("theme_table")]
        [Authorize(Roles = "teacher")]
        public object theme_table()
        {
            BD bd = new BD();
            bd.connectionBD();


            // Используйте параметризованный запрос, чтобы избежать SQL-инъекций
            string sqlExpression = @"SELECT dbo.theme.theme_id, dbo.subject.subject_id, dbo.theme.theme_name, dbo.subject.subject_name
                         FROM dbo.theme INNER JOIN
                         dbo.subject ON dbo.theme.subject_id = dbo.subject.subject_id";

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

        [HttpGet, Route("theme_delete")]
        [Authorize(Roles = "teacher")]
        public object theme_delete(int theme_id)
        {
            BD bd = new BD();
            bd.connectionBD();

            try
            {
                string sqlExpression = @"DELETE FROM [test].[dbo].[theme]
                    WHERE [theme_id] = @theme_id;
                   ";

                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@theme_id", theme_id);
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

        [HttpGet, Route("theme_add")]
        [Authorize(Roles = "teacher")]
        public object theme_add(string jsonData)
        {
            // Десериализуем JSON строку в объект класса
            var classData = JsonConvert.DeserializeObject<themeData>(jsonData);


            BD bd = new BD();
            bd.connectionBD();

            try
            {
                string sqlExpression = @"MERGE INTO [test].[dbo].[theme] AS target
                        USING (VALUES (@theme_id, @theme_name, @subject_id)) 
                        AS source (theme_id, theme_name, subject_id)
                        ON target.theme_id = source.theme_id
                        WHEN MATCHED THEN
                            UPDATE SET target.theme_name = source.theme_name,
                                       target.subject_id = source.subject_id
                        WHEN NOT MATCHED THEN
                            INSERT (theme_name, subject_id) 
                            VALUES (source.theme_name, source.subject_id);
                   ";

                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@theme_id", classData.theme_id);
                    sqlCommand.Parameters.AddWithValue("@theme_name", classData.theme_name);
                    sqlCommand.Parameters.AddWithValue("@subject_id", classData.subject_id);

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
