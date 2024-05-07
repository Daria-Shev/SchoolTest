using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using WebSerCore.Class;
using Newtonsoft.Json;
using System;
using System.Data.SqlClient;
using System.Net.Mail;
using static WebSerCore.Controllers.addData.theme;

namespace WebSerCore.Controllers.addData
{
    public class response : Controller
    {
        [HttpGet, Route("open_response_table")]
        [Authorize(Roles = "teacher")]
        public object open_response_table()
        {
            BD bd = new BD();
            bd.connectionBD();
            string sqlExpression = @"SELECT        dbo.response.question_id, dbo.open_response.*
                         FROM dbo.open_response INNER JOIN
                         dbo.response ON dbo.open_response.response_id = dbo.response.response_id";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, bd.connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            string json = JsonConvert.SerializeObject(dataTable);
            bd.closeBD();
            return json;
        }

        [HttpGet, Route("answer_options_table")]
        [Authorize(Roles = "teacher")]
        public object answer_options_table()
        {
            BD bd = new BD();
            bd.connectionBD();
            string sqlExpression = @"SELECT        dbo.answer_options.*, dbo.response.question_id
                         FROM  dbo.answer_options INNER JOIN
                         dbo.response ON dbo.answer_options.response_id = dbo.response.response_id";

            SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, bd.connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            string json = JsonConvert.SerializeObject(dataTable);
            bd.closeBD();
            return json;
        }

        [HttpGet, Route("sequence_table")]
        [Authorize(Roles = "teacher")]
        public object sequence_table()
        {
            BD bd = new BD();
            bd.connectionBD();
            string sqlExpression = @"SELECT        dbo.response.question_id, dbo.sequence.*
                         FROM  dbo.response INNER JOIN
                         dbo.sequence ON dbo.response.response_id = dbo.sequence.response_id";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, bd.connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            string json = JsonConvert.SerializeObject(dataTable);
            bd.closeBD();
            return json;
        }

        [HttpGet, Route("matching_table")]
        [Authorize(Roles = "teacher")]
        public object matching_table()
        {
            BD bd = new BD();
            bd.connectionBD();
            string sqlExpression = @"SELECT        dbo.response.question_id, dbo.matching.*
                         FROM  dbo.response INNER JOIN
                         dbo.matching ON dbo.response.response_id = dbo.matching.response_id";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, bd.connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            string json = JsonConvert.SerializeObject(dataTable);
            bd.closeBD();
            return json;
        }

        [HttpGet, Route("response_delete")]
        [Authorize(Roles = "teacher")]
        public object response_delete(int response_id)
        {
            BD bd = new BD();
            bd.connectionBD();

