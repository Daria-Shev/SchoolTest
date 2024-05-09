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
    public class test_data : Controller
    {
        [HttpGet, Route("test_table")]
        [Authorize(Roles = "teacher")]
        public object test_table()
        {
            BD bd = new BD();
            bd.connectionBD();


            // Используйте параметризованный запрос, чтобы избежать SQL-инъекций
            string sqlExpression = @"SELECT       dbo.subject.subject_id, dbo.test.test_id, dbo.test.class_id, dbo.test.user_account_id, dbo.test.theme_id, dbo.test.test_name, dbo.test.execution_time, dbo.test.attempt_count, dbo.test.test_type, dbo.class.class_name, dbo.test.creation_date, 
                         dbo.user_account.full_name, dbo.theme.theme_name, dbo.subject.subject_name
FROM            dbo.test INNER JOIN
                         dbo.theme ON dbo.test.theme_id = dbo.theme.theme_id INNER JOIN
                         dbo.user_account ON dbo.test.user_account_id = dbo.user_account.user_account_id INNER JOIN
                         dbo.class ON dbo.test.class_id = dbo.class.class_id INNER JOIN
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
        [HttpGet, Route("test_delete")]
        [Authorize(Roles = "teacher")]
        public object test_delete(int test_id)
        {
            BD bd = new BD();
            bd.connectionBD();

            try
            {
                string sqlExpression = @"DELETE FROM [test].[dbo].[test]
                    WHERE [test_id] = @test_id;
                   ";

                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@test_id", test_id);
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
        [HttpGet, Route("test_add")]
        [Authorize(Roles = "teacher")]
        public object test_add(string jsonData)
        {
            // Десериализуем JSON строку в объект класса
            var classData = JsonConvert.DeserializeObject<tableTestData>(jsonData);


            BD bd = new BD();
            bd.connectionBD();

            try
            {
                string sqlExpression = @"
                    MERGE INTO [test].[dbo].[test] AS target
                    USING (
                        SELECT 
                            [user_account_id]
                        FROM [test].[dbo].[user_account]
                        WHERE [nickname] = @nickname
                    ) AS user_account_id_data
                    ON target.test_id = @test_id
                    WHEN MATCHED THEN
                        UPDATE SET target.class_id = @class_id,
                                   target.test_name = @test_name,
                                   target.theme_id = @theme_id,
                                   target.creation_date = @creation_date,
                                   target.execution_time = @execution_time,
                                   target.attempt_count = @attempt_count,
                                   target.user_account_id = user_account_id_data.user_account_id,
                                   target.test_type = @test_type
                    WHEN NOT MATCHED THEN
                        INSERT (class_id, test_name, theme_id, creation_date, execution_time, attempt_count, user_account_id, test_type) 
                        VALUES (@class_id, @test_name, @theme_id, @creation_date, @execution_time, @attempt_count, user_account_id_data.user_account_id, @test_type);
                ";
                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@test_id", classData.test_id);
                    sqlCommand.Parameters.AddWithValue("@test_name", classData.test_name);
                    sqlCommand.Parameters.AddWithValue("@execution_time", classData.execution_time);
                    sqlCommand.Parameters.AddWithValue("@attempt_count", classData.attempt_count);
                    sqlCommand.Parameters.AddWithValue("@user_nickname", classData.user_nickname);
                    sqlCommand.Parameters.AddWithValue("@test_type", classData.test_type);
                    sqlCommand.Parameters.AddWithValue("@creation_date", classData.creation_date);
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
        private class tableTestData
        {
            public int test_id { get; set; }
            public string test_name { get; set; }

            public int execution_time { get; set; }
            public int attempt_count { get; set; }
            public int theme_id { get; set; }

            public string user_nickname { get; set; }

            public string test_type { get; set; }
            public DateTime creation_date { get; set; }
        }


    }
}
