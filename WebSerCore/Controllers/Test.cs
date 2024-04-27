using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using WebSerCore.Class;

namespace WebSerCore.Controllers
{
    public class Test : Controller
    {

        [HttpGet, Route("hello")]
        public object hello()
        {
            return new Message { message = "Привіт!" };
        }
        [HttpGet, Route("helloUser")]
        [Authorize]
        public Message helloUser()
        {
            return new Message { message = "Привіт користувач!" };

        }
        [HttpGet, Route("helloTeacher")]
        [Authorize(Roles = "teacher")]
        public Message helloTeacher()
        {
            return new Message { message = "Привіт вчитель!" }; 
        }

        [HttpGet, Route("helloStudent")]
        [Authorize(Roles = "student")]
        public Message helloStudent()
        {
            return new Message { message = "Привіт учень!" };
        }



        [HttpGet, Route("sum")]
        public int Sum(int x, int y)
        {
            return x + y;
        }
        [HttpGet, Route("calc/{x}/{y}")]
        public int GetSum(int x, int y)
        {
            return x + y;
        }

        //[HttpGet, Route("InfoUser")]
        //[Authorize(Roles = "teacher")]
        //public UserAccount InfoUser(string nickname)
        //{
        //    UserAccount userAccount=null;
        //    BD bd = new BD();
        //    bd.connectionBD();


        //    // Используйте параметризованный запрос, чтобы избежать SQL-инъекций
        //    string sqlExpression = "SELECT nickname, password, user_account_type, full_name FROM user_account WHERE nickname = @Nickname";

        //    //SqlCommand command = new SqlCommand(sqlExpression, connection);
        //    //command.Parameters.AddWithValue("@Nickname", nickname);

        //    using (SqlCommand command = new SqlCommand(sqlExpression, bd.connection))
        //    {
        //        command.Parameters.AddWithValue("@Nickname", nickname);

        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {
        //            if (reader.Read())
        //            {
        //                userAccount=new UserAccount()
        //                {
        //                    nickname = reader["nickname"].ToString(),
        //                    password = reader["password"].ToString(),
        //                    user_account_type = reader["user_account_type"].ToString(),
        //                    full_name = reader["full_name"].ToString()
        //                };

        //                //Console.WriteLine($"Nickname: {userAccount.nickname}, Password: {userAccount.password}, Type: {userAccount.user_account_type}, Full Name: {userAccount.full_name}");
        //            }
        //            //else
        //            //{
        //            //    Console.WriteLine($"User with nickname {nickname} not found.");
        //            //}
        //        }
        //    }

        //    bd.closeBD();
        //    return userAccount;
        //}

    }
}