            try
            {
                string sqlExpression = @"DELETE FROM [test].[dbo].[response]
                    WHERE [response_id] = @response_id;
                   ";

                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@response_id", response_id);
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

        [HttpGet, Route("response_add")]
        [Authorize(Roles = "teacher")]
        public object response_add(string jsonData)
        {
            // Десериализуем JSON строку в объект класса
            var classData = JsonConvert.DeserializeObject<responseData>(jsonData);


            BD bd = new BD();
            bd.connectionBD();

            try
            {
                string sqlExpression = @"
    MERGE INTO [test].[dbo].[response] AS target
    USING (VALUES (@response_id, @question_id, @response_type)) 
    AS source (response_id, question_id, response_type)
    ON target.response_id = source.response_id
    WHEN MATCHED THEN
        UPDATE SET 
            target.question_id = source.question_id,
            target.response_type = source.response_type
    WHEN NOT MATCHED THEN
        INSERT (response_id, question_id, response_type) 
        VALUES (source.response_id, source.question_id, source.response_type);
";



                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@response_id", classData.response_id);
                    sqlCommand.Parameters.AddWithValue("@question_id", classData.question_id);
                    sqlCommand.Parameters.AddWithValue("@response_type", classData.response_type);
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
        public class responseData
        {
            public int response_id { get; set; }
            public int question_id { get; set; }
            public string response_type { get; set; }
        }

        public class matchingData
        {
            public int response_id { get; set; }
            public int matching_number { get; set; }
            public string option_text { get; set; }
            public string matching_text { get; set; }
        }

        [HttpGet, Route("matching_add")]
        [Authorize(Roles = "teacher")]
        public object matching_add(string jsonData)
        {
            // Десериализуем JSON строку в объект класса
            var classData = JsonConvert.DeserializeObject<matchingData>(jsonData);


            BD bd = new BD();
            bd.connectionBD();

            try
            {
                string sqlExpression = @"
                    MERGE INTO [test].[dbo].[matching] AS target
                    USING (VALUES (@response_id, @matching_number, @option_text, @matching_text)) 
                    AS source (response_id, matching_number, option_text, matching_text)
                    ON target.response_id = source.response_id
                    WHEN MATCHED THEN
                        UPDATE SET 
                            target.matching_number = source.matching_number,
                            target.option_text = source.option_text,
                            target.matching_text = source.matching_text
                    WHEN NOT MATCHED THEN
                        INSERT (response_id, matching_number, option_text, matching_text) 
                        VALUES (source.response_id, source.matching_number, source.option_text, source.matching_text);
                ";


                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@response_id", classData.response_id);
                    sqlCommand.Parameters.AddWithValue("@matching_number", classData.matching_number);
                    sqlCommand.Parameters.AddWithValue("@option_text", classData.option_text);
                    sqlCommand.Parameters.AddWithValue("@matching_text", classData.matching_text);
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
        [HttpGet, Route("sequence_add")]
        [Authorize(Roles = "teacher")]
        public object sequence_add(string jsonData)
        {
            // Десериализуем JSON строку в объект класса
            var classData = JsonConvert.DeserializeObject<sequenceData>(jsonData);


            BD bd = new BD();
            bd.connectionBD();

            try
            {
                string sqlExpression = @"
    MERGE INTO [test].[dbo].[sequence] AS target
    USING (VALUES (@response_id, @sequence_number, @sequence_text)) 
    AS source (response_id, sequence_number, sequence_text)
    ON target.response_id = source.response_id
    WHEN MATCHED THEN
        UPDATE SET 
            target.sequence_number = source.sequence_number,
            target.sequence_text = source.sequence_text
    WHEN NOT MATCHED THEN
        INSERT (response_id, sequence_number, sequence_text) 
        VALUES (source.response_id, source.sequence_number, source.sequence_text);
";



                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@response_id", classData.response_id);
                    sqlCommand.Parameters.AddWithValue("@sequence_number", classData.sequence_number);
                    sqlCommand.Parameters.AddWithValue("@sequence_text", classData.sequence_text);
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
        public class sequenceData
        {
            public int response_id { get; set; }
            public int sequence_number { get; set; }
            public string sequence_text { get; set; }
        }
        [HttpGet, Route("answer_options_add")]
        [Authorize(Roles = "teacher")]
        public object answer_options_add(string jsonData)
        {
            // Десериализуем JSON строку в объект класса
            var classData = JsonConvert.DeserializeObject<answer_optionsData>(jsonData);
            BD bd = new BD();
            bd.connectionBD();
            try
            {
                string sqlExpression = @"
                    MERGE INTO [test].[dbo].[answer_options] AS target
                    USING (VALUES (@response_id, @option_number, @correct_option, @option_text)) 
                    AS source (response_id, option_number, correct_option, option_text)
                    ON target.response_id = source.response_id
                    WHEN MATCHED THEN
                        UPDATE SET 
                            target.option_number = source.option_number,
                            target.correct_option = source.correct_option,
                            target.option_text = source.option_text
                    WHEN NOT MATCHED THEN
                        INSERT (response_id, option_number, correct_option, option_text) 
                        VALUES (source.response_id, source.option_number, source.correct_option, source.option_text);
                ";
                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@response_id", classData.response_id);
                    sqlCommand.Parameters.AddWithValue("@option_number", classData.option_number);
                    sqlCommand.Parameters.AddWithValue("@correct_option", classData.correct_option);
                    sqlCommand.Parameters.AddWithValue("@option_text", classData.option_text);

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

        public class answer_optionsData
        {
            public int response_id { get; set; }
            public int option_number { get; set; }
            public string correct_option { get; set; }
            public string option_text { get; set; }

        }
        [HttpGet, Route("open_response_add")]
        [Authorize(Roles = "teacher")]
        public object open_response_add(string jsonData)
        {
            // Десериализуем JSON строку в объект класса
            var classData = JsonConvert.DeserializeObject<open_responseData>(jsonData);
            BD bd = new BD();
            bd.connectionBD();
            try
            {
                string sqlExpression = @"
                    MERGE INTO [test].[dbo].[open_response] AS target
                    USING (VALUES (@response_id, @correct_response)) 
                    AS source (response_id, correct_response)
                    ON target.response_id = source.response_id
                    WHEN MATCHED THEN
                        UPDATE SET 
                            target.correct_response = source.correct_response
                    WHEN NOT MATCHED THEN
                        INSERT (response_id, correct_response) 
                        VALUES (source.response_id, source.correct_response);
                ";

                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {

                    sqlCommand.Parameters.AddWithValue("@response_id", classData.response_id);
                    sqlCommand.Parameters.AddWithValue("@correct_response", classData.correct_response);


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
        public class open_responseData
        {
            public int response_id { get; set; }
            public string correct_response { get; set; }

        }

    }
}
