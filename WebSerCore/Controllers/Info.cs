using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using WebSerCore.Class;

namespace WebSerCore.Controllers
{
    public class Info : Controller
    {
       

        [HttpGet, Route("InfoUser")]
        [Authorize]
        public object InfoUser(string nickname)
        {
            BD bd = new BD();
            bd.connectionBD();


            // Используйте параметризованный запрос, чтобы избежать SQL-инъекций
            string sqlExpression = "SELECT nickname, password, user_account_type, full_name FROM user_account WHERE nickname = @Nickname";

            //SqlCommand command = new SqlCommand(sqlExpression, connection);
            //command.Parameters.AddWithValue("@Nickname", nickname);
            object obj =null;
            using (SqlCommand command = new SqlCommand(sqlExpression, bd.connection))
            {
                command.Parameters.AddWithValue("@Nickname", nickname);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        obj = new
                        {
                            nickname = reader["nickname"].ToString(),
                            user_account_type = reader["user_account_type"].ToString(),
                            full_name = reader["full_name"].ToString()
                        };

                        //Console.WriteLine($"Nickname: {userAccount.nickname}, Password: {userAccount.password}, Type: {userAccount.user_account_type}, Full Name: {userAccount.full_name}");
                    }
                    //else
                    //{
                    //    Console.WriteLine($"User with nickname {nickname} not found.");
                    //}
                }
            }

            bd.closeBD();
            return obj;

        }
    }
}
