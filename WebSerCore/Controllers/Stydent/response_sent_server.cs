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
    public class response_sent_server : Controller
    {
        [HttpGet, Route("open_response_sent_to_server")]
        [Authorize]
        public object open_response_sent_to_server(string jsonData)
        {
            // Десериализуем JSON строку в объект класса
            var classData = JsonConvert.DeserializeObject<open_respons>(jsonData);
            BD bd = new BD();
            bd.connectionBD();

            try
            {
                int correctness = 0;
                string sqlExpression = @"
                    SELECT correct_response
                    FROM dbo.open_response
                    WHERE response_id = @response_id;
                ";
                using (SqlCommand command = new SqlCommand(sqlExpression, bd.connection))
                {
                    command.Parameters.AddWithValue("@response_id", classData.response_id);
                    

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (classData.user_response == reader["correct_response"].ToString())
                            {
                                correctness = 1;
                            }

                        }
                    }
                }
                sqlExpression = @"
INSERT INTO dbo.student_answers (correctness, test_id, question_id, user_account_id, test_attempt)
SELECT @correctness, @test_id, r.question_id, @user_account_id, @test_attempt
FROM dbo.response r
WHERE r.response_id = @response_id;

                ";
                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@correctness", correctness);
                    sqlCommand.Parameters.AddWithValue("@test_id", classData.test_id);
                    sqlCommand.Parameters.AddWithValue("@response_id", classData.response_id);
                    sqlCommand.Parameters.AddWithValue("@user_account_id", classData.user_account_id);
                    sqlCommand.Parameters.AddWithValue("@test_attempt", classData.test_attempt);

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

        [HttpGet, Route("answer_options_sent_to_server")]
        [Authorize]
        public object answer_options_sent_to_server(string jsonData)
        {
            // Десериализуем JSON строку в объект класса
            var classData = JsonConvert.DeserializeObject<answer_options>(jsonData);
            BD bd = new BD();
            bd.connectionBD();

            try
            {
                int totalOptions = 0;
                int correctOptions = 0;
                double correctness = 0;

                string sqlExpression = @"
INSERT INTO dbo.student_answers (correctness, test_id, question_id, user_account_id, question_end)
SELECT @correctness, @test_id, r.question_id, @user_account_id, GETDATE()
FROM dbo.response r
WHERE r.response_id = @response_id;

        ";

                // Перебираем каждый response_id из списка
                foreach (int responseId in classData.response_id)
                {
                    using (SqlCommand command = new SqlCommand(sqlExpression, bd.connection))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@response_id", responseId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                totalOptions++;
                                string correctResponseFromDB = reader["correct_option"].ToString();
                                string userResponse = classData.correct_option[totalOptions - 1]; // По индексу, так как мы читаем по порядку
                                if (userResponse == correctResponseFromDB)
                                {
                                    correctOptions++;
                                }
                            }
                        }
                    }
                }

                if (totalOptions > 0)
                {
                    correctness = (double)correctOptions / totalOptions;
                }
                sqlExpression = @"
INSERT INTO dbo.student_answers (correctness, test_id, question_id, user_account_id, test_attempt)
SELECT @correctness, @test_id, r.question_id, @user_account_id, @test_attempt
FROM dbo.response r
WHERE r.response_id = @response_id;

                ";
                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@correctness", correctness);
                    sqlCommand.Parameters.AddWithValue("@test_id", classData.test_id);
                    sqlCommand.Parameters.AddWithValue("@response_id", classData.response_id[0]);
                    sqlCommand.Parameters.AddWithValue("@user_account_id", classData.user_account_id);
                    sqlCommand.Parameters.AddWithValue("@test_attempt", classData.test_attempt);

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

        [HttpGet, Route("sequence_sent_to_server")]
        [Authorize]
        public object sequence_sent_to_server(string jsonData)
        {
            // Десериализуем JSON строку в объект класса
            var classData = JsonConvert.DeserializeObject<sequence>(jsonData);
            BD bd = new BD();
            bd.connectionBD();

            try
            {
                int totalOptions = 0;
                int correctOptions = 0;
                double correctness = 0;

                string sqlExpression = @"
INSERT INTO dbo.student_answers (correctness, test_id, question_id, user_account_id, question_end)
SELECT @correctness, @test_id, r.question_id, @user_account_id, GETDATE()
FROM dbo.response r
WHERE r.response_id = @response_id;

        ";

                // Перебираем каждый response_id из списка
                foreach (int responseId in classData.response_id)
                {
                    using (SqlCommand command = new SqlCommand(sqlExpression, bd.connection))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@response_id", responseId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                totalOptions++;
                                string correctResponseFromDB = reader["sequence_text"].ToString();
                                string userResponse = classData.sequence_text[totalOptions - 1]; // По индексу, так как мы читаем по порядку
                                if (userResponse == correctResponseFromDB)
                                {
                                    correctOptions++;
                                }
                            }
                        }
                    }
                }

                if (totalOptions > 0)
                {
                    correctness = (double)correctOptions / totalOptions;
                }
                sqlExpression = @"
