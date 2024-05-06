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
    public class user_account : Controller
    {
        [HttpGet, Route("user_table_teacher")]
        [Authorize(Roles = "teacher")]
        public object user_table_teacher()
        {
            BD bd = new BD();
            bd.connectionBD();
            // Используйте параметризованный запрос, чтобы избежать SQL-инъекций
            string sqlExpression = @"SELECT dbo.user_account.user_account_id, dbo.user_account.nickname, dbo.user_account.password, dbo.user_account.user_account_type, dbo.user_account.full_name, dbo.teacher.email_address
                         FROM  dbo.user_account INNER JOIN
                         dbo.teacher ON dbo.user_account.user_account_id = dbo.teacher.user_account_id";

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
        [HttpGet, Route("user_table_student")]
        [Authorize(Roles = "teacher")]
        public object user_table_student()
        {
            BD bd = new BD();
            bd.connectionBD();


            // Используйте параметризованный запрос, чтобы избежать SQL-инъекций
            string sqlExpression = @"SELECT        dbo.user_account.user_account_id, dbo.student.class_id, dbo.user_account.nickname, dbo.user_account.password, dbo.user_account.user_account_type, dbo.user_account.full_name, dbo.student.student_email, 
                         dbo.student.parent_email, dbo.class.class_name
                         FROM dbo.student INNER JOIN
                         dbo.user_account ON dbo.student.user_account_id = dbo.user_account.user_account_id INNER JOIN
                         dbo.class ON dbo.student.class_id = dbo.class.class_id";

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
