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
    public class lit : Controller
    {
        private class tableData
        {
            public int theme_id { get; set; }
            public string literature_name { get; set; }
            public string literature_link { get; set; }
            public int literature_id { get; set; }
        }

        //даные в таблицу перенос  DataSource
        [HttpGet, Route("lit_table")]
        [Authorize(Roles = "teacher")]
        public object lit_table()
        {
            BD bd = new BD();
            bd.connectionBD();


            // Используйте параметризованный запрос, чтобы избежать SQL-инъекций
            string sqlExpression = @"SELECT        dbo.recommended_literature.literature_id, dbo.subject.subject_id, dbo.theme.theme_id, dbo.recommended_literature.literature_name, dbo.recommended_literature.literature_link, dbo.theme.theme_name, 
                         dbo.subject.subject_name
                         FROM    dbo.recommended_literature INNER JOIN
                         dbo.theme ON dbo.recommended_literature.theme_id = dbo.theme.theme_id INNER JOIN
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

        [HttpGet, Route("lit_delete")]
        [Authorize(Roles = "teacher")]
        public object lit_delete(int literature_id)
        {
            BD bd = new BD();
            bd.connectionBD();

            try
            {
                string sqlExpression = @"DELETE FROM [test].[dbo].[recommended_literature]
                    WHERE [literature_id] = @literature_id;
                   ";

                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@literature_id", literature_id);
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

        [HttpGet, Route("lit_add")]
        [Authorize(Roles = "teacher")]
        public object lit_add(string jsonData)
        {
            // Десериализуем JSON строку в объект класса
            var classData = JsonConvert.DeserializeObject<tableData>(jsonData);


            BD bd = new BD();
            bd.connectionBD();

            try
            {
                string sqlExpression = @"MERGE INTO [test].[dbo].[recommended_literature] AS target
                        USING (VALUES (@literature_id, @literature_name, @literature_link, @theme_id)) 
                        AS source (literature_id, literature_name, literature_link, theme_id)
                        ON target.literature_id = source.literature_id
                        WHEN MATCHED THEN
                            UPDATE SET target.literature_name = source.literature_name,
                                       target.literature_link = source.literature_link,
                                       target.theme_id = source.theme_id
                        WHEN NOT MATCHED THEN
                            INSERT (literature_name, literature_link, theme_id) 
                            VALUES (source.literature_name, source.literature_link, source.theme_id);
                   ";


                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@literature_id", classData.literature_id);
                    sqlCommand.Parameters.AddWithValue("@literature_name", classData.literature_name);
                    sqlCommand.Parameters.AddWithValue("@literature_link", classData.literature_link);
                    sqlCommand.Parameters.AddWithValue("@theme_id", classData.theme_id);

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
