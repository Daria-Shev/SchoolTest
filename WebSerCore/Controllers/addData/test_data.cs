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
                         dbo.user_account.full_name,  dbo.subject.subject_name
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

    }
}
