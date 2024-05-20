using System.Net.Mail;
using System.Net;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace WebSerCore.Class
{
    public class mail
    {
        static public void mail_send(string text, string email)
        {
            MailAddress fromMailAddress = new MailAddress("DashaSchev@gmail.com", "school61.distance.tests");
            MailAddress toAdress = new MailAddress(email);


            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAdress))
            using (SmtpClient smtpClient = new SmtpClient())
            {
                mailMessage.Subject = "Cш№61 Повідомлення";
                mailMessage.Body = text;
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "ynvl ilni ncey gxbg");

                smtpClient.Send(mailMessage);
            }
        }
        static public void mail_send_student(int class_id, string test_name)
        {
            List<string> studentEmails = new List<string>();

            BD bd = new BD();
            bd.connectionBD();

            try
            {
                string sqlExpression = @"
    SELECT        dbo.student.student_email, dbo.student.user_account_id, dbo.class.class_name, dbo.student.class_id
FROM            dbo.class INNER JOIN
                         dbo.student ON dbo.class.class_id = dbo.student.class_id INNER JOIN
                         dbo.user_account ON dbo.student.user_account_id = dbo.user_account.user_account_id
WHERE        (dbo.student.class_id = @class_id)
";

                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {
                    sqlCommand.Parameters.AddWithValue("@class_id", class_id);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            studentEmails.Add(reader["student_email"].ToString());
                        }
                    }
                }
            }
            catch
            {
            }
            bd.closeBD();

            foreach (string email in studentEmails)
            {
                mail_send("Додано новий тест: "+ test_name, email);
            }
        }
        static public void mail_send_parent(int test_id, int user_account_id)
        {
            List<string> Emails = new List<string>();
            int grade = 0;
            string full_name = "";
            string test_name = "";
            string subject_name = "";
            BD bd = new BD();
            bd.connectionBD();

            try
            {
                string sqlExpression = @"
SELECT        dbo.student.student_email, dbo.student.user_account_id, dbo.student.parent_email, dbo.user_account.full_name, dbo.student_result.grade, dbo.student_result.test_id
FROM            dbo.student INNER JOIN
                         dbo.user_account ON dbo.student.user_account_id = dbo.user_account.user_account_id INNER JOIN
                         dbo.student_result ON dbo.student.user_account_id = dbo.student_result.user_account_id
WHERE        (dbo.student.user_account_id = @user_account_id) AND (dbo.student_result.test_id = @test_id)
";

                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {
                    sqlCommand.Parameters.AddWithValue("@user_account_id", user_account_id);
                    sqlCommand.Parameters.AddWithValue("@test_id", test_id);

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            grade=int.Parse(reader["grade"].ToString());
                            full_name=reader["full_name"].ToString();
                            Emails.Add(reader["parent_email"].ToString());
                        }
                    }
                }
                sqlExpression = @"
SELECT        dbo.test.test_id, dbo.test.test_name, dbo.subject.subject_name, dbo.subject.subject_id, dbo.theme.theme_id, dbo.test.user_account_id AS Expr2, dbo.teacher.email_address
FROM            dbo.test INNER JOIN
                         dbo.theme ON dbo.test.theme_id = dbo.theme.theme_id INNER JOIN
                         dbo.subject ON dbo.theme.subject_id = dbo.subject.subject_id INNER JOIN
                         dbo.user_account ON dbo.test.user_account_id = dbo.user_account.user_account_id INNER JOIN
                         dbo.teacher ON dbo.test.user_account_id = dbo.teacher.user_account_id AND dbo.user_account.user_account_id = dbo.teacher.user_account_id
WHERE        (dbo.test.test_id = @test_id)
";
                using (SqlCommand sqlCommand = new SqlCommand(sqlExpression, bd.connection))
                {
                    sqlCommand.Parameters.AddWithValue("@test_id", test_id);

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            test_name = reader["test_name"].ToString();
                            subject_name = reader["subject_name"].ToString();
                            Emails.Add(reader["email_address"].ToString());
                        }
                    }
                }
            }
            catch
            {
            }
            bd.closeBD();
            string text = full_name + "пройшов тест " + test_name +" з предмета "+ subject_name+ " і отримав: "+grade_number_string(grade);
            foreach (string email in Emails)
            {
                mail_send(text, email);
            }
        }
        static public string grade_number_string(int grade_number)
        {
            string grade = "";
            switch (grade_number)
            {
                case 1:
                    grade = "П (початковий рівень).";
                    break;
                case 2:
                    grade = "С (середній рівень).";
                    break;
                case 3:
                    grade = "Д (достатній рівень).";
                    break;
                case 4:
                    grade = "В (високий рівень).";
                    break;
            }
            return grade;
        }
    }
}
