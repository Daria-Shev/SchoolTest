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
    public class response : Controller
    {
        [HttpGet, Route("open_response_table")]
        [Authorize(Roles = "teacher")]
        public object open_response_table()
        {
            BD bd = new BD();
            bd.connectionBD();
            string sqlExpression = @"SELECT * FROM open_response";
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
            string sqlExpression = @"SELECT * FROM answer_options";
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
            string sqlExpression = @"SELECT * FROM sequence";
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
            string sqlExpression = @"SELECT * FROM matching";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlExpression, bd.connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            string json = JsonConvert.SerializeObject(dataTable);
            bd.closeBD();
            return json;
        }

    }
}
