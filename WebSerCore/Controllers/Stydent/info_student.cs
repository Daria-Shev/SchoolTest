using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using WebSerCore.Class;
using Newtonsoft.Json;
using System;
using System.Data.SqlClient;
using System.Net.Mail;
using static System.Net.Mime.MediaTypeNames;

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
        [HttpGet, Route("literature_table_student")]
        [Authorize]
        public object literature_table_student(string subject_class_number)
        {
            BD bd = new BD();
            bd.connectionBD();


            // Используйте параметризованный запрос, чтобы избежать SQL-инъекций
            string sqlExpression = @"
SELECT dbo.recommended_literature.theme_id, dbo.recommended_literature.literature_name, dbo.recommended_literature.literature_link
FROM dbo.recommended_literature
INNER JOIN dbo.theme ON dbo.recommended_literature.theme_id = dbo.theme.theme_id
WHERE dbo.recommended_literature.theme_id = @theme_id;
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

        [HttpGet, Route("check_literature")]
        [Authorize(Roles = "student")]
        public object check_literature(string id_theme)
        {
            BD bd = new BD();
            bd.connectionBD();
            string text = "";
            try
            {
                string sqlExpression = @"
                SELECT COUNT(*) AS CountOfRecords
                FROM [test].[dbo].[recommended_literature]
                WHERE theme_id = @theme_id
            ";
                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@theme_id", id_theme);
                    int count = Convert.ToInt32(sqlCommand.ExecuteScalar());

                    // Проверяем результат и отправляем сообщение в зависимости от него
                    if (count == 0)
                    {
                        text = "На жаль додаткова література не додана, зверніться до вчителя";
                    }
                }
            }
            catch{}
            bd.closeBD();
            var message = new Message { message = text };
            return Ok(message);
        }

        [HttpGet, Route("check_test")]
        [Authorize(Roles = "student")]
        public object check_test(string theme_id, string class_id)
        {
            BD bd = new BD();
            bd.connectionBD();
            string text = "";
            try
            {
                string sqlExpression = @"
                SELECT dbo.test.test_id, dbo.test.test_name, dbo.test.theme_id, dbo.test.test_type, dbo.test.class_id
                FROM dbo.test
                INNER JOIN dbo.theme ON dbo.test.theme_id = dbo.theme.theme_id
                WHERE dbo.test.theme_id = @theme_id
                AND dbo.test.test_type LIKE N'%Оцінювальний%' 
                AND dbo.test.class_id = @class_id;
                ";
                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@theme_id", theme_id);
                    sqlCommand.Parameters.AddWithValue("@class_id", class_id);

                    int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    if (count == 0)
                    {
                        text = "На жаль даний тест неактивований, зверніться до вчителя";
                    }
                }
            }
            catch { }
            bd.closeBD();
            var message = new Message { message = text };
            return Ok(message);
        }
        [HttpGet, Route("check_practice_test")]
        [Authorize(Roles = "student")]
        public object check_practice_test(string theme_id, string class_id)
        {
            BD bd = new BD();
            bd.connectionBD();
            string text = "";
            try
            {
                string sqlExpression = @"
                SELECT dbo.test.test_id, dbo.test.test_name, dbo.test.theme_id, dbo.test.test_type, dbo.test.class_id
                FROM dbo.test
                INNER JOIN dbo.theme ON dbo.test.theme_id = dbo.theme.theme_id
                WHERE dbo.test.theme_id = @theme_id
                AND dbo.test.test_type LIKE N'%Підготовчий%' 
                AND dbo.test.class_id = @class_id;
                ";
                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@theme_id", theme_id);
                    sqlCommand.Parameters.AddWithValue("@class_id", class_id);

                    int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                    if (count == 0)
                    {
                        text = "На жаль даний тест неактивований, зверніться до вчителя";
                    }
                }
            }
            catch { }
            bd.closeBD();
            var message = new Message { message = text };
            return Ok(message);
        }
    }
}
