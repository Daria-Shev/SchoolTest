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

namespace WebSerCore.Controllers
{
    public class Statictics : Controller
    {
        [HttpGet, Route("statistics_student")]
        [Authorize]
        public object statistics_student(string jsonData)
        {
            var classData = JsonConvert.DeserializeObject<statistic>(jsonData);
            BD bd = new BD();
            bd.connectionBD();
            DataTable dataTable = new DataTable();

            string sqlExpression = @"
WITH MaxGrade AS (
    SELECT 
        sr.test_id, 
        MAX(sr.grade) AS max_grade
    FROM 
        dbo.student_result AS sr
    WHERE 
        sr.user_account_id = @user_account_id 
    GROUP BY 
        sr.test_id
)
SELECT 
    th.theme_id, 
    th.theme_name, 
    s.subject_id, 
    s.subject_name, 
    t.test_id, 
    t.class_id, 
    sr.user_account_id, 
    CASE 
        WHEN sr.grade = 1 THEN 'П'
        WHEN sr.grade = 2 THEN 'С'
        WHEN sr.grade = 3 THEN 'Д'
        WHEN sr.grade = 4 THEN 'В'
        ELSE 'Помилка'
    END AS grade
FROM 
    dbo.student_result AS sr
    INNER JOIN dbo.test AS t ON sr.test_id = t.test_id
    INNER JOIN dbo.theme AS th ON t.theme_id = th.theme_id
    INNER JOIN dbo.subject AS s ON th.subject_id = s.subject_id
    INNER JOIN MaxGrade AS mg ON sr.test_id = mg.test_id AND sr.grade = mg.max_grade
WHERE 
    sr.user_account_id = @user_account_id;


    ";

            using (SqlCommand command = new SqlCommand(sqlExpression, bd.connection))
            {
                command.Parameters.AddWithValue("@class_id", classData.class_id);
                command.Parameters.AddWithValue("@user_account_id", classData.user_account_id);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            // Преобразование DataTable в JSON строку
            string json = JsonConvert.SerializeObject(dataTable);

            bd.closeBD();
            return json;
        }
        private class statistic
        {
            public int user_account_id { get; set; }
            public int class_id { get; set; }
        }
    }
}