INSERT INTO dbo.student_answers (correctness, test_id, question_id, user_account_id, test_attempt)
SELECT @correctness, @test_id, r.question_id, @user_account_id, @test_attempt
FROM dbo.response r
WHERE r.response_id = @response_id;

                ";
                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@correctness", correctness);
                    sqlCommand.Parameters.AddWithValue("@test_id", classData.test_id);
                    sqlCommand.Parameters.AddWithValue("@response_id", classData.response_id[0]);
                    sqlCommand.Parameters.AddWithValue("@user_account_id", classData.user_account_id);
                    sqlCommand.Parameters.AddWithValue("@test_attempt", classData.test_attempt);

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

        [HttpGet, Route("matching_sent_to_server")]
        [Authorize]
        public object matching_sent_to_server(string jsonData)
        {
            var classData = JsonConvert.DeserializeObject<matching>(jsonData);
            BD bd = new BD();
            bd.connectionBD();

            try
            {
                int totalOptions = 0;
                int correctOptions = 0;
                double correctness = 0;

                string sqlExpression = @"
SELECT        dbo.response.response_id AS Expr1, dbo.matching.matching_number, dbo.matching.option_text, dbo.matching.matching_text
FROM            dbo.matching INNER JOIN
                         dbo.response ON dbo.matching.response_id = dbo.response.response_id
            WHERE dbo.matching.response_id = @response_id;
        ";

                // Перебираем каждый response_id из списка
                foreach (int responseId in classData.response_id)
                {
                    using (SqlCommand command = new SqlCommand(sqlExpression, bd.connection))
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@response_id", responseId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                totalOptions++;
                                string correctResponseFromDB = reader["option_text"].ToString();
                                string userResponse = classData.option_text[totalOptions - 1]; // По индексу, так как мы читаем по порядку
                                if (userResponse == correctResponseFromDB)
                                {
                                    correctOptions++;
                                }
                            }
                        }
                    }
                }

                if (totalOptions > 0)
                {
                    correctness = (double)correctOptions / totalOptions;
                }
                sqlExpression = @"
                INSERT INTO dbo.student_answers (correctness, test_id, question_id, user_account_id, test_attempt)
                SELECT @correctness, @test_id, r.question_id, @user_account_id, @test_attempt
                FROM dbo.response r
                WHERE r.response_id = @response_id;
                ";
                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@correctness", correctness);
                    sqlCommand.Parameters.AddWithValue("@test_id", classData.test_id);
                    sqlCommand.Parameters.AddWithValue("@response_id", classData.response_id[0]);
                    sqlCommand.Parameters.AddWithValue("@user_account_id", classData.user_account_id);
                    sqlCommand.Parameters.AddWithValue("@test_attempt", classData.test_attempt);

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

        [HttpGet, Route("test_end")]
        [Authorize]
        public object test_end(string jsonData)
        {
            var classData = JsonConvert.DeserializeObject<test_result>(jsonData);
            BD bd = new BD();
            bd.connectionBD();
            int grade=0;

            try
            {
                int test_points=0;
                int user_points=0;
                string question_id_list = string.Join(",", classData.question_id.Select(id => "@question_id" + id)); // Создаем список параметров вида "@questionId1,@questionId2,@questionId3,..."

                string sqlExpression = @"
        SELECT 
            q.question_id,
            SUM(q.points) AS test_points,
            SUM(q.points * sa.correctness) AS user_points
        FROM 
            dbo.question q
            JOIN dbo.student_answers sa ON q.question_id = sa.question_id
        WHERE 
        q.question_id IN (" + question_id_list + @")
        GROUP BY 
            q.question_id;
    ";

                using (SqlCommand command = new SqlCommand(sqlExpression, bd.connection))
                {
                    for (int i = 0; i < classData.question_id.Count; i++)
                    {
                        command.Parameters.AddWithValue("@question_id" + classData.question_id[i], classData.question_id[i]);
                    }
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                             test_points = (int)reader["test_points"];
                             user_points = (int)reader["user_points"];

                        }
                    }
                }
                double ratio = (double)user_points / test_points;


                switch (ratio)
                {
                    case var _ when ratio >= 0.75:
                        grade = 4;
                        break;
                    case var _ when ratio >= 0.5:
                        grade = 3;
                        break;
                    case var _ when ratio >= 0.25:
                        grade = 2;
                        break;
                    default:
                        grade = 1;
                        break;
                }


                sqlExpression = @"
                INSERT INTO [test].[dbo].[student_result] (test_id, grade, test_end, user_account_id, test_attempt)
                VALUES ( @test_id, @grade, GETDATE(), @user_account_id, @test_attempt);

                ";
                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@test_id", classData.test_id);
                    sqlCommand.Parameters.AddWithValue("@grade", grade);
                    sqlCommand.Parameters.AddWithValue("@user_account_id", classData.user_account_id);
                    sqlCommand.Parameters.AddWithValue("@test_attempt", classData.test_attempt);

                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch
            {            }
            bd.closeBD();
            var message = new Message { message = "Вітаю! Ви пройшли тест. Ваш рівень володіння темою: " + grade_number_string(grade) };
            return Ok(message);

        }
        private string grade_number_string(int grade_number)
        {
            string grade = "";
            switch (grade_number)
            {
                case 1:
                    grade = "П (початковий рівень)";
                    break;
                case 2:
                    grade = "С (середній рівень)";
                    break;
                case 3:
                    grade = "Д (достатній рівень)";
                    break;
                case 4:
                    grade = "В (високий рівень)";
                    break;
            }
            return grade;
        }


        private class response
        {
            public int user_account_id { get; set; }
            public int test_id { get; set; }

            public int test_attempt { get; set; }
        }
        private class test_result:response
        {
            public List<int> question_id { get; set; }

        }
        private class open_respons: response
        {
            public int response_id { get; set; }
            public string user_response { get; set; }
        }
        private class answer_options : response
        {
            public List<int> response_id = new List<int>();
            public List<string> option_text = new List<string>();
            public List<string> correct_option = new List<string>();

        }
        private class sequence : response
        {
            public List<int> response_id = new List<int>();
            public List<string> sequence_text = new List<string>();
        }
        private class matching : response
        {
            public List<int> response_id = new List<int>();
            public List<string> option_text = new List<string>();
            public List<string> matching_text = new List<string>();

        }
    }
}
