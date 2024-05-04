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
    public class Class_school : Controller
    {
        public class ClassData
        {
            public int class_id { get; set; }
            public string class_name { get; set; }
            public int class_number { get; set; }
        }

        //даные в таблицу перенос  DataSource
        [HttpGet, Route("class_table")]
        [Authorize(Roles = "teacher")]
        public object class_table()
        {
            BD bd = new BD();
            bd.connectionBD();


            // Используйте параметризованный запрос, чтобы избежать SQL-инъекций
            string sqlExpression = "SELECT * FROM class";

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

        [HttpGet, Route("class_delete")]
        [Authorize(Roles = "teacher")]
        public object class_delete(int class_id)
        {
            BD bd = new BD();
            bd.connectionBD();

            try
            {
                string sqlExpression = @"DELETE FROM [test].[dbo].[class]
                    WHERE [class_id] = @class_id;
                   ";

                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@class_id", class_id);
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

        [HttpGet, Route("class_add")]
        [Authorize(Roles = "teacher")]
        public object class_add(string jsonData)
        {
            // Десериализуем JSON строку в объект класса
            var classData = JsonConvert.DeserializeObject<ClassData>(jsonData);


            BD bd = new BD();
            bd.connectionBD();

            try
            {
                string sqlExpression = @"MERGE INTO [test].[dbo].[class] AS target
                        USING (VALUES (@class_id, @class_name, @class_number)) 
                        AS source (class_id, class_name, class_number)
                        ON target.class_id = source.class_id
                        WHEN MATCHED THEN
                            UPDATE SET target.class_name = source.class_name,
                                       target.class_number = source.class_number
                        WHEN NOT MATCHED THEN
                            INSERT (class_name, class_number) 
                            VALUES (source.class_name, source.class_number);
                   ";

                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@class_id", classData.class_id);
                    sqlCommand.Parameters.AddWithValue("@class_name", classData.class_name);
                    sqlCommand.Parameters.AddWithValue("@class_number", classData.class_number);

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
