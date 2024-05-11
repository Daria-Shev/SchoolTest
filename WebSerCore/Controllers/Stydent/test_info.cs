using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using WebSerCore.Class;
using Newtonsoft.Json;
using System;
using System.Data.SqlClient;
using System.Net.Mail;
//using static System.Net.Mime.MediaTypeNames;
namespace WebSerCore.Controllers.Stydent
{
    public class test_info : Controller
    {
        [HttpGet, Route("InfoTest")]
        [Authorize]
        public object InfoTest(string theme_id, string class_id, string test_type)
        {
            BD bd = new BD();
            bd.connectionBD();

            string sqlExpression = @"
        SELECT dbo.test.test_id, dbo.test.test_name, dbo.test.theme_id, dbo.test.test_type, dbo.test.class_id, 
        dbo.test.execution_time, dbo.test.attempt_count, dbo.theme.theme_name
        FROM dbo.test
        INNER JOIN dbo.theme ON dbo.test.theme_id = dbo.theme.theme_id
        WHERE dbo.test.theme_id = @theme_id
        AND dbo.test.test_type LIKE '%' + @test_type + '%' 
        AND dbo.test.class_id = @class_id;
    ";

            object obj = null;
            using (SqlCommand command = new SqlCommand(sqlExpression, bd.connection))
            {
                command.Parameters.AddWithValue("@theme_id", theme_id);
                command.Parameters.AddWithValue("@class_id", class_id);
                command.Parameters.AddWithValue("@test_type", test_type);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        obj = new
                        {
                            test_id = reader["test_id"].ToString(),
                            test_name = reader["test_name"].ToString(),
                            execution_time = reader["execution_time"].ToString(),
                            attempt_count = reader["attempt_count"].ToString(),
                            theme_name = reader["theme_name"].ToString()
                        };
                    }
                }
            }

            bd.closeBD();
            return obj;
        }



        [HttpGet, Route("check_attempts_used_test")]
        [Authorize(Roles = "student")]
        public object check_attempts_used_test(string test_id, string user_account_id)
        {
            BD bd = new BD();
            bd.connectionBD();
            object obj = null;

            try
            {
                string sqlExpression = @"
            SELECT
                dbo.test.test_id,
                dbo.student_result.result_id,
                dbo.student_result.user_account_id,
                dbo.student_result.grade,
                -- Получаем количество записей для заданного test_id
                (SELECT COUNT(*) FROM dbo.student_result WHERE test_id = @test_id) AS count_of_records,
                -- Получаем максимальное значение grade для заданного test_id
                (SELECT MAX(grade) FROM dbo.student_result WHERE test_id = @test_id) AS max_grade
            FROM
                dbo.test
            INNER JOIN
                dbo.student_result ON dbo.test.test_id = dbo.student_result.test_id
            WHERE
                dbo.test.test_id = @test_id
                AND dbo.student_result.user_account_id = @user_account_id;
                ";

                using (SqlCommand command = new SqlCommand(sqlExpression, bd.connection))
                {
                    command.Parameters.AddWithValue("@test_id", test_id);
                    command.Parameters.AddWithValue("@user_account_id", user_account_id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            obj = new
                            {
                                attempts_used = reader["count_of_records"].ToString(),
                                max_grade = reader["max_grade"].ToString(),
                            };
                        }
                        else
                        {
                            obj = new
                            {
                                attempts_used = "0",
                                max_grade = "0",
                            };
                        }
                    }
                }
            }
            catch { }
            bd.closeBD();
            return obj;
        }

    }
}
