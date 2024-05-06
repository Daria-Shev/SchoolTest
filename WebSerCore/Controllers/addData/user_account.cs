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
            string sqlExpression = @"SELECT dbo.user_account.user_account_id, dbo.user_account.user_account_type, dbo.user_account.nickname, dbo.user_account.password,  dbo.user_account.full_name, dbo.teacher.email_address
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
            string sqlExpression = @"SELECT        dbo.user_account.user_account_id, dbo.student.class_id, dbo.user_account.user_account_type, dbo.user_account.nickname, dbo.user_account.password,  dbo.user_account.full_name, dbo.student.student_email, 
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


        [HttpGet, Route("user_delete")]
        [Authorize(Roles = "teacher")]
        public object user_delete(int user_id)
        {
            BD bd = new BD();
            bd.connectionBD();

            try
            {
                string sqlExpression = @"DELETE FROM [test].[dbo].[user_account]
                    WHERE [user_account_id] = @user_id;
                   ";

                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@user_id", user_id);
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

        [HttpGet, Route("user_add")]
        [Authorize(Roles = "teacher")]
        public object user_add(string jsonData)
        {
            var classData = JsonConvert.DeserializeObject<tableDataUser>(jsonData);
            BD bd = new BD();
            bd.connectionBD();
            try
            {
                string sqlExpression = @"MERGE INTO [test].[dbo].[user_account] AS target
                        USING (VALUES (@user_account_id, @nickname, @password, @user_account_type, @full_name)) 
                        AS source (user_account_id, nickname, password, user_account_type, full_name)
                        ON target.user_account_id = source.user_account_id
                        WHEN MATCHED THEN
                            UPDATE SET target.nickname = source.nickname,
                                       target.password = source.password,
                                       target.user_account_type = source.user_account_type,
                                       target.full_name = source.full_name
                        WHEN NOT MATCHED THEN
                            INSERT (nickname, password, user_account_type, full_name) 
                            VALUES (source.nickname, source.password, source.user_account_type, source.full_name);
                   ";




                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {
                    sqlCommand.Parameters.AddWithValue("@user_account_id", classData.user_account_id);
                    sqlCommand.Parameters.AddWithValue("@nickname", classData.nickname);
                    sqlCommand.Parameters.AddWithValue("@password", classData.password);
                    sqlCommand.Parameters.AddWithValue("@user_account_type", classData.user_account_type);
                    sqlCommand.Parameters.AddWithValue("@full_name", classData.full_name);
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
        [HttpGet, Route("user_teacher_add")]
        [Authorize(Roles = "teacher")]
        public object user_teacher_add(string jsonData)
        {
            var classData = JsonConvert.DeserializeObject<tableDataUserTeacher>(jsonData);
            BD bd = new BD();
            bd.connectionBD();
            try
            {
                string sqlExpression = @"MERGE INTO teacher AS target
                    USING (VALUES (@user_account_id, @email_address)) AS source (user_account_id, email)
                    ON target.user_account_id = source.user_account_id
                    WHEN MATCHED THEN
                        UPDATE SET target.email_address = source.email
                    WHEN NOT MATCHED THEN
                        INSERT (user_account_id, email_address) VALUES (source.user_account_id, source.email);
                        ";

                if (classData.user_account_id == 0)
                {
                    string sqlGetLastId = "SELECT MAX(user_account_id) FROM user_account;";

                    // Выполняем запрос и получаем последний id
                    using (SqlCommand getLastIdCommand = new SqlCommand(sqlGetLastId, bd.connection))
                    {
                        object lastId = getLastIdCommand.ExecuteScalar();

                        // Проверяем, что lastId не равен DBNull
                        if (lastId != DBNull.Value)
                        {
                            classData.user_account_id = (int)lastId;
                        }
                    }
                }

                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {
                    sqlCommand.Parameters.AddWithValue("@user_account_id", classData.user_account_id);
                    sqlCommand.Parameters.AddWithValue("@email_address", classData.email_address);
                    
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
        [HttpGet, Route("user_student_add")]
        [Authorize(Roles = "teacher")]
        public object user_student_add(string jsonData)
        {
            var classData = JsonConvert.DeserializeObject<tableDataUserStudent>(jsonData);
            BD bd = new BD();
            bd.connectionBD();
            try
            {
                string sqlExpression = @"MERGE INTO student AS target
                        USING (VALUES (@user_account_id, @student_email, @parent_email, @class_id)) AS source (user_account_id, student_email, parent_email, class_id)
                        ON target.user_account_id = source.user_account_id
                        WHEN MATCHED THEN
                            UPDATE SET student_email = source.student_email, parent_email = source.parent_email, class_id = source.class_id
                        WHEN NOT MATCHED THEN
                            INSERT (user_account_id, student_email, parent_email, class_id)
                            VALUES (source.user_account_id, source.student_email, source.parent_email, source.class_id);
                        ";

                if (classData.user_account_id == 0)
                {
                    string sqlGetLastId = "SELECT MAX(user_account_id) FROM user_account;";

                    // Выполняем запрос и получаем последний id
                    using (SqlCommand getLastIdCommand = new SqlCommand(sqlGetLastId, bd.connection))
                    {
                        object lastId = getLastIdCommand.ExecuteScalar();

                        // Проверяем, что lastId не равен DBNull
                        if (lastId != DBNull.Value)
                        {
                            classData.user_account_id = (int)lastId;
                        }
                    }
                }

                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {
                    sqlCommand.Parameters.AddWithValue("@user_account_id", classData.user_account_id);
                    sqlCommand.Parameters.AddWithValue("@student_email", classData.student_email);
                    sqlCommand.Parameters.AddWithValue("@parent_email", classData.parent_email);
                    sqlCommand.Parameters.AddWithValue("@class_id", classData.class_id);


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
        private class tableDataUser
        {
            public int user_account_id { get; set; }
            public string nickname { get; set; }
            public string password { get; set; }
            public string user_account_type { get; set; }
            public string full_name { get; set; }
            public string email_address { get; set; }
            public string student_email { get; set; }
            public string parent_email { get; set; }
            public int class_id { get; set; }
        }
        private class tableDataUserTeacher
        {
            public int user_account_id { get; set; }
            public string email_address { get; set; }

        }
        private class tableDataUserStudent
        {
            public int user_account_id { get; set; }       
            public string student_email { get; set; }
            public string parent_email { get; set; }
            public int class_id { get; set; }
        }


    }
}
