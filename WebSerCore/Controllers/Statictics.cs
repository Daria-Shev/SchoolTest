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

        [HttpGet, Route("statistics_teacher")]
        [Authorize]
        public object statistics_teacher()
        {
            BD bd = new BD();
            bd.connectionBD();
            DataTable dataTable = new DataTable();

            string sqlExpression = @"
WITH MaxGradePerTest AS (
    SELECT 
        sr.test_id, 
        sr.user_account_id,
        sr.grade,
        ROW_NUMBER() OVER (PARTITION BY sr.user_account_id, sr.test_id ORDER BY sr.grade DESC) AS row_num
    FROM 
        dbo.student_result AS sr
)
SELECT 
    c.class_id, 
    s.user_account_id, 
    ua.full_name, 
    c.class_name, 
    sr.result_id, 
    CASE 
        WHEN sr.grade = 1 THEN 'П'
        WHEN sr.grade = 2 THEN 'С'
        WHEN sr.grade = 3 THEN 'Д'
        WHEN sr.grade = 4 THEN 'В'
        ELSE 'Помилка'
    END AS grade,
    su.subject_name,
    su.subject_id,
    th.theme_name,
    th.theme_id,
    t.test_id
FROM 
    dbo.theme AS th
INNER JOIN 
    dbo.subject AS su ON th.subject_id = su.subject_id
INNER JOIN 
    dbo.test AS t ON th.theme_id = t.theme_id
INNER JOIN 
    dbo.class AS c ON t.class_id = c.class_id
INNER JOIN 
    dbo.student AS s ON c.class_id = s.class_id
INNER JOIN 
    dbo.user_account AS ua ON s.user_account_id = ua.user_account_id
INNER JOIN 
    dbo.student_result AS sr ON s.user_account_id = sr.user_account_id AND t.test_id = sr.test_id
INNER JOIN 
    MaxGradePerTest AS mg ON sr.test_id = mg.test_id AND sr.user_account_id = mg.user_account_id AND sr.grade = mg.grade
WHERE
    mg.row_num = 1;
    ";

            using (SqlCommand command = new SqlCommand(sqlExpression, bd.connection))
            {
               

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

    }
}
