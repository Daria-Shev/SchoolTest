using Microsoft.Data.SqlClient;
using System.Data;

namespace WebSerCore.Class
{
    public class BD
    {
        public SqlConnection connection;
        public void connectionBD()
        {
            //string connectionString = "Server=WIN-VF4PLQ89RM2\\SQLEXPRESS;Database=test;Trusted_Connection=True;";
            string connectionString = "Server=WIN-VF4PLQ89RM2\\SQLEXPRESS;Database=test;Trusted_Connection=True;TrustServerCertificate=true;";
            connection = new SqlConnection(connectionString);
            try
            {
                // Открываем подключение
                connection.Open();
                //Console.WriteLine("Подключение открыто");
            }
            catch (SqlException ex)
            {
                //Console.WriteLine(ex.Message);
            }
        }
        public void closeBD()
        {
            //если подключение открыто
            if (connection.State == ConnectionState.Open)
            {
                //закрываем подключение
                connection.Close();
            }

        }

    }
}
