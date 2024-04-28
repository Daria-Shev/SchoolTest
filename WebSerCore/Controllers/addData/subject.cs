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
    public class subject : Controller
    {
        //даные в таблицу перенос  DataSource
        [HttpGet, Route("subject_table")]
        [Authorize(Roles = "teacher")]
        public object subject_table()
        {
            BD bd = new BD();
            bd.connectionBD();


            // Используйте параметризованный запрос, чтобы избежать SQL-инъекций
            string sqlExpression = "SELECT * FROM subject";

            // Создаем SqlDataAdapter и передаем ему SQL-выражение и подключение
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM subject", bd.connection);

            DataTable dataTable = new DataTable();

            // Заполняем DataTable данными из запроса
            adapter.Fill(dataTable);

            // Преобразование DataTable в JSON строку
            string json = JsonConvert.SerializeObject(dataTable);

            bd.closeBD();
            return json;

        }
        [HttpGet, Route("subject_add")]
        [Authorize(Roles = "teacher")]
        public object subject_add(int subject_id, string subject_name, int subject_class_number)
        {
            BD bd = new BD();
            bd.connectionBD();

            try
            {
                // Используйте параметризованный запрос, чтобы избежать SQL-инъекций
                string sqlExpression = @"MERGE INTO [test].[dbo].[subject] 
                    USING (VALUES (@subject_id, @subject_name, @subject_class_number))
                    ON subject_id = @subject_id
                    WHEN MATCHED THEN
                        UPDATE SET subject_name = @subject_name,
                                   subject_class_number = @subject_class_number
                    WHEN NOT MATCHED THEN
                        INSERT (subject_name, subject_class_number) 
                        VALUES (@subject_name, @subject_class_number);
                   ";

                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@subject_id", subject_id);
                    sqlCommand.Parameters.AddWithValue("@subject_name", subject_name);
                    sqlCommand.Parameters.AddWithValue("@subject_class_number", subject_class_number);

                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch 
            {
                return Results.BadRequest(new { Message = "Виникла помилка" });
            }
                        


            bd.closeBD();
            var message = new Message { message = "Операція успішна" };
            return Results.Ok(message);
        }

    }
}
