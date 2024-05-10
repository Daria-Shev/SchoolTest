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
    public class info_student : Controller
    {
        [HttpGet, Route("subject_list_student")]
        [Authorize]
        public object subject_list_student(string subject_class_number)
        {
            BD bd = new BD();
            bd.connectionBD();


            // Используйте параметризованный запрос, чтобы избежать SQL-инъекций
            string sqlExpression = @"
    SELECT subject_id, subject_name, subject_class_number
    FROM dbo.subject
    WHERE subject_class_number = @subject_class_number
";

            // Создаем SqlDataAdapter и передаем ему SQL-выражение и подключение
            SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, bd.connection);
            adapter.SelectCommand.Parameters.AddWithValue("@subject_class_number", subject_class_number);


            DataTable dataTable = new DataTable();

            // Заполняем DataTable данными из запроса
            adapter.Fill(dataTable);

            // Преобразование DataTable в JSON строку
            string json = JsonConvert.SerializeObject(dataTable);

            bd.closeBD();
            return json;
        }
        [HttpGet, Route("theme_list_student")]
        [Authorize]
        public object theme_list_student(string subject_class_number)
        {
            BD bd = new BD();
            bd.connectionBD();


            // Используйте параметризованный запрос, чтобы избежать SQL-инъекций
            string sqlExpression = @"
    SELECT dbo.subject.subject_class_number, dbo.theme.theme_id, dbo.theme.theme_name, dbo.theme.subject_id
    FROM dbo.subject
    INNER JOIN dbo.theme ON dbo.subject.subject_id = dbo.theme.subject_id
    WHERE dbo.subject.subject_class_number = @subject_class_number
";


            // Создаем SqlDataAdapter и передаем ему SQL-выражение и подключение
            SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, bd.connection);
            adapter.SelectCommand.Parameters.AddWithValue("@subject_class_number", subject_class_number);


            DataTable dataTable = new DataTable();

            // Заполняем DataTable данными из запроса
            adapter.Fill(dataTable);

            // Преобразование DataTable в JSON строку
            string json = JsonConvert.SerializeObject(dataTable);

            bd.closeBD();
            return json;

        }
    }
}
